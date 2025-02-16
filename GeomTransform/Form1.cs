using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeomTransform
{
    public partial class Form1 : Form
    {
        private PointF[] originalTriangle; // Исходные вершины треугольника
        private PointF[] transformedTriangle; // Преобразованные вершины
        private PointF pivot = new PointF(0, 0); // Опорная точка (центр экрана)
        private Chart chart;

        public Form1()
        {
            InitializeComponent();
            InitializeChart();
            InitializeTriangle();
        }

        // Инициализация Chart
        private void InitializeChart()
        {
            chart = new Chart();
            chart.Parent = splitContainer1.Panel1;
            chart.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea("MainArea");

            // Фиксируем границы осей
            area.AxisX.Minimum = -200;
            area.AxisX.Maximum = 200;
            area.AxisY.Minimum = -200;
            area.AxisY.Maximum = 200;

            // Отключаем авто-масштабирование
            area.AxisX.IsMarginVisible = false;
            area.AxisY.IsMarginVisible = false;
            area.AxisX.Enabled = AxisEnabled.True;
            area.AxisY.Enabled = AxisEnabled.True;

            chart.ChartAreas.Add(area);
        }

        // Построение исходного треугольника
        private void InitializeTriangle()
        {
            float D = 100;
            float angleRad = 60 * (float)Math.PI / 180;
            float height = D * (float)Math.Sin(angleRad);

            // Центр треугольника в (0, 0)
            originalTriangle = new PointF[]
            {
                new PointF(-D/2, height/2),  // Верхняя вершина
                new PointF(D/2, height/2),    // Правая вершина
                new PointF(0, -height/2)      // Нижняя вершина
            };

            transformedTriangle = (PointF[])originalTriangle.Clone();
            pivot = new PointF(0, 0); // Центр экрана
        }

        // Отрисовка треугольника
        private void DrawTriangle()
        {
            if (chart.Series.Count == 0)
            {
                Series series = new Series("Triangle");
                series.ChartType = SeriesChartType.Line;
                series.Color = Color.Blue;
                chart.Series.Add(series);
            }

            var seriesTriangle = chart.Series["Triangle"];
            seriesTriangle.Points.Clear();

            // Добавляем точки с учетом центра
            foreach (PointF p in transformedTriangle)
                seriesTriangle.Points.AddXY(p.X, p.Y);

            // Замыкаем треугольник
            seriesTriangle.Points.AddXY(
                transformedTriangle[0].X,
                transformedTriangle[0].Y
            );
        }

        // Применение аффинных преобразований
        private void ApplyTransformation(double[,] matrix)
        {
            for (int i = 0; i < transformedTriangle.Length; i++)
            {
                // Преобразование координат относительно центра
                double x = transformedTriangle[i].X - pivot.X;
                double y = transformedTriangle[i].Y - pivot.Y;

                double[,] point = { { x, y, 1 } };
                double[,] result = Matrix.Multiply(point, matrix);

                // Возвращаем координаты в исходную систему
                transformedTriangle[i] = new PointF(
                    (float)result[0, 0] + pivot.X,
                    (float)result[0, 1] + pivot.Y
                );
            }
        }

        // Кнопки управления
        private void Initialise_Click(object sender, EventArgs e)
        {
            double[,] translation = {
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 }
            };

            ApplyTransformation(translation);
            DrawTriangle();
        }

        private void button1_scaleUp_Click(object sender, EventArgs e)
        {
            // Перенос в центр, масштабирование, возврат
            double scale = 1.5;
            double[,] scalingMatrix = {
                { scale, 0, 0 },
                { 0, scale, 0 },
                { 0, 0, 1 }
            };
            ApplyTransformation(scalingMatrix);
            DrawTriangle();
        }

        private void button1_rotateLeft_Click(object sender, EventArgs e)
        {
            double angle = 60 * Math.PI / 180;
            double[,] rotationMatrix = {
                { Math.Cos(angle), Math.Sin(angle), 0 },
                { -Math.Sin(angle), Math.Cos(angle), 0 },
                { 0, 0, 1 }
            };

            ApplyTransformation(rotationMatrix);
            DrawTriangle();
        }
    }
}
