namespace FilmKardesligi
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTurler = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lstFilmler = new System.Windows.Forms.ListBox();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPuan1 = new System.Windows.Forms.RadioButton();
            this.rbPuan2 = new System.Windows.Forms.RadioButton();
            this.rbPuan3 = new System.Windows.Forms.RadioButton();
            this.rbPuan4 = new System.Windows.Forms.RadioButton();
            this.rbPuan5 = new System.Windows.Forms.RadioButton();
            this.btnFilmDuzenle = new System.Windows.Forms.Button();
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gboPuan = new System.Windows.Forms.GroupBox();
            this.clbTur = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.gboPuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTurler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(853, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTurler
            // 
            this.tsmiTurler.Name = "tsmiTurler";
            this.tsmiTurler.Size = new System.Drawing.Size(78, 19);
            this.tsmiTurler.Text = "Film Türleri";
            this.tsmiTurler.Click += new System.EventHandler(this.tsmiTurler_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(146, 556);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 35);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(12, 556);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(6);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(130, 35);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lstFilmler
            // 
            this.lstFilmler.DisplayMember = "Kunye";
            this.lstFilmler.FormattingEnabled = true;
            this.lstFilmler.ItemHeight = 24;
            this.lstFilmler.Location = new System.Drawing.Point(315, 67);
            this.lstFilmler.Name = "lstFilmler";
            this.lstFilmler.Size = new System.Drawing.Size(526, 460);
            this.lstFilmler.TabIndex = 6;
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(12, 67);
            this.txtFilmAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(264, 29);
            this.txtFilmAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Türü:";
            // 
            // rbPuan1
            // 
            this.rbPuan1.AutoSize = true;
            this.rbPuan1.Checked = true;
            this.rbPuan1.Location = new System.Drawing.Point(6, 28);
            this.rbPuan1.Name = "rbPuan1";
            this.rbPuan1.Size = new System.Drawing.Size(104, 28);
            this.rbPuan1.TabIndex = 17;
            this.rbPuan1.TabStop = true;
            this.rbPuan1.Tag = "1";
            this.rbPuan1.Text = "Çok Kötü";
            this.rbPuan1.UseVisualStyleBackColor = true;
            // 
            // rbPuan2
            // 
            this.rbPuan2.AutoSize = true;
            this.rbPuan2.Location = new System.Drawing.Point(6, 62);
            this.rbPuan2.Name = "rbPuan2";
            this.rbPuan2.Size = new System.Drawing.Size(66, 28);
            this.rbPuan2.TabIndex = 18;
            this.rbPuan2.Tag = "2";
            this.rbPuan2.Text = "Kötü";
            this.rbPuan2.UseVisualStyleBackColor = true;
            // 
            // rbPuan3
            // 
            this.rbPuan3.AutoSize = true;
            this.rbPuan3.Location = new System.Drawing.Point(6, 96);
            this.rbPuan3.Name = "rbPuan3";
            this.rbPuan3.Size = new System.Drawing.Size(63, 28);
            this.rbPuan3.TabIndex = 20;
            this.rbPuan3.Tag = "3";
            this.rbPuan3.Text = "Orta";
            this.rbPuan3.UseVisualStyleBackColor = true;
            // 
            // rbPuan4
            // 
            this.rbPuan4.AutoSize = true;
            this.rbPuan4.Location = new System.Drawing.Point(6, 130);
            this.rbPuan4.Name = "rbPuan4";
            this.rbPuan4.Size = new System.Drawing.Size(45, 28);
            this.rbPuan4.TabIndex = 19;
            this.rbPuan4.Tag = "4";
            this.rbPuan4.Text = "İyi";
            this.rbPuan4.UseVisualStyleBackColor = true;
            // 
            // rbPuan5
            // 
            this.rbPuan5.AutoSize = true;
            this.rbPuan5.Location = new System.Drawing.Point(6, 167);
            this.rbPuan5.Name = "rbPuan5";
            this.rbPuan5.Size = new System.Drawing.Size(83, 28);
            this.rbPuan5.TabIndex = 21;
            this.rbPuan5.Tag = "5";
            this.rbPuan5.Text = "Çok İyi";
            this.rbPuan5.UseVisualStyleBackColor = true;
            // 
            // btnFilmDuzenle
            // 
            this.btnFilmDuzenle.Location = new System.Drawing.Point(639, 556);
            this.btnFilmDuzenle.Margin = new System.Windows.Forms.Padding(6);
            this.btnFilmDuzenle.Name = "btnFilmDuzenle";
            this.btnFilmDuzenle.Size = new System.Drawing.Size(202, 35);
            this.btnFilmDuzenle.TabIndex = 8;
            this.btnFilmDuzenle.Text = "DÜZENLE";
            this.btnFilmDuzenle.UseVisualStyleBackColor = true;
            this.btnFilmDuzenle.Click += new System.EventHandler(this.btnFilmDuzenle_Click);
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.Location = new System.Drawing.Point(494, 556);
            this.btnFilmSil.Margin = new System.Windows.Forms.Padding(6);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(126, 35);
            this.btnFilmSil.TabIndex = 7;
            this.btnFilmSil.Text = "SİL";
            this.btnFilmSil.UseVisualStyleBackColor = true;
            this.btnFilmSil.Click += new System.EventHandler(this.btnFilmSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Filmler";
            // 
            // gboPuan
            // 
            this.gboPuan.Controls.Add(this.rbPuan1);
            this.gboPuan.Controls.Add(this.rbPuan2);
            this.gboPuan.Controls.Add(this.rbPuan4);
            this.gboPuan.Controls.Add(this.rbPuan3);
            this.gboPuan.Controls.Add(this.rbPuan5);
            this.gboPuan.Location = new System.Drawing.Point(12, 340);
            this.gboPuan.Name = "gboPuan";
            this.gboPuan.Size = new System.Drawing.Size(200, 202);
            this.gboPuan.TabIndex = 3;
            this.gboPuan.TabStop = false;
            this.gboPuan.Text = "Puan";
            // 
            // clbTur
            // 
            this.clbTur.CheckOnClick = true;
            this.clbTur.FormattingEnabled = true;
            this.clbTur.Location = new System.Drawing.Point(12, 141);
            this.clbTur.Name = "clbTur";
            this.clbTur.Size = new System.Drawing.Size(222, 196);
            this.clbTur.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 613);
            this.Controls.Add(this.clbTur);
            this.Controls.Add(this.gboPuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFilmDuzenle);
            this.Controls.Add(this.btnFilmSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lstFilmler);
            this.Controls.Add(this.txtFilmAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Kardeşliği";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboPuan.ResumeLayout(false);
            this.gboPuan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTurler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ListBox lstFilmler;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPuan1;
        private System.Windows.Forms.RadioButton rbPuan2;
        private System.Windows.Forms.RadioButton rbPuan3;
        private System.Windows.Forms.RadioButton rbPuan4;
        private System.Windows.Forms.RadioButton rbPuan5;
        private System.Windows.Forms.Button btnFilmDuzenle;
        private System.Windows.Forms.Button btnFilmSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboPuan;
        private System.Windows.Forms.CheckedListBox clbTur;
    }
}

