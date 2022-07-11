namespace UPSQLSECOND
{
    partial class MyResults
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
            this.buttonLogoutEditor = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.MarathonSkillsTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMyResults = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelGenderView = new System.Windows.Forms.Label();
            this.labelAgeCategories = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.dataGridViewTotalResults = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalResults)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogoutEditor
            // 
            this.buttonLogoutEditor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogoutEditor.Location = new System.Drawing.Point(697, 8);
            this.buttonLogoutEditor.Name = "buttonLogoutEditor";
            this.buttonLogoutEditor.Size = new System.Drawing.Size(91, 33);
            this.buttonLogoutEditor.TabIndex = 13;
            this.buttonLogoutEditor.Text = "Logout";
            this.buttonLogoutEditor.UseVisualStyleBackColor = true;
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
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(373, 383);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 29);
            this.buttonCancel.TabIndex = 101;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.buttonLogoutEditor);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.MarathonSkillsTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 98;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 32);
            this.panel2.TabIndex = 99;
            // 
            // labelMyResults
            // 
            this.labelMyResults.AutoSize = true;
            this.labelMyResults.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMyResults.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelMyResults.Location = new System.Drawing.Point(314, 51);
            this.labelMyResults.Name = "labelMyResults";
            this.labelMyResults.Size = new System.Drawing.Size(188, 27);
            this.labelMyResults.TabIndex = 102;
            this.labelMyResults.Text = "Мои результаты";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelDescription.Location = new System.Drawing.Point(121, 78);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(593, 57);
            this.labelDescription.TabIndex = 103;
            this.labelDescription.Text = "Это - список всех ваших прошлых результатов гонки для Marathon Skills.\r\nОбщее мес" +
    "то сравнивает всех бегунов.\r\nМесто по категории compares runners in the same gen" +
    "der and age categories.\r\n";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(221, 158);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(47, 19);
            this.labelGender.TabIndex = 104;
            this.labelGender.Text = "Пол:";
            // 
            // labelGenderView
            // 
            this.labelGenderView.AutoSize = true;
            this.labelGenderView.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenderView.Location = new System.Drawing.Point(274, 158);
            this.labelGenderView.Name = "labelGenderView";
            this.labelGenderView.Size = new System.Drawing.Size(68, 18);
            this.labelGenderView.TabIndex = 105;
            this.labelGenderView.Text = "мужской";
            // 
            // labelAgeCategories
            // 
            this.labelAgeCategories.AutoSize = true;
            this.labelAgeCategories.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAgeCategories.Location = new System.Drawing.Point(369, 157);
            this.labelAgeCategories.Name = "labelAgeCategories";
            this.labelAgeCategories.Size = new System.Drawing.Size(199, 19);
            this.labelAgeCategories.TabIndex = 106;
            this.labelAgeCategories.Text = "Возрастные категории:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(574, 158);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(49, 18);
            this.labelAge.TabIndex = 107;
            this.labelAge.Text = "18-29";
            // 
            // dataGridViewTotalResults
            // 
            this.dataGridViewTotalResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTotalResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotalResults.Location = new System.Drawing.Point(12, 180);
            this.dataGridViewTotalResults.Name = "dataGridViewTotalResults";
            this.dataGridViewTotalResults.Size = new System.Drawing.Size(776, 197);
            this.dataGridViewTotalResults.TabIndex = 108;
            // 
            // MyResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTotalResults);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelAgeCategories);
            this.Controls.Add(this.labelGenderView);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelMyResults);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MyResults";
            this.Text = "MyResults";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogoutEditor;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label MarathonSkillsTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMyResults;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelGenderView;
        private System.Windows.Forms.Label labelAgeCategories;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.DataGridView dataGridViewTotalResults;
    }
}