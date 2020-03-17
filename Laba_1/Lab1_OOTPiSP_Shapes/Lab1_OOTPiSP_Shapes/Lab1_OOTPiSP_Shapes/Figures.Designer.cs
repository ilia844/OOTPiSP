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
            this.btDraw = new System.Windows.Forms.Button();
            this.btNUgolnik = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btLine
            // 
            this.btLine.BackColor = System.Drawing.Color.DarkOrchid;
            this.btLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.btSqare.BackColor = System.Drawing.Color.DarkOrchid;
            this.btSqare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.btRectangle.BackColor = System.Drawing.Color.DarkOrchid;
            this.btRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.btTriangle.BackColor = System.Drawing.Color.DarkOrchid;
            this.btTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.btCircle.BackColor = System.Drawing.Color.DarkOrchid;
            this.btCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.btEllipse.BackColor = System.Drawing.Color.DarkOrchid;
            this.btEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEllipse.Location = new System.Drawing.Point(12, 311);
            this.btEllipse.Name = "btEllipse";
            this.btEllipse.Size = new System.Drawing.Size(130, 37);
            this.btEllipse.TabIndex = 5;
            this.btEllipse.Text = "Эллипс";
            this.btEllipse.UseVisualStyleBackColor = false;
            this.btEllipse.Click += new System.EventHandler(this.btEllipse_Click);
            // 
            // btDraw
            // 
            this.btDraw.BackColor = System.Drawing.Color.DarkOrchid;
            this.btDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDraw.Location = new System.Drawing.Point(12, 454);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(128, 46);
            this.btDraw.TabIndex = 6;
            this.btDraw.Text = "Нарисовать";
            this.btDraw.UseVisualStyleBackColor = false;
            this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
            // 
            // btNUgolnik
            // 
            this.btNUgolnik.BackColor = System.Drawing.Color.DarkOrchid;
            this.btNUgolnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNUgolnik.Location = new System.Drawing.Point(13, 374);
            this.btNUgolnik.Name = "btNUgolnik";
            this.btNUgolnik.Size = new System.Drawing.Size(130, 37);
            this.btNUgolnik.TabIndex = 7;
            this.btNUgolnik.Text = "N-угольник";
            this.btNUgolnik.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(179, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 569);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Figures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1026, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btNUgolnik);
            this.Controls.Add(this.btDraw);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLine;
        private System.Windows.Forms.Button btSqare;
        private System.Windows.Forms.Button btRectangle;
        private System.Windows.Forms.Button btTriangle;
        private System.Windows.Forms.Button btCircle;
        private System.Windows.Forms.Button btEllipse;
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.Button btNUgolnik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

