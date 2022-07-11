namespace UPSQLSECOND
{
    partial class UserManager
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
            this.components = new System.ComponentModel.Container();
            this.AllUsersData = new System.Windows.Forms.DataGridView();
            this.AllUsersLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateButt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.MaskedTextBox();
            this.SortNameBox = new System.Windows.Forms.ComboBox();
            this.RoleBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerStart = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.BackMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddUsers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllUsersData
            // 
            this.AllUsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUsersData.Location = new System.Drawing.Point(12, 228);
            this.AllUsersData.Name = "AllUsersData";
            this.AllUsersData.Size = new System.Drawing.Size(776, 174);
            this.AllUsersData.TabIndex = 50;
            // 
            // AllUsersLabel
            // 
            this.AllUsersLabel.AutoSize = true;
            this.AllUsersLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllUsersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.AllUsersLabel.Location = new System.Drawing.Point(208, 188);
            this.AllUsersLabel.Name = "AllUsersLabel";
            this.AllUsersLabel.Size = new System.Drawing.Size(36, 19);
            this.AllUsersLabel.TabIndex = 49;
            this.AllUsersLabel.Text = "234";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(21, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "Всего пользователей:";
            // 
            // UpdateButt
            // 
            this.UpdateButt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButt.Location = new System.Drawing.Point(557, 188);
            this.UpdateButt.Name = "UpdateButt";
            this.UpdateButt.Size = new System.Drawing.Size(110, 34);
            this.UpdateButt.TabIndex = 37;
            this.UpdateButt.Text = "Обновить";
            this.UpdateButt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(487, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Поиск:";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SearchBox.Location = new System.Drawing.Point(557, 156);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(231, 26);
            this.SearchBox.TabIndex = 46;
            this.SearchBox.Text = "Поиск";
            // 
            // SortNameBox
            // 
            this.SortNameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SortNameBox.FormattingEnabled = true;
            this.SortNameBox.Location = new System.Drawing.Point(557, 124);
            this.SortNameBox.Name = "SortNameBox";
            this.SortNameBox.Size = new System.Drawing.Size(231, 26);
            this.SortNameBox.TabIndex = 45;
            this.SortNameBox.Text = "Имени";
            // 
            // RoleBox
            // 
            this.RoleBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.Location = new System.Drawing.Point(557, 93);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(231, 26);
            this.RoleBox.TabIndex = 44;
            this.RoleBox.Text = "Все роли";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(397, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Сортировать по:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(397, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Фильтр по ролям:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(219, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "Управление пользователями";
            // 
            // TimerStart
            // 
            this.TimerStart.Enabled = true;
            this.TimerStart.Interval = 1000;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Location = new System.Drawing.Point(0, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 42);
            this.panel2.TabIndex = 40;
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.Location = new System.Drawing.Point(702, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(86, 34);
            this.LogOut.TabIndex = 2;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = true;
            // 
            // BackMenu
            // 
            this.BackMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackMenu.Location = new System.Drawing.Point(12, 12);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(86, 34);
            this.BackMenu.TabIndex = 1;
            this.BackMenu.Text = "Назад";
            this.BackMenu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(111, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARATHON SKILLS 2021";
            // 
            // AddUsers
            // 
            this.AddUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUsers.Location = new System.Drawing.Point(25, 109);
            this.AddUsers.Name = "AddUsers";
            this.AddUsers.Size = new System.Drawing.Size(152, 54);
            this.AddUsers.TabIndex = 38;
            this.AddUsers.Text = "+ Добавление\r\nнового";
            this.AddUsers.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.BackMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 39;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllUsersData);
            this.Controls.Add(this.AllUsersLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SortNameBox);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AddUsers);
            this.Controls.Add(this.panel1);
            this.Name = "UserManager";
            this.Text = "UserManager";
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllUsersData;
        private System.Windows.Forms.Label AllUsersLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateButt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox SearchBox;
        private System.Windows.Forms.ComboBox SortNameBox;
        private System.Windows.Forms.ComboBox RoleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TimerStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddUsers;
        private System.Windows.Forms.Panel panel1;
    }
}