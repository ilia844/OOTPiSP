namespace Lab1_OOTPiSP_Shapes
{
    partial class Figures
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
            this.btLine = new System.Windows.Forms.Button();
            this.btSqare = new System.Windows.Forms.Button();
            this.btRectangle = new System.Windows.Forms.Button();
            this.btTriangle = new System.Windows.Forms.Button();
            this.btCircle = new System.Windows.Forms.Button();
            this.btEllipse = new System.Windows.Forms.Button();
            this.btChooseColor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbTemp = new System.Windows.Forms.PictureBox();
            this.pbViewPenColor = new System.Windows.Forms.PictureBox();
            this.cdPenColor = new System.Windows.Forms.ColorDialog();
            this.tbPenWidth = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // btLine
            // 
            this.btLine.BackColor = System.Drawing.Color.MidnightBlue;
            this.btLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLine.Location = new System.Drawing.Point(12, 12);
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(130, 37);
            this.btLine.TabIndex = 0;
            this.btLine.Text = "Линия";
            this.btLine.UseVisualStyleBackColor = false;
            this.btLine.Click += new System.EventHandler(this.btLine_Click);
            // 
            // btSqare
            // 
            this.btSqare.BackColor = System.Drawing.Color.MidnightBlue;
            this.btSqare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSqare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSqare.Location = new System.Drawing.Point(12, 68);
            this.btSqare.Name = "btSqare";
            this.btSqare.Size = new System.Drawing.Size(130, 37);
            this.btSqare.TabIndex = 1;
            this.btSqare.Text = "Квадрат";
            this.btSqare.UseVisualStyleBackColor = false;
            this.btSqare.Click += new System.EventHandler(this.btSqare_Click);
            // 
            // btRectangle
            // 
            this.btRectangle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRectangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRectangle.Location = new System.Drawing.Point(12, 126);
            this.btRectangle.Name = "btRectangle";
            this.btRectangle.Size = new System.Drawing.Size(130, 37);
            this.btRectangle.TabIndex = 2;
            this.btRectangle.Text = "Прямоугольник";
            this.btRectangle.UseVisualStyleBackColor = false;
            this.btRectangle.Click += new System.EventHandler(this.btRectangle_Click);
            // 
            // btTriangle
            // 
            this.btTriangle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTriangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTriangle.Location = new System.Drawing.Point(12, 188);
            this.btTriangle.Name = "btTriangle";
            this.btTriangle.Size = new System.Drawing.Size(130, 37);
            this.btTriangle.TabIndex = 3;
            this.btTriangle.Text = "Треугольник";
            this.btTriangle.UseVisualStyleBackColor = false;
            this.btTriangle.Click += new System.EventHandler(this.btTriangle_Click);
            // 
            // btCircle
            // 
            this.btCircle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCircle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCircle.Location = new System.Drawing.Point(12, 251);
            this.btCircle.Name = "btCircle";
            this.btCircle.Size = new System.Drawing.Size(130, 37);
            this.btCircle.TabIndex = 4;
            this.btCircle.Text = "Круг";
            this.btCircle.UseVisualStyleBackColor = false;
            this.btCircle.Click += new System.EventHandler(this.btCircle_Click);
            // 
            // btEllipse
            // 
            this.btEllipse.BackColor = System.Drawing.Color.MidnightBlue;
            this.btEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEllipse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEllipse.Location = new System.Drawing.Point(12, 311);
            this.btEllipse.Name = "btEllipse";
            this.btEllipse.Size = new System.Drawing.Size(130, 37);
            this.btEllipse.TabIndex = 5;
            this.btEllipse.Text = "Эллипс";
            this.btEllipse.UseVisualStyleBackColor = false;
            this.btEllipse.Click += new System.EventHandler(this.btEllipse_Click);
            // 
            // btChooseColor
            // 
            this.btChooseColor.BackColor = System.Drawing.Color.MidnightBlue;
            this.btChooseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btChooseColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btChooseColor.Location = new System.Drawing.Point(195, 464);
            this.btChooseColor.Name = "btChooseColor";
            this.btChooseColor.Size = new System.Drawing.Size(89, 37);
            this.btChooseColor.TabIndex = 7;
            this.btChooseColor.Text = "Цвет";
            this.btChooseColor.UseVisualStyleBackColor = false;
            this.btChooseColor.Click += new System.EventHandler(this.btNUgolnik_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pbTemp
            // 
            this.pbTemp.BackColor = System.Drawing.SystemColors.GrayText;
            this.pbTemp.Location = new System.Drawing.Point(179, 12);
            this.pbTemp.Name = "pbTemp";
            this.pbTemp.Size = new System.Drawing.Size(835, 414);
            this.pbTemp.TabIndex = 10;
            this.pbTemp.TabStop = false;
            this.pbTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbTemp_MouseDown);
            this.pbTemp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbTemp_MouseMove);
            this.pbTemp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbTemp_MouseUp);
            // 
            // pbViewPenColor
            // 
            this.pbViewPenColor.Location = new System.Drawing.Point(320, 464);
            this.pbViewPenColor.Name = "pbViewPenColor";
            this.pbViewPenColor.Size = new System.Drawing.Size(42, 37);
            this.pbViewPenColor.TabIndex = 11;
            this.pbViewPenColor.TabStop = false;
            this.pbViewPenColor.BackColorChanged += new System.EventHandler(this.pbViewPenColor_BackColorChanged);
            // 
            // cdPenColor
            // 
            this.cdPenColor.Color = System.Drawing.Color.Maroon;
            // 
            // tbPenWidth
            // 
            this.tbPenWidth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPenWidth.Location = new System.Drawing.Point(681, 464);
            this.tbPenWidth.Minimum = 1;
            this.tbPenWidth.Name = "tbPenWidth";
            this.tbPenWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPenWidth.Size = new System.Drawing.Size(333, 56);
            this.tbPenWidth.TabIndex = 12;
            this.tbPenWidth.Value = 1;
            this.tbPenWidth.ValueChanged += new System.EventHandler(this.tbPenWidth_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(502, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ширина кисти";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Figures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1026, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPenWidth);
            this.Controls.Add(this.pbViewPenColor);
            this.Controls.Add(this.pbTemp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btChooseColor);
            this.Controls.Add(this.btEllipse);
            this.Controls.Add(this.btCircle);
            this.Controls.Add(this.btTriangle);
            this.Controls.Add(this.btRectangle);
            this.Controls.Add(this.btSqare);
            this.Controls.Add(this.btLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Figures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Figures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLine;
        private System.Windows.Forms.Button btSqare;
        private System.Windows.Forms.Button btRectangle;
        private System.Windows.Forms.Button btTriangle;
        private System.Windows.Forms.Button btCircle;
        private System.Windows.Forms.Button btEllipse;
        private System.Windows.Forms.Button btChooseColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbTemp;
        private System.Windows.Forms.PictureBox pbViewPenColor;
        private System.Windows.Forms.ColorDialog cdPenColor;
        private System.Windows.Forms.TrackBar tbPenWidth;
        private System.Windows.Forms.Label label1;
    }
}

