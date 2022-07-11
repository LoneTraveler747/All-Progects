namespace HappyZoo
{
    partial class Barder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.dataGridViewBarder = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxIn = new System.Windows.Forms.ComboBox();
            this.comboBoxOut = new System.Windows.Forms.ComboBox();
            this.viewAnimal = new System.Windows.Forms.TextBox();
            this.ExapeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(16, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 30);
            this.label1.TabIndex = 117;
            this.label1.Text = "Животное, которое обменяли:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 30);
            this.label5.TabIndex = 115;
            this.label5.Text = "Ответ на запрос:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // adres
            // 
            this.adres.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adres.Location = new System.Drawing.Point(306, 83);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(239, 29);
            this.adres.TabIndex = 112;
            this.adres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adres_KeyPress);
            // 
            // dataGridViewBarder
            // 
            this.dataGridViewBarder.AllowUserToAddRows = false;
            this.dataGridViewBarder.AllowUserToDeleteRows = false;
            this.dataGridViewBarder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBarder.Location = new System.Drawing.Point(12, 233);
            this.dataGridViewBarder.Name = "dataGridViewBarder";
            this.dataGridViewBarder.Size = new System.Drawing.Size(777, 205);
            this.dataGridViewBarder.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label8.Location = new System.Drawing.Point(48, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 30);
            this.label8.TabIndex = 110;
            this.label8.Text = "Входящий запрос обмена:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(70, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 30);
            this.label3.TabIndex = 108;
            this.label3.Text = "Адрес:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(198)))), ((int)(((byte)(33)))));
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(33)))));
            this.button2.Location = new System.Drawing.Point(306, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 32);
            this.button2.TabIndex = 107;
            this.button2.Text = "Обменять";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxIn
            // 
            this.comboBoxIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxIn.FormattingEnabled = true;
            this.comboBoxIn.Location = new System.Drawing.Point(306, 12);
            this.comboBoxIn.Name = "comboBoxIn";
            this.comboBoxIn.Size = new System.Drawing.Size(239, 30);
            this.comboBoxIn.TabIndex = 121;
            // 
            // comboBoxOut
            // 
            this.comboBoxOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOut.FormattingEnabled = true;
            this.comboBoxOut.Location = new System.Drawing.Point(306, 48);
            this.comboBoxOut.Name = "comboBoxOut";
            this.comboBoxOut.Size = new System.Drawing.Size(239, 30);
            this.comboBoxOut.TabIndex = 122;
            // 
            // viewAnimal
            // 
            this.viewAnimal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewAnimal.Location = new System.Drawing.Point(306, 118);
            this.viewAnimal.Multiline = true;
            this.viewAnimal.Name = "viewAnimal";
            this.viewAnimal.Size = new System.Drawing.Size(200, 29);
            this.viewAnimal.TabIndex = 123;
            this.viewAnimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.viewAnimal_KeyPress);
            // 
            // ExapeButton
            // 
            this.ExapeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(198)))), ((int)(((byte)(33)))));
            this.ExapeButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExapeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(33)))));
            this.ExapeButton.Location = new System.Drawing.Point(679, 12);
            this.ExapeButton.Name = "ExapeButton";
            this.ExapeButton.Size = new System.Drawing.Size(109, 32);
            this.ExapeButton.TabIndex = 124;
            this.ExapeButton.Text = "Выход";
            this.ExapeButton.UseVisualStyleBackColor = false;
            this.ExapeButton.Click += new System.EventHandler(this.ExapeButton_Click);
            // 
            // Barder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExapeButton);
            this.Controls.Add(this.viewAnimal);
            this.Controls.Add(this.comboBoxOut);
            this.Controls.Add(this.comboBoxIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.dataGridViewBarder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Name = "Barder";
            this.Text = "Barder";
            this.Load += new System.EventHandler(this.Barder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.DataGridView dataGridViewBarder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxIn;
        private System.Windows.Forms.ComboBox comboBoxOut;
        private System.Windows.Forms.TextBox viewAnimal;
        private System.Windows.Forms.Button ExapeButton;
    }
}