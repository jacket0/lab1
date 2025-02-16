namespace GeomTransform
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Initialise = new System.Windows.Forms.Button();
            this.button1_scaleUp = new System.Windows.Forms.Button();
            this.button1_rotateLeft = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Initialise
            // 
            this.Initialise.Location = new System.Drawing.Point(12, 84);
            this.Initialise.Name = "Initialise";
            this.Initialise.Size = new System.Drawing.Size(150, 30);
            this.Initialise.TabIndex = 1;
            this.Initialise.Text = "Построить треугольник";
            this.Initialise.UseVisualStyleBackColor = true;
            this.Initialise.Click += new System.EventHandler(this.Initialise_Click);
            // 
            // button1_scaleUp
            // 
            this.button1_scaleUp.Location = new System.Drawing.Point(12, 48);
            this.button1_scaleUp.Name = "button1_scaleUp";
            this.button1_scaleUp.Size = new System.Drawing.Size(150, 30);
            this.button1_scaleUp.TabIndex = 3;
            this.button1_scaleUp.Text = "Увеличить маштаб";
            this.button1_scaleUp.UseVisualStyleBackColor = true;
            this.button1_scaleUp.Click += new System.EventHandler(this.button1_scaleUp_Click);
            // 
            // button1_rotateLeft
            // 
            this.button1_rotateLeft.Location = new System.Drawing.Point(12, 12);
            this.button1_rotateLeft.Name = "button1_rotateLeft";
            this.button1_rotateLeft.Size = new System.Drawing.Size(150, 30);
            this.button1_rotateLeft.TabIndex = 6;
            this.button1_rotateLeft.Text = "Поверуть влево";
            this.button1_rotateLeft.UseVisualStyleBackColor = true;
            this.button1_rotateLeft.Click += new System.EventHandler(this.button1_rotateLeft_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1_rotateLeft);
            this.splitContainer1.Panel2.Controls.Add(this.Initialise);
            this.splitContainer1.Panel2.Controls.Add(this.button1_scaleUp);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 623;
            this.splitContainer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Initialise;
        private System.Windows.Forms.Button button1_scaleUp;
        private System.Windows.Forms.Button button1_rotateLeft;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

