namespace Cars_Editor
{
    partial class FormCars
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCarBrand = new System.Windows.Forms.ComboBox();
            this.tbProperty = new System.Windows.Forms.TextBox();
            this.cbProperty = new System.Windows.Forms.ComboBox();
            this.btSaveChanges = new System.Windows.Forms.Button();
            this.lbAllCars = new System.Windows.Forms.ListBox();
            this.lbCarInfo = new System.Windows.Forms.ListBox();
            this.btCreateCar = new System.Windows.Forms.Button();
            this.btRemoveCar = new System.Windows.Forms.Button();
            this.cdCarColor = new System.Windows.Forms.ColorDialog();
            this.btSetColor = new System.Windows.Forms.Button();
            this.pbViewColor = new System.Windows.Forms.PictureBox();
            this.btSerialize = new System.Windows.Forms.Button();
            this.btDeserialize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка машины :";
            // 
            // cbCarBrand
            // 
            this.cbCarBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCarBrand.FormattingEnabled = true;
            this.cbCarBrand.Location = new System.Drawing.Point(163, 6);
            this.cbCarBrand.Name = "cbCarBrand";
            this.cbCarBrand.Size = new System.Drawing.Size(197, 28);
            this.cbCarBrand.TabIndex = 1;
            // 
            // tbProperty
            // 
            this.tbProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProperty.Location = new System.Drawing.Point(608, 11);
            this.tbProperty.Name = "tbProperty";
            this.tbProperty.Size = new System.Drawing.Size(178, 26);
            this.tbProperty.TabIndex = 6;
            // 
            // cbProperty
            // 
            this.cbProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbProperty.FormattingEnabled = true;
            this.cbProperty.Location = new System.Drawing.Point(608, 43);
            this.cbProperty.Name = "cbProperty";
            this.cbProperty.Size = new System.Drawing.Size(178, 28);
            this.cbProperty.TabIndex = 7;
            // 
            // btSaveChanges
            // 
            this.btSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSaveChanges.Location = new System.Drawing.Point(477, 39);
            this.btSaveChanges.Name = "btSaveChanges";
            this.btSaveChanges.Size = new System.Drawing.Size(125, 35);
            this.btSaveChanges.TabIndex = 9;
            this.btSaveChanges.Text = "Сохранить";
            this.btSaveChanges.UseVisualStyleBackColor = true;
            this.btSaveChanges.Click += new System.EventHandler(this.btSaveChanges_Click);
            // 
            // lbAllCars
            // 
            this.lbAllCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllCars.FormattingEnabled = true;
            this.lbAllCars.ItemHeight = 25;
            this.lbAllCars.Location = new System.Drawing.Point(26, 112);
            this.lbAllCars.Name = "lbAllCars";
            this.lbAllCars.Size = new System.Drawing.Size(309, 279);
            this.lbAllCars.TabIndex = 10;
            this.lbAllCars.SelectedIndexChanged += new System.EventHandler(this.lbAllCars_SelectedIndexChanged);
            // 
            // lbCarInfo
            // 
            this.lbCarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCarInfo.FormattingEnabled = true;
            this.lbCarInfo.ItemHeight = 25;
            this.lbCarInfo.Location = new System.Drawing.Point(477, 112);
            this.lbCarInfo.Name = "lbCarInfo";
            this.lbCarInfo.Size = new System.Drawing.Size(309, 279);
            this.lbCarInfo.TabIndex = 11;
            this.lbCarInfo.SelectedIndexChanged += new System.EventHandler(this.lbCarInfo_SelectedIndexChanged);
            // 
            // btCreateCar
            // 
            this.btCreateCar.Location = new System.Drawing.Point(26, 56);
            this.btCreateCar.Name = "btCreateCar";
            this.btCreateCar.Size = new System.Drawing.Size(141, 31);
            this.btCreateCar.TabIndex = 12;
            this.btCreateCar.Text = "Создать";
            this.btCreateCar.UseVisualStyleBackColor = true;
            this.btCreateCar.Click += new System.EventHandler(this.btCreateCar_Click);
            // 
            // btRemoveCar
            // 
            this.btRemoveCar.Location = new System.Drawing.Point(194, 56);
            this.btRemoveCar.Name = "btRemoveCar";
            this.btRemoveCar.Size = new System.Drawing.Size(141, 31);
            this.btRemoveCar.TabIndex = 13;
            this.btRemoveCar.Text = "Удалить";
            this.btRemoveCar.UseVisualStyleBackColor = true;
            this.btRemoveCar.Click += new System.EventHandler(this.btRemoveCar_Click);
            // 
            // btSetColor
            // 
            this.btSetColor.Location = new System.Drawing.Point(608, 77);
            this.btSetColor.Name = "btSetColor";
            this.btSetColor.Size = new System.Drawing.Size(75, 31);
            this.btSetColor.TabIndex = 14;
            this.btSetColor.Text = "Цвет";
            this.btSetColor.UseVisualStyleBackColor = true;
            this.btSetColor.Click += new System.EventHandler(this.btSetColor_Click);
            // 
            // pbViewColor
            // 
            this.pbViewColor.Location = new System.Drawing.Point(689, 77);
            this.pbViewColor.Name = "pbViewColor";
            this.pbViewColor.Size = new System.Drawing.Size(97, 29);
            this.pbViewColor.TabIndex = 15;
            this.pbViewColor.TabStop = false;
            // 
            // btSerialize
            // 
            this.btSerialize.Location = new System.Drawing.Point(327, 397);
            this.btSerialize.Name = "btSerialize";
            this.btSerialize.Size = new System.Drawing.Size(151, 37);
            this.btSerialize.TabIndex = 16;
            this.btSerialize.Text = "Сериализовать";
            this.btSerialize.UseVisualStyleBackColor = true;
            this.btSerialize.Click += new System.EventHandler(this.btSerialize_Click);
            // 
            // btDeserialize
            // 
            this.btDeserialize.Location = new System.Drawing.Point(327, 440);
            this.btDeserialize.Name = "btDeserialize";
            this.btDeserialize.Size = new System.Drawing.Size(151, 37);
            this.btDeserialize.TabIndex = 17;
            this.btDeserialize.Text = "Десериализовать";
            this.btDeserialize.UseVisualStyleBackColor = true;
            this.btDeserialize.Click += new System.EventHandler(this.btDeserialize_Click);
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(831, 489);
            this.Controls.Add(this.btDeserialize);
            this.Controls.Add(this.btSerialize);
            this.Controls.Add(this.pbViewColor);
            this.Controls.Add(this.btSetColor);
            this.Controls.Add(this.btRemoveCar);
            this.Controls.Add(this.btCreateCar);
            this.Controls.Add(this.lbCarInfo);
            this.Controls.Add(this.lbAllCars);
            this.Controls.Add(this.btSaveChanges);
            this.Controls.Add(this.cbProperty);
            this.Controls.Add(this.tbProperty);
            this.Controls.Add(this.cbCarBrand);
            this.Controls.Add(this.label1);
            this.Name = "FormCars";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbViewColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCarBrand;
        private System.Windows.Forms.TextBox tbProperty;
        private System.Windows.Forms.ComboBox cbProperty;
        private System.Windows.Forms.Button btSaveChanges;
        private System.Windows.Forms.ListBox lbAllCars;
        private System.Windows.Forms.ListBox lbCarInfo;
        private System.Windows.Forms.Button btCreateCar;
        private System.Windows.Forms.Button btRemoveCar;
        private System.Windows.Forms.ColorDialog cdCarColor;
        private System.Windows.Forms.Button btSetColor;
        private System.Windows.Forms.PictureBox pbViewColor;
        private System.Windows.Forms.Button btSerialize;
        private System.Windows.Forms.Button btDeserialize;
    }
}

