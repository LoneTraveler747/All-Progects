namespace RegLog
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
            this.regust = new System.Windows.Forms.Button();
            this.inLog = new System.Windows.Forms.Button();
            this.serPassport = new System.Windows.Forms.MaskedTextBox();
            this.numPassport = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tegMail = new System.Windows.Forms.TextBox();
            this.typeMail = new System.Windows.Forms.TextBox();
            this.domen = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regust
            // 
            this.regust.Location = new System.Drawing.Point(155, 298);
            this.regust.Name = "regust";
            this.regust.Size = new System.Drawing.Size(115, 23);
            this.regust.TabIndex = 0;
            this.regust.Text = "Зарегестрироваться";
            this.regust.UseVisualStyleBackColor = true;
            this.regust.Click += new System.EventHandler(this.regust_Click);
            // 
            // inLog
            // 
            this.inLog.Location = new System.Drawing.Point(593, 118);
            this.inLog.Name = "inLog";
            this.inLog.Size = new System.Drawing.Size(115, 23);
            this.inLog.TabIndex = 1;
            this.inLog.Text = "Войти";
            this.inLog.UseVisualStyleBackColor = true;
            this.inLog.Click += new System.EventHandler(this.inLog_Click);
            // 
            // serPassport
            // 
            this.serPassport.Location = new System.Drawing.Point(141, 156);
            this.serPassport.Mask = "0000";
            this.serPassport.Name = "serPassport";
            this.serPassport.Size = new System.Drawing.Size(57, 20);
            this.serPassport.TabIndex = 5;
            this.serPassport.ValidatingType = typeof(int);
            // 
            // numPassport
            // 
            this.numPassport.Location = new System.Drawing.Point(201, 156);
            this.numPassport.Mask = "000000";
            this.numPassport.Name = "numPassport";
            this.numPassport.Size = new System.Drawing.Size(98, 20);
            this.numPassport.TabIndex = 6;
            this.numPassport.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(168, 192);
            this.maskedTextBox1.Mask = "0(000) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(92, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // tegMail
            // 
            this.tegMail.Location = new System.Drawing.Point(93, 230);
            this.tegMail.Name = "tegMail";
            this.tegMail.Size = new System.Drawing.Size(92, 20);
            this.tegMail.TabIndex = 8;
            // 
            // typeMail
            // 
            this.typeMail.Location = new System.Drawing.Point(191, 230);
            this.typeMail.Name = "typeMail";
            this.typeMail.Size = new System.Drawing.Size(69, 20);
            this.typeMail.TabIndex = 9;
            // 
            // domen
            // 
            this.domen.Location = new System.Drawing.Point(266, 230);
            this.domen.Name = "domen";
            this.domen.Size = new System.Drawing.Size(58, 20);
            this.domen.TabIndex = 10;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(113, 275);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(71, 17);
            this.male.TabIndex = 11;
            this.male.TabStop = true;
            this.male.Text = "Мужской";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(239, 275);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(72, 17);
            this.female.TabIndex = 12;
            this.female.TabStop = true;
            this.female.Text = "Женский";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Повтор пароля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Серия и номер паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Почта";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(141, 66);
            this.maskedTextBox2.Mask = "AAAAAAAAAA";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(158, 20);
            this.maskedTextBox2.TabIndex = 19;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(141, 92);
            this.maskedTextBox3.Mask = "AAAAAAAAAAAAAAAA";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(158, 20);
            this.maskedTextBox3.TabIndex = 20;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(141, 118);
            this.maskedTextBox4.Mask = "AAAAAAAAAAAAAAAA";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(158, 20);
            this.maskedTextBox4.TabIndex = 21;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Регистрация";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(638, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Вход";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(573, 66);
            this.maskedTextBox5.Mask = "AAAAAAAAAA";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(158, 20);
            this.maskedTextBox5.TabIndex = 24;
            this.maskedTextBox5.ValidatingType = typeof(int);
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(573, 92);
            this.maskedTextBox6.Mask = "AAAAAAAAAAAAAAAA";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(158, 20);
            this.maskedTextBox6.TabIndex = 25;
            this.maskedTextBox6.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(749, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Логин";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(749, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Пароль";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Пол";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 462);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.domen);
            this.Controls.Add(this.typeMail);
            this.Controls.Add(this.tegMail);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.numPassport);
            this.Controls.Add(this.serPassport);
            this.Controls.Add(this.inLog);
            this.Controls.Add(this.regust);
            this.MaximumSize = new System.Drawing.Size(842, 501);
            this.MinimumSize = new System.Drawing.Size(842, 501);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regust;
        private System.Windows.Forms.Button inLog;
        private System.Windows.Forms.MaskedTextBox serPassport;
        private System.Windows.Forms.MaskedTextBox numPassport;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox tegMail;
        private System.Windows.Forms.TextBox typeMail;
        private System.Windows.Forms.TextBox domen;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

