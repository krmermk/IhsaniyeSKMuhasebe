namespace IhsaniyeSKMuhasebe.WinUI.TanimlarMenu
{
    partial class FormBankaEkleSil
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tbBankaTanimla = new MetroFramework.Controls.MetroTabPage();
            this.txtBankaAdi = new MetroFramework.Controls.MetroTextBox();
            this.btnKapat = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.lblBankaAdi = new MetroFramework.Controls.MetroLabel();
            this.tbBankaGuncelle = new MetroFramework.Controls.MetroTabPage();
            this.txtBankaGuncelle = new MetroFramework.Controls.MetroTextBox();
            this.lblDuzenle = new MetroFramework.Controls.MetroLabel();
            this.lblSeciniz = new MetroFramework.Controls.MetroLabel();
            this.btnBankaGuncelle = new MetroFramework.Controls.MetroButton();
            this.cmbBankaGuncelle = new MetroFramework.Controls.MetroComboBox();
            this.tbBankaSil = new MetroFramework.Controls.MetroTabPage();
            this.lblBankalar = new MetroFramework.Controls.MetroLabel();
            this.btnSayfaKapat2 = new MetroFramework.Controls.MetroButton();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.cmbBankar = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControl1.SuspendLayout();
            this.tbBankaTanimla.SuspendLayout();
            this.tbBankaGuncelle.SuspendLayout();
            this.tbBankaSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tbBankaTanimla);
            this.metroTabControl1.Controls.Add(this.tbBankaGuncelle);
            this.metroTabControl1.Controls.Add(this.tbBankaSil);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(355, 247);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tbBankaTanimla
            // 
            this.tbBankaTanimla.Controls.Add(this.txtBankaAdi);
            this.tbBankaTanimla.Controls.Add(this.btnKapat);
            this.tbBankaTanimla.Controls.Add(this.btnKaydet);
            this.tbBankaTanimla.Controls.Add(this.lblBankaAdi);
            this.tbBankaTanimla.HorizontalScrollbarBarColor = true;
            this.tbBankaTanimla.HorizontalScrollbarHighlightOnWheel = false;
            this.tbBankaTanimla.HorizontalScrollbarSize = 10;
            this.tbBankaTanimla.Location = new System.Drawing.Point(4, 38);
            this.tbBankaTanimla.Name = "tbBankaTanimla";
            this.tbBankaTanimla.Size = new System.Drawing.Size(347, 205);
            this.tbBankaTanimla.TabIndex = 0;
            this.tbBankaTanimla.Text = "Ekle";
            this.tbBankaTanimla.VerticalScrollbarBarColor = true;
            this.tbBankaTanimla.VerticalScrollbarHighlightOnWheel = false;
            this.tbBankaTanimla.VerticalScrollbarSize = 10;
            // 
            // txtBankaAdi
            // 
            // 
            // 
            // 
            this.txtBankaAdi.CustomButton.Image = null;
            this.txtBankaAdi.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txtBankaAdi.CustomButton.Name = "";
            this.txtBankaAdi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBankaAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBankaAdi.CustomButton.TabIndex = 1;
            this.txtBankaAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBankaAdi.CustomButton.UseSelectable = true;
            this.txtBankaAdi.CustomButton.Visible = false;
            this.txtBankaAdi.Lines = new string[0];
            this.txtBankaAdi.Location = new System.Drawing.Point(120, 26);
            this.txtBankaAdi.MaxLength = 50;
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.PasswordChar = '\0';
            this.txtBankaAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBankaAdi.SelectedText = "";
            this.txtBankaAdi.SelectionLength = 0;
            this.txtBankaAdi.SelectionStart = 0;
            this.txtBankaAdi.ShortcutsEnabled = true;
            this.txtBankaAdi.Size = new System.Drawing.Size(199, 23);
            this.txtBankaAdi.TabIndex = 19;
            this.txtBankaAdi.UseSelectable = true;
            this.txtBankaAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBankaAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.DarkRed;
            this.btnKapat.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(227, 70);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(92, 35);
            this.btnKapat.TabIndex = 16;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseSelectable = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkRed;
            this.btnKaydet.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(120, 70);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 35);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblBankaAdi
            // 
            this.lblBankaAdi.AutoSize = true;
            this.lblBankaAdi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBankaAdi.Location = new System.Drawing.Point(2, 26);
            this.lblBankaAdi.Name = "lblBankaAdi";
            this.lblBankaAdi.Size = new System.Drawing.Size(85, 19);
            this.lblBankaAdi.TabIndex = 15;
            this.lblBankaAdi.Text = "Banka Adı :";
            // 
            // tbBankaGuncelle
            // 
            this.tbBankaGuncelle.Controls.Add(this.txtBankaGuncelle);
            this.tbBankaGuncelle.Controls.Add(this.lblDuzenle);
            this.tbBankaGuncelle.Controls.Add(this.lblSeciniz);
            this.tbBankaGuncelle.Controls.Add(this.btnBankaGuncelle);
            this.tbBankaGuncelle.Controls.Add(this.cmbBankaGuncelle);
            this.tbBankaGuncelle.HorizontalScrollbarBarColor = true;
            this.tbBankaGuncelle.HorizontalScrollbarHighlightOnWheel = false;
            this.tbBankaGuncelle.HorizontalScrollbarSize = 10;
            this.tbBankaGuncelle.Location = new System.Drawing.Point(4, 38);
            this.tbBankaGuncelle.Name = "tbBankaGuncelle";
            this.tbBankaGuncelle.Size = new System.Drawing.Size(347, 205);
            this.tbBankaGuncelle.TabIndex = 2;
            this.tbBankaGuncelle.Text = "Güncelle";
            this.tbBankaGuncelle.VerticalScrollbarBarColor = true;
            this.tbBankaGuncelle.VerticalScrollbarHighlightOnWheel = false;
            this.tbBankaGuncelle.VerticalScrollbarSize = 10;
            // 
            // txtBankaGuncelle
            // 
            // 
            // 
            // 
            this.txtBankaGuncelle.CustomButton.Image = null;
            this.txtBankaGuncelle.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txtBankaGuncelle.CustomButton.Name = "";
            this.txtBankaGuncelle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBankaGuncelle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBankaGuncelle.CustomButton.TabIndex = 1;
            this.txtBankaGuncelle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBankaGuncelle.CustomButton.UseSelectable = true;
            this.txtBankaGuncelle.CustomButton.Visible = false;
            this.txtBankaGuncelle.Lines = new string[0];
            this.txtBankaGuncelle.Location = new System.Drawing.Point(129, 67);
            this.txtBankaGuncelle.MaxLength = 50;
            this.txtBankaGuncelle.Name = "txtBankaGuncelle";
            this.txtBankaGuncelle.PasswordChar = '\0';
            this.txtBankaGuncelle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBankaGuncelle.SelectedText = "";
            this.txtBankaGuncelle.SelectionLength = 0;
            this.txtBankaGuncelle.SelectionStart = 0;
            this.txtBankaGuncelle.ShortcutsEnabled = true;
            this.txtBankaGuncelle.Size = new System.Drawing.Size(199, 23);
            this.txtBankaGuncelle.TabIndex = 27;
            this.txtBankaGuncelle.UseSelectable = true;
            this.txtBankaGuncelle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBankaGuncelle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDuzenle
            // 
            this.lblDuzenle.AutoSize = true;
            this.lblDuzenle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDuzenle.Location = new System.Drawing.Point(3, 71);
            this.lblDuzenle.Name = "lblDuzenle";
            this.lblDuzenle.Size = new System.Drawing.Size(101, 19);
            this.lblDuzenle.TabIndex = 26;
            this.lblDuzenle.Text = "Düzenleyiniz :";
            // 
            // lblSeciniz
            // 
            this.lblSeciniz.AutoSize = true;
            this.lblSeciniz.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSeciniz.Location = new System.Drawing.Point(3, 26);
            this.lblSeciniz.Name = "lblSeciniz";
            this.lblSeciniz.Size = new System.Drawing.Size(63, 19);
            this.lblSeciniz.TabIndex = 26;
            this.lblSeciniz.Text = "Seçiniz :";
            // 
            // btnBankaGuncelle
            // 
            this.btnBankaGuncelle.BackColor = System.Drawing.Color.DarkRed;
            this.btnBankaGuncelle.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBankaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnBankaGuncelle.Location = new System.Drawing.Point(236, 114);
            this.btnBankaGuncelle.Name = "btnBankaGuncelle";
            this.btnBankaGuncelle.Size = new System.Drawing.Size(92, 31);
            this.btnBankaGuncelle.TabIndex = 24;
            this.btnBankaGuncelle.Text = "Güncelle";
            this.btnBankaGuncelle.UseSelectable = true;
            this.btnBankaGuncelle.Click += new System.EventHandler(this.btnBankaGuncelle_Click);
            // 
            // cmbBankaGuncelle
            // 
            this.cmbBankaGuncelle.FormattingEnabled = true;
            this.cmbBankaGuncelle.ItemHeight = 23;
            this.cmbBankaGuncelle.Location = new System.Drawing.Point(129, 16);
            this.cmbBankaGuncelle.Name = "cmbBankaGuncelle";
            this.cmbBankaGuncelle.Size = new System.Drawing.Size(199, 29);
            this.cmbBankaGuncelle.TabIndex = 23;
            this.cmbBankaGuncelle.UseSelectable = true;
            this.cmbBankaGuncelle.SelectedIndexChanged += new System.EventHandler(this.cmbBankaGuncelle_SelectedIndexChanged);
            // 
            // tbBankaSil
            // 
            this.tbBankaSil.Controls.Add(this.lblBankalar);
            this.tbBankaSil.Controls.Add(this.btnSayfaKapat2);
            this.tbBankaSil.Controls.Add(this.btnSil);
            this.tbBankaSil.Controls.Add(this.cmbBankar);
            this.tbBankaSil.HorizontalScrollbarBarColor = true;
            this.tbBankaSil.HorizontalScrollbarHighlightOnWheel = false;
            this.tbBankaSil.HorizontalScrollbarSize = 10;
            this.tbBankaSil.Location = new System.Drawing.Point(4, 38);
            this.tbBankaSil.Name = "tbBankaSil";
            this.tbBankaSil.Size = new System.Drawing.Size(347, 205);
            this.tbBankaSil.TabIndex = 1;
            this.tbBankaSil.Text = "Sil";
            this.tbBankaSil.VerticalScrollbarBarColor = true;
            this.tbBankaSil.VerticalScrollbarHighlightOnWheel = false;
            this.tbBankaSil.VerticalScrollbarSize = 10;
            // 
            // lblBankalar
            // 
            this.lblBankalar.AutoSize = true;
            this.lblBankalar.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBankalar.Location = new System.Drawing.Point(6, 20);
            this.lblBankalar.Name = "lblBankalar";
            this.lblBankalar.Size = new System.Drawing.Size(76, 19);
            this.lblBankalar.TabIndex = 22;
            this.lblBankalar.Text = "Bankalar :";
            // 
            // btnSayfaKapat2
            // 
            this.btnSayfaKapat2.BackColor = System.Drawing.Color.DarkRed;
            this.btnSayfaKapat2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSayfaKapat2.ForeColor = System.Drawing.Color.White;
            this.btnSayfaKapat2.Location = new System.Drawing.Point(239, 68);
            this.btnSayfaKapat2.Name = "btnSayfaKapat2";
            this.btnSayfaKapat2.Size = new System.Drawing.Size(92, 31);
            this.btnSayfaKapat2.TabIndex = 20;
            this.btnSayfaKapat2.Text = "Kapat";
            this.btnSayfaKapat2.UseSelectable = true;
            this.btnSayfaKapat2.Click += new System.EventHandler(this.btnSayfaKapat2_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkRed;
            this.btnSil.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(132, 68);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 31);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbBankar
            // 
            this.cmbBankar.FormattingEnabled = true;
            this.cmbBankar.ItemHeight = 23;
            this.cmbBankar.Location = new System.Drawing.Point(132, 20);
            this.cmbBankar.Name = "cmbBankar";
            this.cmbBankar.Size = new System.Drawing.Size(199, 29);
            this.cmbBankar.TabIndex = 19;
            this.cmbBankar.UseSelectable = true;
            // 
            // FormBankaEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 327);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FormBankaEkleSil";
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.FormBankaEkleSil_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tbBankaTanimla.ResumeLayout(false);
            this.tbBankaTanimla.PerformLayout();
            this.tbBankaGuncelle.ResumeLayout(false);
            this.tbBankaGuncelle.PerformLayout();
            this.tbBankaSil.ResumeLayout(false);
            this.tbBankaSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tbBankaTanimla;
        private MetroFramework.Controls.MetroButton btnKapat;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroLabel lblBankaAdi;
        private MetroFramework.Controls.MetroTabPage tbBankaSil;
        private MetroFramework.Controls.MetroLabel lblBankalar;
        private MetroFramework.Controls.MetroButton btnSayfaKapat2;
        private MetroFramework.Controls.MetroButton btnSil;
        public MetroFramework.Controls.MetroComboBox cmbBankar;
        private MetroFramework.Controls.MetroTabPage tbBankaGuncelle;
        public MetroFramework.Controls.MetroTextBox txtBankaGuncelle;
        private MetroFramework.Controls.MetroLabel lblDuzenle;
        private MetroFramework.Controls.MetroLabel lblSeciniz;
        private MetroFramework.Controls.MetroButton btnBankaGuncelle;
        public MetroFramework.Controls.MetroComboBox cmbBankaGuncelle;
        private MetroFramework.Controls.MetroTextBox txtBankaAdi;
    }
}