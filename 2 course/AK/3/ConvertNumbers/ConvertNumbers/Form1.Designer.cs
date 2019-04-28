namespace ConvertNumbers
{
    partial class FormConvert
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
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Result10 = new System.Windows.Forms.RadioButton();
            this.radioButton_Result16 = new System.Windows.Forms.RadioButton();
            this.radioButton_Result8 = new System.Windows.Forms.RadioButton();
            this.radioButton_Result2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Source10 = new System.Windows.Forms.RadioButton();
            this.radioButton_Source16 = new System.Windows.Forms.RadioButton();
            this.radioButton_Source8 = new System.Windows.Forms.RadioButton();
            this.radioButton_Source2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBoxSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxSource.Location = new System.Drawing.Point(468, 31);
            this.textBoxSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(377, 29);
            this.textBoxSource.TabIndex = 1;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxResult.Location = new System.Drawing.Point(361, 322);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(483, 29);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.Text = "Виберіть параметри переводу та введіть число";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelSource.Location = new System.Drawing.Point(31, 28);
            this.labelSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSource.Name = "labelSource";
            this.labelSource.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelSource.Size = new System.Drawing.Size(404, 37);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Введіть число для переведення:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelResult.Location = new System.Drawing.Point(31, 320);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelResult.Size = new System.Drawing.Size(310, 37);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат переведення:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupBox1.Controls.Add(this.radioButton_Result10);
            this.groupBox1.Controls.Add(this.radioButton_Result16);
            this.groupBox1.Controls.Add(this.radioButton_Result8);
            this.groupBox1.Controls.Add(this.radioButton_Result2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(452, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(393, 207);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вихідна система числення:";
            // 
            // radioButton_Result10
            // 
            this.radioButton_Result10.AutoSize = true;
            this.radioButton_Result10.Location = new System.Drawing.Point(37, 118);
            this.radioButton_Result10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Result10.Name = "radioButton_Result10";
            this.radioButton_Result10.Size = new System.Drawing.Size(154, 33);
            this.radioButton_Result10.TabIndex = 2;
            this.radioButton_Result10.TabStop = true;
            this.radioButton_Result10.Text = "Десяткова";
            this.radioButton_Result10.UseVisualStyleBackColor = true;
            this.radioButton_Result10.Click += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // radioButton_Result16
            // 
            this.radioButton_Result16.AutoSize = true;
            this.radioButton_Result16.Location = new System.Drawing.Point(37, 160);
            this.radioButton_Result16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Result16.Name = "radioButton_Result16";
            this.radioButton_Result16.Size = new System.Drawing.Size(219, 33);
            this.radioButton_Result16.TabIndex = 3;
            this.radioButton_Result16.TabStop = true;
            this.radioButton_Result16.Text = "Шістнадцяткова";
            this.radioButton_Result16.UseVisualStyleBackColor = true;
            this.radioButton_Result16.Click += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // radioButton_Result8
            // 
            this.radioButton_Result8.AutoSize = true;
            this.radioButton_Result8.Location = new System.Drawing.Point(37, 76);
            this.radioButton_Result8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Result8.Name = "radioButton_Result8";
            this.radioButton_Result8.Size = new System.Drawing.Size(144, 33);
            this.radioButton_Result8.TabIndex = 1;
            this.radioButton_Result8.TabStop = true;
            this.radioButton_Result8.Text = "Вісімкова";
            this.radioButton_Result8.UseVisualStyleBackColor = true;
            this.radioButton_Result8.Click += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // radioButton_Result2
            // 
            this.radioButton_Result2.AutoSize = true;
            this.radioButton_Result2.Location = new System.Drawing.Point(37, 34);
            this.radioButton_Result2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Result2.Name = "radioButton_Result2";
            this.radioButton_Result2.Size = new System.Drawing.Size(136, 33);
            this.radioButton_Result2.TabIndex = 0;
            this.radioButton_Result2.TabStop = true;
            this.radioButton_Result2.Text = "Двійкова";
            this.radioButton_Result2.UseVisualStyleBackColor = true;
            this.radioButton_Result2.Click += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Source10);
            this.groupBox2.Controls.Add(this.radioButton_Source16);
            this.groupBox2.Controls.Add(this.radioButton_Source8);
            this.groupBox2.Controls.Add(this.radioButton_Source2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(31, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(393, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Система числення джерела:";
            // 
            // radioButton_Source10
            // 
            this.radioButton_Source10.AutoSize = true;
            this.radioButton_Source10.Location = new System.Drawing.Point(37, 118);
            this.radioButton_Source10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Source10.Name = "radioButton_Source10";
            this.radioButton_Source10.Size = new System.Drawing.Size(154, 33);
            this.radioButton_Source10.TabIndex = 2;
            this.radioButton_Source10.TabStop = true;
            this.radioButton_Source10.Text = "Десяткова";
            this.radioButton_Source10.UseVisualStyleBackColor = true;
            this.radioButton_Source10.Click += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // radioButton_Source16
            // 
            this.radioButton_Source16.AutoSize = true;
            this.radioButton_Source16.Location = new System.Drawing.Point(37, 160);
            this.radioButton_Source16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Source16.Name = "radioButton_Source16";
            this.radioButton_Source16.Size = new System.Drawing.Size(219, 33);
            this.radioButton_Source16.TabIndex = 3;
            this.radioButton_Source16.TabStop = true;
            this.radioButton_Source16.Text = "Шістнадцяткова";
            this.radioButton_Source16.UseVisualStyleBackColor = true;
            this.radioButton_Source16.Click += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // radioButton_Source8
            // 
            this.radioButton_Source8.AutoSize = true;
            this.radioButton_Source8.Location = new System.Drawing.Point(37, 76);
            this.radioButton_Source8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Source8.Name = "radioButton_Source8";
            this.radioButton_Source8.Size = new System.Drawing.Size(144, 33);
            this.radioButton_Source8.TabIndex = 1;
            this.radioButton_Source8.TabStop = true;
            this.radioButton_Source8.Text = "Вісімкова";
            this.radioButton_Source8.UseVisualStyleBackColor = true;
            this.radioButton_Source8.Click += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // radioButton_Source2
            // 
            this.radioButton_Source2.AutoSize = true;
            this.radioButton_Source2.Location = new System.Drawing.Point(37, 34);
            this.radioButton_Source2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Source2.Name = "radioButton_Source2";
            this.radioButton_Source2.Size = new System.Drawing.Size(136, 33);
            this.radioButton_Source2.TabIndex = 0;
            this.radioButton_Source2.TabStop = true;
            this.radioButton_Source2.Text = "Двійкова";
            this.radioButton_Source2.UseVisualStyleBackColor = true;
            this.radioButton_Source2.Click += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(31, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label1.Size = new System.Drawing.Size(276, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вигляд переведення:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(323, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.label2.Size = new System.Drawing.Size(523, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Немає історії переведень";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(876, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSource);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConvert";
            this.ShowIcon = false;
            this.Text = "Переведення чисел різних систем числення";
            this.Load += new System.EventHandler(this.FormConvert_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Result16;
        private System.Windows.Forms.RadioButton radioButton_Result8;
        private System.Windows.Forms.RadioButton radioButton_Result2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Source16;
        private System.Windows.Forms.RadioButton radioButton_Source8;
        private System.Windows.Forms.RadioButton radioButton_Source2;
        private System.Windows.Forms.RadioButton radioButton_Result10;
        private System.Windows.Forms.RadioButton radioButton_Source10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

