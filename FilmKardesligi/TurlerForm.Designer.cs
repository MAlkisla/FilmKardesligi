namespace FilmKardesligi
{
    partial class TurlerForm
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
            if (Disposing)
            {
                db.Dispose();
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
            this.txtTurAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstTurler = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tür:";
            // 
            // txtTurAd
            // 
            this.txtTurAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTurAd.Location = new System.Drawing.Point(78, 44);
            this.txtTurAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtTurAd.Name = "txtTurAd";
            this.txtTurAd.Size = new System.Drawing.Size(264, 29);
            this.txtTurAd.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(354, 42);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 29);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstTurler
            // 
            this.lstTurler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTurler.DisplayMember = "TurAd";
            this.lstTurler.FormattingEnabled = true;
            this.lstTurler.ItemHeight = 24;
            this.lstTurler.Location = new System.Drawing.Point(26, 92);
            this.lstTurler.Name = "lstTurler";
            this.lstTurler.Size = new System.Drawing.Size(438, 268);
            this.lstTurler.TabIndex = 3;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Location = new System.Drawing.Point(26, 431);
            this.btnSil.Margin = new System.Windows.Forms.Padding(6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(438, 42);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Location = new System.Drawing.Point(26, 383);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(6);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(438, 42);
            this.btnDuzenle.TabIndex = 4;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Location = new System.Drawing.Point(262, 42);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(6);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(80, 29);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // TurlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 481);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstTurler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTurAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(506, 520);
            this.Name = "TurlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Film Türleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTurAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstTurler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnIptal;
    }
}