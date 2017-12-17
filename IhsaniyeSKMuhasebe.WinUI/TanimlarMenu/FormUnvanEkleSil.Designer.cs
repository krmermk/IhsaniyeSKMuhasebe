namespace IhsaniyeSKMuhasebe.WinUI.TanimlarMenu
{
    partial class FormUnvanEkleSil
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
            this.tbUnvanTanimla = new MetroFramework.Controls.MetroTabControl();
            this.mtpUnvanTanimla = new MetroFramework.Controls.MetroTabPage();
            this.txt = new MetroFramework.Controls.MetroTextBox();
            this.btnKapat = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.lblYeniUnvan = new MetroFramework.Controls.MetroLabel();
            this.tbGuncelle = new MetroFramework.Controls.MetroTabPage();
            this.txtGuncelle = new MetroFramework.Controls.MetroTextBox();
            this.lblDuzenle = new MetroFramework.Controls.MetroLabel();
            this.lblSeciniz = new MetroFramework.Controls.MetroLabel();
            this.btnGuncelle = new MetroFramework.Controls.MetroButton();
            this.cmbGuncelle = new MetroFramework.Controls.MetroComboBox();
            this.tbUnvanSil = new MetroFramework.Controls.MetroTabPage();
            this.lblUnvanlar = new MetroFramework.Controls.MetroLabel();
            this.btnSayfaKapat2 = new MetroFramework.Controls.MetroButton();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.cmbUnvanlar = new MetroFramework.Controls.MetroComboBox();
            this.tbUnvanTanimla.SuspendLayout();
            this.mtpUnvanTanimla.SuspendLayout();
            this.tbGuncelle.SuspendLayout();
            this.tbUnvanSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUnvanTanimla
            // 
            this.tbUnvanTanimla.Controls.Add(this.mtpUnvanTanimla);
            this.tbUnvanTanimla.Controls.Add(this.tbGuncelle);
            this.tbUnvanTanimla.Controls.Add(this.tbUnvanSil);
            this.tbUnvanTanimla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUnvanTanimla.Location = new System.Drawing.Point(20, 60);
            this.tbUnvanTanimla.Name = "tbUnvanTanimla";
            this.tbUnvanTanimla.SelectedIndex = 1;
            this.tbUnvanTanimla.Size = new System.Drawing.Size(355, 245);
            this.tbUnvanTanimla.TabIndex = 2;
            this.tbUnvanTanimla.UseSelectable = true;
            // 
            // mtpUnvanTanimla
            // 
            this.mtpUnvanTanimla.Controls.Add(this.txt);
            this.mtpUnvanTanimla.Controls.Add(this.btnKapat);
            this.mtpUnvanTanimla.Controls.Add(this.btnKaydet);
            this.mtpUnvanTanimla.Controls.Add(this.lblYeniUnvan);
            this.mtpUnvanTanimla.HorizontalScrollbarBarColor = true;
            this.mtpUnvanTanimla.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpUnvanTanimla.HorizontalScrollbarSize = 10;
            this.mtpUnvanTanimla.Location = new System.Drawing.Point(4, 38);
            this.mtpUnvanTanimla.Name = "mtpUnvanTanimla";
            this.mtpUnvanTanimla.Size = new System.Drawing.Size(347, 203);
            this.mtpUnvanTanimla.TabIndex = 0;
            this.mtpUnvanTanimla.Text = "Ekle";
            this.mtpUnvanTanimla.VerticalScrollbarBarColor = true;
            this.mtpUnvanTanimla.VerticalScrollbarHighlightOnWheel = false;
            this.mtpUnvanTanimla.VerticalScrollbarSize = 10;
            // 
            // txt
            // 
            // 
            // 
            // 
            this.txt.CustomButton.Image = null;
            this.txt.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txt.CustomButton.Name = "";
            this.txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt.CustomButton.TabIndex = 1;
            this.txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt.CustomButton.UseSelectable = true;
            this.txt.CustomButton.Visible = false;
            this.txt.Lines = new string[0];
            this.txt.Location = new System.Drawing.Point(131, 18);
            this.txt.MaxLength = 50;
            this.txt.Name = "txt";
            this.txt.PasswordChar = '\0';
            this.txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt.SelectedText = "";
            this.txt.SelectionLength = 0;
            this.txt.SelectionStart = 0;
            this.txt.ShortcutsEnabled = true;
            this.txt.Size = new System.Drawing.Size(199, 23);
            this.txt.TabIndex = 14;
            this.txt.UseSelectable = true;
            this.txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.DarkRed;
            this.btnKapat.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(238, 57);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(92, 35);
            this.btnKapat.TabIndex = 12;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseSelectable = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkRed;
            this.btnKaydet.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(131, 57);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 35);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblYeniUnvan
            // 
            this.lblYeniUnvan.AutoSize = true;
            this.lblYeniUnvan.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblYeniUnvan.Location = new System.Drawing.Point(3, 18);
            this.lblYeniUnvan.Name = "lblYeniUnvan";
            this.lblYeniUnvan.Size = new System.Drawing.Size(91, 19);
            this.lblYeniUnvan.TabIndex = 8;
            this.lblYeniUnvan.Text = "Yeni Ünvan :";
            // 
            // tbGuncelle
            // 
            this.tbGuncelle.Controls.Add(this.txtGuncelle);
            this.tbGuncelle.Controls.Add(this.lblDuzenle);
            this.tbGuncelle.Controls.Add(this.lblSeciniz);
            this.tbGuncelle.Controls.Add(this.btnGuncelle);
            this.tbGuncelle.Controls.Add(this.cmbGuncelle);
            this.tbGuncelle.HorizontalScrollbarBarColor = true;
            this.tbGuncelle.HorizontalScrollbarHighlightOnWheel = false;
            this.tbGuncelle.HorizontalScrollbarSize = 10;
            this.tbGuncelle.Location = new System.Drawing.Point(4, 38);
            this.tbGuncelle.Name = "tbGuncelle";
            this.tbGuncelle.Size = new System.Drawing.Size(347, 203);
            this.tbGuncelle.TabIndex = 2;
            this.tbGuncelle.Text = "Güncelle";
            this.tbGuncelle.VerticalScrollbarBarColor = true;
            this.tbGuncelle.VerticalScrollbarHighlightOnWheel = false;
            this.tbGuncelle.VerticalScrollbarSize = 10;
            // 
            // txtGuncelle
            // 
            // 
            // 
            // 
            this.txtGuncelle.CustomButton.Image = null;
            this.txtGuncelle.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txtGuncelle.CustomButton.Name = "";
            this.txtGuncelle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGuncelle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuncelle.CustomButton.TabIndex = 1;
            this.txtGuncelle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuncelle.CustomButton.UseSelectable = true;
            this.txtGuncelle.CustomButton.Visible = false;
            this.txtGuncelle.Lines = new string[0];
            this.txtGuncelle.Location = new System.Drawing.Point(129, 62);
            this.txtGuncelle.MaxLength = 50;
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.PasswordChar = '\0';
            this.txtGuncelle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuncelle.SelectedText = "";
            this.txtGuncelle.SelectionLength = 0;
            this.txtGuncelle.SelectionStart = 0;
            this.txtGuncelle.ShortcutsEnabled = true;
            this.txtGuncelle.Size = new System.Drawing.Size(199, 23);
            this.txtGuncelle.TabIndex = 32;
            this.txtGuncelle.UseSelectable = true;
            this.txtGuncelle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuncelle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDuzenle
            // 
            this.lblDuzenle.AutoSize = true;
            this.lblDuzenle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDuzenle.Location = new System.Drawing.Point(3, 66);
            this.lblDuzenle.Name = "lblDuzenle";
            this.lblDuzenle.Size = new System.Drawing.Size(101, 19);
            this.lblDuzenle.TabIndex = 30;
            this.lblDuzenle.Text = "Düzenleyiniz :";
            // 
            // lblSeciniz
            // 
            this.lblSeciniz.AutoSize = true;
            this.lblSeciniz.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSeciniz.Location = new System.Drawing.Point(3, 21);
            this.lblSeciniz.Name = "lblSeciniz";
            this.lblSeciniz.Size = new System.Drawing.Size(63, 19);
            this.lblSeciniz.TabIndex = 31;
            this.lblSeciniz.Text = "Seçiniz :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkRed;
            this.btnGuncelle.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(236, 109);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(92, 31);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseSelectable = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbGuncelle
            // 
            this.cmbGuncelle.FormattingEnabled = true;
            this.cmbGuncelle.ItemHeight = 23;
            this.cmbGuncelle.Location = new System.Drawing.Point(129, 11);
            this.cmbGuncelle.Name = "cmbGuncelle";
            this.cmbGuncelle.Size = new System.Drawing.Size(199, 29);
            this.cmbGuncelle.TabIndex = 28;
            this.cmbGuncelle.UseSelectable = true;
            this.cmbGuncelle.SelectedIndexChanged += new System.EventHandler(this.cmbGuncelle_SelectedIndexChanged);
            // 
            // tbUnvanSil
            // 
            this.tbUnvanSil.Controls.Add(this.lblUnvanlar);
            this.tbUnvanSil.Controls.Add(this.btnSayfaKapat2);
            this.tbUnvanSil.Controls.Add(this.btnSil);
            this.tbUnvanSil.Controls.Add(this.cmbUnvanlar);
            this.tbUnvanSil.HorizontalScrollbarBarColor = true;
            this.tbUnvanSil.HorizontalScrollbarHighlightOnWheel = false;
            this.tbUnvanSil.HorizontalScrollbarSize = 10;
            this.tbUnvanSil.Location = new System.Drawing.Point(4, 38);
            this.tbUnvanSil.Name = "tbUnvanSil";
            this.tbUnvanSil.Size = new System.Drawing.Size(347, 203);
            this.tbUnvanSil.TabIndex = 1;
            this.tbUnvanSil.Text = "Sil";
            this.tbUnvanSil.VerticalScrollbarBarColor = true;
            this.tbUnvanSil.VerticalScrollbarHighlightOnWheel = false;
            this.tbUnvanSil.VerticalScrollbarSize = 10;
            // 
            // lblUnvanlar
            // 
            this.lblUnvanlar.AutoSize = true;
            this.lblUnvanlar.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUnvanlar.Location = new System.Drawing.Point(5, 10);
            this.lblUnvanlar.Name = "lblUnvanlar";
            this.lblUnvanlar.Size = new System.Drawing.Size(77, 19);
            this.lblUnvanlar.TabIndex = 18;
            this.lblUnvanlar.Text = "Ünvanlar :";
            // 
            // btnSayfaKapat2
            // 
            this.btnSayfaKapat2.BackColor = System.Drawing.Color.DarkRed;
            this.btnSayfaKapat2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSayfaKapat2.ForeColor = System.Drawing.Color.White;
            this.btnSayfaKapat2.Location = new System.Drawing.Point(238, 58);
            this.btnSayfaKapat2.Name = "btnSayfaKapat2";
            this.btnSayfaKapat2.Size = new System.Drawing.Size(92, 31);
            this.btnSayfaKapat2.TabIndex = 16;
            this.btnSayfaKapat2.Text = "Kapat";
            this.btnSayfaKapat2.UseSelectable = true;
            this.btnSayfaKapat2.Click += new System.EventHandler(this.btnSayfaKapat2_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkRed;
            this.btnSil.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(131, 58);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 31);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbUnvanlar
            // 
            this.cmbUnvanlar.FormattingEnabled = true;
            this.cmbUnvanlar.ItemHeight = 23;
            this.cmbUnvanlar.Location = new System.Drawing.Point(131, 10);
            this.cmbUnvanlar.Name = "cmbUnvanlar";
            this.cmbUnvanlar.Size = new System.Drawing.Size(199, 29);
            this.cmbUnvanlar.TabIndex = 15;
            this.cmbUnvanlar.UseSelectable = true;
            // 
            // FormUnvanEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 325);
            this.Controls.Add(this.tbUnvanTanimla);
            this.Name = "FormUnvanEkleSil";
            this.Text = "Ünvan";
            this.Load += new System.EventHandler(this.FormUnvanEkleSil_Load);
            this.tbUnvanTanimla.ResumeLayout(false);
            this.mtpUnvanTanimla.ResumeLayout(false);
            this.mtpUnvanTanimla.PerformLayout();
            this.tbGuncelle.ResumeLayout(false);
            this.tbGuncelle.PerformLayout();
            this.tbUnvanSil.ResumeLayout(false);
            this.tbUnvanSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbUnvanTanimla;
        private MetroFramework.Controls.MetroTabPage mtpUnvanTanimla;
        private MetroFramework.Controls.MetroButton btnKapat;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroLabel lblYeniUnvan;
        private MetroFramework.Controls.MetroTabPage tbUnvanSil;
        private MetroFramework.Controls.MetroLabel lblUnvanlar;
        private MetroFramework.Controls.MetroButton btnSayfaKapat2;
        private MetroFramework.Controls.MetroButton btnSil;
        public MetroFramework.Controls.MetroComboBox cmbUnvanlar;
        public MetroFramework.Controls.MetroTextBox txt;
        private MetroFramework.Controls.MetroTabPage tbGuncelle;
        public MetroFramework.Controls.MetroTextBox txtGuncelle;
        private MetroFramework.Controls.MetroLabel lblDuzenle;
        private MetroFramework.Controls.MetroLabel lblSeciniz;
        private MetroFramework.Controls.MetroButton btnGuncelle;
        public MetroFramework.Controls.MetroComboBox cmbGuncelle;
    }
}