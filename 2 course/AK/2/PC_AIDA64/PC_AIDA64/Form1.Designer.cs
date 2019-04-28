namespace PC_AIDA64
{
    partial class AIDA_LIGHT
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
            this.buttonOS = new System.Windows.Forms.Button();
            this.buttonCPU = new System.Windows.Forms.Button();
            this.buttonGPU = new System.Windows.Forms.Button();
            this.buttonHDD = new System.Windows.Forms.Button();
            this.buttonRAM = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonDeveloper = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOS
            // 
            this.buttonOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOS.ForeColor = System.Drawing.Color.White;
            this.buttonOS.Location = new System.Drawing.Point(23, 59);
            this.buttonOS.Name = "buttonOS";
            this.buttonOS.Size = new System.Drawing.Size(119, 48);
            this.buttonOS.TabIndex = 0;
            this.buttonOS.Text = "Операційна система";
            this.buttonOS.UseVisualStyleBackColor = true;
            this.buttonOS.Click += new System.EventHandler(this.buttonOS_Click);
            // 
            // buttonCPU
            // 
            this.buttonCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCPU.ForeColor = System.Drawing.Color.White;
            this.buttonCPU.Location = new System.Drawing.Point(23, 113);
            this.buttonCPU.Name = "buttonCPU";
            this.buttonCPU.Size = new System.Drawing.Size(119, 48);
            this.buttonCPU.TabIndex = 1;
            this.buttonCPU.Text = "Центральний процесор";
            this.buttonCPU.UseVisualStyleBackColor = true;
            this.buttonCPU.Click += new System.EventHandler(this.buttonCPU_Click);
            // 
            // buttonGPU
            // 
            this.buttonGPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGPU.ForeColor = System.Drawing.Color.White;
            this.buttonGPU.Location = new System.Drawing.Point(23, 167);
            this.buttonGPU.Name = "buttonGPU";
            this.buttonGPU.Size = new System.Drawing.Size(119, 48);
            this.buttonGPU.TabIndex = 2;
            this.buttonGPU.Text = "Відеоадаптер";
            this.buttonGPU.UseVisualStyleBackColor = true;
            this.buttonGPU.Click += new System.EventHandler(this.buttonGPU_Click);
            // 
            // buttonHDD
            // 
            this.buttonHDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHDD.ForeColor = System.Drawing.Color.White;
            this.buttonHDD.Location = new System.Drawing.Point(23, 221);
            this.buttonHDD.Name = "buttonHDD";
            this.buttonHDD.Size = new System.Drawing.Size(119, 48);
            this.buttonHDD.TabIndex = 3;
            this.buttonHDD.Text = "Накопичувач даних";
            this.buttonHDD.UseVisualStyleBackColor = true;
            this.buttonHDD.Click += new System.EventHandler(this.buttonHDD_Click);
            // 
            // buttonRAM
            // 
            this.buttonRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRAM.ForeColor = System.Drawing.Color.White;
            this.buttonRAM.Location = new System.Drawing.Point(23, 275);
            this.buttonRAM.Name = "buttonRAM";
            this.buttonRAM.Size = new System.Drawing.Size(119, 48);
            this.buttonRAM.TabIndex = 4;
            this.buttonRAM.Text = "Модуль оперативної памя\'ті";
            this.buttonRAM.UseVisualStyleBackColor = true;
            this.buttonRAM.Click += new System.EventHandler(this.buttonRAM_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.AllowDrop = true;
            this.textBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.ForeColor = System.Drawing.Color.White;
            this.textBoxInfo.Location = new System.Drawing.Point(157, 59);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(265, 297);
            this.textBoxInfo.TabIndex = 7;
            this.textBoxInfo.TabStop = false;
            this.textBoxInfo.Text = "Виберіть один з компонентів ПК для отримання детальної інформації.";
            this.textBoxInfo.TextChanged += new System.EventHandler(this.textBoxInfo_TextChanged);
            // 
            // buttonDeveloper
            // 
            this.buttonDeveloper.BackColor = System.Drawing.Color.White;
            this.buttonDeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeveloper.ForeColor = System.Drawing.Color.Black;
            this.buttonDeveloper.Location = new System.Drawing.Point(317, 362);
            this.buttonDeveloper.Name = "buttonDeveloper";
            this.buttonDeveloper.Size = new System.Drawing.Size(107, 27);
            this.buttonDeveloper.TabIndex = 5;
            this.buttonDeveloper.Text = "Про розробника";
            this.buttonDeveloper.UseVisualStyleBackColor = false;
            this.buttonDeveloper.Click += new System.EventHandler(this.buttonDeveloper_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.ForeColor = System.Drawing.Color.White;
            this.buttonAll.Location = new System.Drawing.Point(23, 329);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(119, 48);
            this.buttonAll.TabIndex = 4;
            this.buttonAll.Text = "Сумарна інформація";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(153, 23);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(80, 3, 80, 3);
            this.label2.Size = new System.Drawing.Size(269, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Інформація";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Компонент";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AIDA_LIGHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(434, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonRAM);
            this.Controls.Add(this.buttonHDD);
            this.Controls.Add(this.buttonGPU);
            this.Controls.Add(this.buttonCPU);
            this.Controls.Add(this.buttonDeveloper);
            this.Controls.Add(this.buttonOS);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AIDA_LIGHT";
            this.ShowIcon = false;
            this.Text = "Основна інформація про компоненти ПК";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOS;
        private System.Windows.Forms.Button buttonCPU;
        private System.Windows.Forms.Button buttonGPU;
        private System.Windows.Forms.Button buttonHDD;
        private System.Windows.Forms.Button buttonRAM;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonDeveloper;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

