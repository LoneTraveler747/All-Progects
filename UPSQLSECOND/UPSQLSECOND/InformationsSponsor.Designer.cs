namespace UPSQLSECOND
{
    partial class InformationsSponsor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationsSponsor));
            this.close = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.Label();
            this.icon_log = new System.Windows.Forms.PictureBox();
            this.name_sponsor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_log)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("close.ErrorImage")));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.InitialImage = ((System.Drawing.Image)(resources.GetObject("close.InitialImage")));
            this.close.Location = new System.Drawing.Point(663, 11);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 36);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 8;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // description
            // 
            this.description.AllowDrop = true;
            this.description.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(107, 268);
            this.description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(584, 193);
            this.description.TabIndex = 7;
            this.description.Text = "label2";
            this.description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // icon_log
            // 
            this.icon_log.Location = new System.Drawing.Point(326, 56);
            this.icon_log.Margin = new System.Windows.Forms.Padding(2);
            this.icon_log.Name = "icon_log";
            this.icon_log.Size = new System.Drawing.Size(150, 162);
            this.icon_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_log.TabIndex = 6;
            this.icon_log.TabStop = false;
            // 
            // name_sponsor
            // 
            this.name_sponsor.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_sponsor.Location = new System.Drawing.Point(101, -2);
            this.name_sponsor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_sponsor.Name = "name_sponsor";
            this.name_sponsor.Size = new System.Drawing.Size(598, 56);
            this.name_sponsor.TabIndex = 5;
            this.name_sponsor.Text = "Наименование спонсора";
            this.name_sponsor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InformationsSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.description);
            this.Controls.Add(this.icon_log);
            this.Controls.Add(this.name_sponsor);
            this.Name = "InformationsSponsor";
            this.Text = "InformationsSponsor";
            this.Load += new System.EventHandler(this.InformationsSponsor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.PictureBox icon_log;
        private System.Windows.Forms.Label name_sponsor;
    }
}