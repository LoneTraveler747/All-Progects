namespace HappyZoo
{
    partial class Cell
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
            this.combinationBox = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewCell = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.burderBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.physicalBox = new System.Windows.Forms.ComboBox();
            this.feedingBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.offspirngBox = new System.Windows.Forms.TextBox();
            this.animalBox = new System.Windows.Forms.ComboBox();
            this.ExapeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCell)).BeginInit();
            this.SuspendLayout();
            // 
            // combinationBox
            // 
            this.combinationBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combinationBox.Location = new System.Drawing.Point(304, 46);
            this.combinationBox.Multiline = true;
            this.combinationBox.Name = "combinationBox";
            this.combinationBox.Size = new System.Drawing.Size(484, 32);
            this.combinationBox.TabIndex = 61;
            this.combinationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combinationBox_KeyPress);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(198)))), ((int)(((byte)(33)))));
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(33)))));
            this.buttonDelete.Location = new System.Drawing.Point(532, 195);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(256, 32);
            this.buttonDelete.TabIndex = 59;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewCell
            // 
            this.dataGridViewCell.AllowUserToAddRows = false;
            this.dataGridViewCell.AllowUserToDeleteRows = false;
            this.dataGridViewCell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCell.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCell.Location = new System.Drawing.Point(13, 233);
            this.dataGridViewCell.Name = "dataGridViewCell";
            this.dataGridViewCell.Size = new System.Drawing.Size(777, 205);
            this.dataGridViewCell.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label8.Location = new System.Drawing.Point(21, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 30);
            this.label8.TabIndex = 57;
            this.label8.Text = "Обменник:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // burderBox
            // 
            this.burderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.burderBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.burderBox.FormattingEnabled = true;
            this.burderBox.Location = new System.Drawing.Point(140, 12);
            this.burderBox.Name = "burderBox";
            this.burderBox.Size = new System.Drawing.Size(154, 30);
            this.burderBox.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label6.Location = new System.Drawing.Point(16, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 30);
            this.label6.TabIndex = 54;
            this.label6.Text = "Медосмотр:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 30);
            this.label5.TabIndex = 53;
            this.label5.Text = "Кормление:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(25, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 52;
            this.label3.Text = "Животное:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label2.Location = new System.Drawing.Point(300, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 32);
            this.label2.TabIndex = 51;
            this.label2.Text = "Информация о совмещении:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // physicalBox
            // 
            this.physicalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.physicalBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.physicalBox.FormattingEnabled = true;
            this.physicalBox.Location = new System.Drawing.Point(140, 120);
            this.physicalBox.Name = "physicalBox";
            this.physicalBox.Size = new System.Drawing.Size(154, 30);
            this.physicalBox.TabIndex = 50;
            // 
            // feedingBox
            // 
            this.feedingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.feedingBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feedingBox.FormattingEnabled = true;
            this.feedingBox.Location = new System.Drawing.Point(140, 84);
            this.feedingBox.Name = "feedingBox";
            this.feedingBox.Size = new System.Drawing.Size(154, 30);
            this.feedingBox.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label4.Location = new System.Drawing.Point(300, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 31);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ифнорацмия о потомстве:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(198)))), ((int)(((byte)(33)))));
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(33)))));
            this.button2.Location = new System.Drawing.Point(13, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 32);
            this.button2.TabIndex = 44;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // offspirngBox
            // 
            this.offspirngBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.offspirngBox.Location = new System.Drawing.Point(304, 121);
            this.offspirngBox.Multiline = true;
            this.offspirngBox.Name = "offspirngBox";
            this.offspirngBox.Size = new System.Drawing.Size(484, 32);
            this.offspirngBox.TabIndex = 43;
            this.offspirngBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combinationBox_KeyPress);
            // 
            // animalBox
            // 
            this.animalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animalBox.FormattingEnabled = true;
            this.animalBox.Location = new System.Drawing.Point(140, 48);
            this.animalBox.Name = "animalBox";
            this.animalBox.Size = new System.Drawing.Size(154, 30);
            this.animalBox.TabIndex = 42;
            // 
            // ExapeButton
            // 
            this.ExapeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(198)))), ((int)(((byte)(33)))));
            this.ExapeButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExapeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(89)))), ((int)(((byte)(33)))));
            this.ExapeButton.Location = new System.Drawing.Point(679, 11);
            this.ExapeButton.Name = "ExapeButton";
            this.ExapeButton.Size = new System.Drawing.Size(109, 32);
            this.ExapeButton.TabIndex = 112;
            this.ExapeButton.Text = "Выход";
            this.ExapeButton.UseVisualStyleBackColor = false;
            this.ExapeButton.Click += new System.EventHandler(this.ExapeButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(118)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(275, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 32);
            this.label1.TabIndex = 113;
            this.label1.Text = "Клетка для животного";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExapeButton);
            this.Controls.Add(this.combinationBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewCell);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.burderBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.physicalBox);
            this.Controls.Add(this.feedingBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.offspirngBox);
            this.Controls.Add(this.animalBox);
            this.Name = "Cell";
            this.Text = "Cell";
            this.Load += new System.EventHandler(this.Cell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox combinationBox;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewCell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox burderBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox physicalBox;
        private System.Windows.Forms.ComboBox feedingBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox offspirngBox;
        private System.Windows.Forms.ComboBox animalBox;
        private System.Windows.Forms.Button ExapeButton;
        private System.Windows.Forms.Label label1;
    }
}