namespace UPSQLSECOND
{
    partial class Authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FormAuthorization = new System.Windows.Forms.Label();
            this.MarathonSkillsTitle = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.textEmailLogin = new System.Windows.Forms.TextBox();
            this.textPasswordLogin = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Explanation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(295, 278);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(103, 29);
            this.Login.TabIndex = 35;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 32);
            this.panel2.TabIndex = 31;
            // 
            // FormAuthorization
            // 
            this.FormAuthorization.AutoSize = true;
            this.FormAuthorization.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormAuthorization.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormAuthorization.Location = new System.Drawing.Point(313, 51);
            this.FormAuthorization.Name = "FormAuthorization";
            this.FormAuthorization.Size = new System.Drawing.Size(176, 25);
            this.FormAuthorization.TabIndex = 29;
            this.FormAuthorization.Text = "Форма авторизация";
            // 
            // MarathonSkillsTitle
            // 
            this.MarathonSkillsTitle.AutoSize = true;
            this.MarathonSkillsTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarathonSkillsTitle.ForeColor = System.Drawing.Color.White;
            this.MarathonSkillsTitle.Location = new System.Drawing.Point(137, 9);
            this.MarathonSkillsTitle.Name = "MarathonSkillsTitle";
            this.MarathonSkillsTitle.Size = new System.Drawing.Size(285, 32);
            this.MarathonSkillsTitle.TabIndex = 0;
            this.MarathonSkillsTitle.Text = "Marathon Skills 2021";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(12, 8);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(91, 33);
            this.Back.TabIndex = 12;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.MarathonSkillsTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 30;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(404, 278);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(103, 29);
            this.Cancel.TabIndex = 36;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // textEmailLogin
            // 
            this.textEmailLogin.Location = new System.Drawing.Point(299, 149);
            this.textEmailLogin.Multiline = true;
            this.textEmailLogin.Name = "textEmailLogin";
            this.textEmailLogin.Size = new System.Drawing.Size(208, 25);
            this.textEmailLogin.TabIndex = 37;
            // 
            // textPasswordLogin
            // 
            this.textPasswordLogin.Location = new System.Drawing.Point(299, 212);
            this.textPasswordLogin.Multiline = true;
            this.textPasswordLogin.Name = "textPasswordLogin";
            this.textPasswordLogin.Size = new System.Drawing.Size(208, 25);
            this.textPasswordLogin.TabIndex = 38;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Email.Location = new System.Drawing.Point(219, 149);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(60, 25);
            this.Email.TabIndex = 39;
            this.Email.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(198, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Password:";
            // 
            // Explanation
            // 
            this.Explanation.AllowDrop = true;
            this.Explanation.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Explanation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Explanation.Location = new System.Drawing.Point(27, 76);
            this.Explanation.Name = "Explanation";
            this.Explanation.Size = new System.Drawing.Size(761, 25);
            this.Explanation.TabIndex = 41;
            this.Explanation.Text = "Пожалуйста, авторизуйтесь в системе, используя ваш адрес электронной почты и паро" +
    "ль.";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Explanation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textPasswordLogin);
            this.Controls.Add(this.textEmailLogin);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FormAuthorization);
            this.Controls.Add(this.Login);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FormAuthorization;
        private System.Windows.Forms.Label MarathonSkillsTitle;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox textEmailLogin;
        private System.Windows.Forms.TextBox textPasswordLogin;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Explanation;
    }
}