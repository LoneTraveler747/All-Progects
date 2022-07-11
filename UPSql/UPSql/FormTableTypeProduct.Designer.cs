namespace UPSql
{
    partial class FormTableTypeProduct
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.away = new System.Windows.Forms.Button();
            this.textType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteType = new System.Windows.Forms.Button();
            this.replaceType = new System.Windows.Forms.Button();
            this.newType = new System.Windows.Forms.Button();
            this.dataTypeView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTypeView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.away, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textType, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteType, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.replaceType, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.newType, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 209);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // away
            // 
            this.away.Location = new System.Drawing.Point(585, 3);
            this.away.Name = "away";
            this.away.Size = new System.Drawing.Size(188, 27);
            this.away.TabIndex = 27;
            this.away.Text = " Вернуться";
            this.away.UseVisualStyleBackColor = true;
            this.away.Click += new System.EventHandler(this.away_Click);
            // 
            // textType
            // 
            this.textType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textType.Location = new System.Drawing.Point(3, 107);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(188, 20);
            this.textType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название типа ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteType
            // 
            this.deleteType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteType.Location = new System.Drawing.Point(391, 107);
            this.deleteType.Name = "deleteType";
            this.deleteType.Size = new System.Drawing.Size(188, 99);
            this.deleteType.TabIndex = 3;
            this.deleteType.Text = "Удалить тип";
            this.deleteType.UseVisualStyleBackColor = true;
            this.deleteType.Click += new System.EventHandler(this.deleteType_Click);
            // 
            // replaceType
            // 
            this.replaceType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceType.Location = new System.Drawing.Point(585, 107);
            this.replaceType.Name = "replaceType";
            this.replaceType.Size = new System.Drawing.Size(188, 99);
            this.replaceType.TabIndex = 4;
            this.replaceType.Text = "Изменить тип";
            this.replaceType.UseVisualStyleBackColor = true;
            this.replaceType.Click += new System.EventHandler(this.replaceType_Click);
            // 
            // newType
            // 
            this.newType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newType.Location = new System.Drawing.Point(197, 107);
            this.newType.Name = "newType";
            this.newType.Size = new System.Drawing.Size(188, 99);
            this.newType.TabIndex = 2;
            this.newType.Text = "Добавить тип";
            this.newType.UseVisualStyleBackColor = true;
            this.newType.Click += new System.EventHandler(this.newType_Click);
            // 
            // dataTypeView
            // 
            this.dataTypeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTypeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTypeView.Location = new System.Drawing.Point(12, 227);
            this.dataTypeView.Name = "dataTypeView";
            this.dataTypeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTypeView.Size = new System.Drawing.Size(776, 211);
            this.dataTypeView.TabIndex = 2;
            this.dataTypeView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTypeView_CellContentClick);
            // 
            // FormTableTypeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTypeView);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormTableTypeProduct";
            this.Text = "FormTableTypeProduct";
            this.Load += new System.EventHandler(this.FormTableTypeProduct_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTypeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataTypeView;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteType;
        private System.Windows.Forms.Button replaceType;
        private System.Windows.Forms.Button newType;
        private System.Windows.Forms.Button away;
    }
}