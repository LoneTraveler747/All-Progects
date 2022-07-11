namespace UPSQLSECOND
{
    partial class TheManagementOfCharitableOrganizations
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
            this.Back = new System.Windows.Forms.Button();
            this.MarathonSkillsTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTheManagementOfCharitableOrganizations = new System.Windows.Forms.Label();
            this.buttonAddNewSponsor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.MarathonSkillsTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 116;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 32);
            this.panel2.TabIndex = 117;
            // 
            // labelTheManagementOfCharitableOrganizations
            // 
            this.labelTheManagementOfCharitableOrganizations.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTheManagementOfCharitableOrganizations.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelTheManagementOfCharitableOrganizations.Location = new System.Drawing.Point(216, 51);
            this.labelTheManagementOfCharitableOrganizations.Name = "labelTheManagementOfCharitableOrganizations";
            this.labelTheManagementOfCharitableOrganizations.Size = new System.Drawing.Size(394, 55);
            this.labelTheManagementOfCharitableOrganizations.TabIndex = 118;
            this.labelTheManagementOfCharitableOrganizations.Text = "Управление благотворительными организациями";
            this.labelTheManagementOfCharitableOrganizations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddNewSponsor
            // 
            this.buttonAddNewSponsor.Location = new System.Drawing.Point(100, 146);
            this.buttonAddNewSponsor.Name = "buttonAddNewSponsor";
            this.buttonAddNewSponsor.Size = new System.Drawing.Size(151, 38);
            this.buttonAddNewSponsor.TabIndex = 119;
            this.buttonAddNewSponsor.Text = "+ Добавить нового";
            this.buttonAddNewSponsor.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 222);
            this.dataGridView1.TabIndex = 120;
            // 
            // TheManagementOfCharitableOrganizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddNewSponsor);
            this.Controls.Add(this.labelTheManagementOfCharitableOrganizations);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TheManagementOfCharitableOrganizations";
            this.Text = "TheManagementOfCharitableOrganizations";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label MarathonSkillsTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTheManagementOfCharitableOrganizations;
        private System.Windows.Forms.Button buttonAddNewSponsor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}