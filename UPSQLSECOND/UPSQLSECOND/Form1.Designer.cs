namespace UPSQLSECOND
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateOfTheEvent = new System.Windows.Forms.Label();
            this.CityAndCountry = new System.Windows.Forms.Label();
            this.MarathonSkillsTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.IWantToBeARunner = new System.Windows.Forms.Button();
            this.IWantToBecomeARunnersSponsor = new System.Windows.Forms.Button();
            this.IWantToKnowMoreAboutTheEvent = new System.Windows.Forms.Button();
            this.AuthorizationForm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.DateOfTheEvent);
            this.panel1.Controls.Add(this.CityAndCountry);
            this.panel1.Controls.Add(this.MarathonSkillsTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 127);
            this.panel1.TabIndex = 0;
            // 
            // DateOfTheEvent
            // 
            this.DateOfTheEvent.AutoSize = true;
            this.DateOfTheEvent.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfTheEvent.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.DateOfTheEvent.Location = new System.Drawing.Point(264, 84);
            this.DateOfTheEvent.Name = "DateOfTheEvent";
            this.DateOfTheEvent.Size = new System.Drawing.Size(250, 29);
            this.DateOfTheEvent.TabIndex = 2;
            this.DateOfTheEvent.Text = "Среда, 21 Октября 2021";
            // 
            // CityAndCountry
            // 
            this.CityAndCountry.AutoSize = true;
            this.CityAndCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityAndCountry.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CityAndCountry.Location = new System.Drawing.Point(284, 55);
            this.CityAndCountry.Name = "CityAndCountry";
            this.CityAndCountry.Size = new System.Drawing.Size(192, 29);
            this.CityAndCountry.TabIndex = 1;
            this.CityAndCountry.Text = "Москва, Россия";
            // 
            // MarathonSkillsTitle
            // 
            this.MarathonSkillsTitle.AutoSize = true;
            this.MarathonSkillsTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarathonSkillsTitle.ForeColor = System.Drawing.Color.White;
            this.MarathonSkillsTitle.Location = new System.Drawing.Point(241, 9);
            this.MarathonSkillsTitle.Name = "MarathonSkillsTitle";
            this.MarathonSkillsTitle.Size = new System.Drawing.Size(285, 32);
            this.MarathonSkillsTitle.TabIndex = 0;
            this.MarathonSkillsTitle.Text = "Marathon Skills 2021";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.DimGray;
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(247, 20);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(279, 31);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "_____";
            // 
            // IWantToBeARunner
            // 
            this.IWantToBeARunner.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IWantToBeARunner.Location = new System.Drawing.Point(247, 160);
            this.IWantToBeARunner.Name = "IWantToBeARunner";
            this.IWantToBeARunner.Size = new System.Drawing.Size(279, 42);
            this.IWantToBeARunner.TabIndex = 2;
            this.IWantToBeARunner.Text = "Хочу стать бегуном";
            this.IWantToBeARunner.UseVisualStyleBackColor = true;
            this.IWantToBeARunner.Click += new System.EventHandler(this.IWantToBeARunner_Click);
            // 
            // IWantToBecomeARunnersSponsor
            // 
            this.IWantToBecomeARunnersSponsor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IWantToBecomeARunnersSponsor.Location = new System.Drawing.Point(247, 239);
            this.IWantToBecomeARunnersSponsor.Name = "IWantToBecomeARunnersSponsor";
            this.IWantToBecomeARunnersSponsor.Size = new System.Drawing.Size(279, 46);
            this.IWantToBecomeARunnersSponsor.TabIndex = 3;
            this.IWantToBecomeARunnersSponsor.Text = "Хочу стать спонсором бегуна";
            this.IWantToBecomeARunnersSponsor.UseVisualStyleBackColor = true;
            // 
            // IWantToKnowMoreAboutTheEvent
            // 
            this.IWantToKnowMoreAboutTheEvent.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IWantToKnowMoreAboutTheEvent.Location = new System.Drawing.Point(247, 322);
            this.IWantToKnowMoreAboutTheEvent.Name = "IWantToKnowMoreAboutTheEvent";
            this.IWantToKnowMoreAboutTheEvent.Size = new System.Drawing.Size(279, 39);
            this.IWantToKnowMoreAboutTheEvent.TabIndex = 4;
            this.IWantToKnowMoreAboutTheEvent.Text = "Хочу знать больше о событии";
            this.IWantToKnowMoreAboutTheEvent.UseVisualStyleBackColor = true;
            // 
            // AuthorizationForm
            // 
            this.AuthorizationForm.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationForm.Location = new System.Drawing.Point(697, 342);
            this.AuthorizationForm.Name = "AuthorizationForm";
            this.AuthorizationForm.Size = new System.Drawing.Size(91, 33);
            this.AuthorizationForm.TabIndex = 5;
            this.AuthorizationForm.Text = "Login";
            this.AuthorizationForm.UseVisualStyleBackColor = true;
            this.AuthorizationForm.Click += new System.EventHandler(this.AuthorizationForm_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AuthorizationForm);
            this.Controls.Add(this.IWantToKnowMoreAboutTheEvent);
            this.Controls.Add(this.IWantToBecomeARunnersSponsor);
            this.Controls.Add(this.IWantToBeARunner);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Marathon Skills 2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DateOfTheEvent;
        private System.Windows.Forms.Label CityAndCountry;
        private System.Windows.Forms.Label MarathonSkillsTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button IWantToBeARunner;
        private System.Windows.Forms.Button IWantToBecomeARunnersSponsor;
        private System.Windows.Forms.Button IWantToKnowMoreAboutTheEvent;
        private System.Windows.Forms.Button AuthorizationForm;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
    }
}

