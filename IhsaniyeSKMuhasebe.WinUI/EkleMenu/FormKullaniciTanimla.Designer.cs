namespace IhsaniyeSKMuhasebe.WinUI.EkleMenu
{
    partial class FormKullaniciTanimla
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
            this.tbKullanici = new MetroFramework.Controls.MetroTabControl();
            this.tbKullaniciEkle = new MetroFramework.Controls.MetroTabPage();
            this.btnSayfaKapat1 = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.txtKullaniciAdi = new MetroFramework.Controls.MetroTextBox();
            this.lblSifre = new MetroFramework.Controls.MetroLabel();
            this.cmbPersonel = new MetroFramework.Controls.MetroComboBox();
            this.lblKullaniciAdi = new MetroFramework.Controls.MetroLabel();
            this.lblPersonel = new MetroFramework.Controls.MetroLabel();
            this.tbKullaniciSil = new MetroFramework.Controls.MetroTabPage();
            this.btnSayfaKapat2 = new MetroFramework.Controls.MetroButton();
            this.btnKullaniciSil = new MetroFramework.Controls.MetroButton();
            this.cmbKullanici = new MetroFramework.Controls.MetroComboBox();
            this.lblKullanici = new MetroFramework.Controls.MetroLabel();
            this.tbKullanici.SuspendLayout();
            this.tbKullaniciEkle.SuspendLayout();
            this.tbKullaniciSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbKullanici
            // 
            this.tbKullanici.Controls.Add(this.tbKullaniciEkle);
            this.tbKullanici.Controls.Add(this.tbKullaniciSil);
            this.tbKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKullanici.Location = new System.Drawing.Point(20, 60);
            this.tbKullanici.Name = "tbKullanici";
            this.tbKullanici.SelectedIndex = 0;
            this.tbKullanici.Size = new System.Drawing.Size(333, 228);
            this.tbKullanici.TabIndex = 14;
            this.tbKullanici.UseSelectable = true;
            // 
            // tbKullaniciEkle
            // 
            this.tbKullaniciEkle.Controls.Add(this.btnSayfaKapat1);
            this.tbKullaniciEkle.Controls.Add(this.btnKaydet);
            this.tbKullaniciEkle.Controls.Add(this.txtSifre);
            this.tbKullaniciEkle.Controls.Add(this.txtKullaniciAdi);
            this.tbKullaniciEkle.Controls.Add(this.lblSifre);
            this.tbKullaniciEkle.Controls.Add(this.cmbPersonel);
            this.tbKullaniciEkle.Controls.Add(this.lblKullaniciAdi);
            this.tbKullaniciEkle.Controls.Add(this.lblPersonel);
            this.tbKullaniciEkle.HorizontalScrollbarBarColor = true;
            this.tbKullaniciEkle.HorizontalScrollbarHighlightOnWheel = false;
            this.tbKullaniciEkle.HorizontalScrollbarSize = 10;
            this.tbKullaniciEkle.Location = new System.Drawing.Point(4, 38);
            this.tbKullaniciEkle.Name = "tbKullaniciEkle";
            this.tbKullaniciEkle.Size = new System.Drawing.Size(325, 186);
            this.tbKullaniciEkle.TabIndex = 0;
            this.tbKullaniciEkle.Text = "Kullanici Ekle";
            this.tbKullaniciEkle.VerticalScrollbarBarColor = true;
            this.tbKullaniciEkle.VerticalScrollbarHighlightOnWheel = false;
            this.tbKullaniciEkle.VerticalScrollbarSize = 10;
            // 
            // btnSayfaKapat1
            // 
            this.btnSayfaKapat1.BackColor = System.Drawing.Color.DarkRed;
            this.btnSayfaKapat1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSayfaKapat1.ForeColor = System.Drawing.Color.White;
            this.btnSayfaKapat1.Location = new System.Drawing.Point(222, 132);
            this.btnSayfaKapat1.Name = "btnSayfaKapat1";
            this.btnSayfaKapat1.Size = new System.Drawing.Size(92, 50);
            this.btnSayfaKapat1.TabIndex = 20;
            this.btnSayfaKapat1.Text = "Kapat";
            this.btnSayfaKapat1.UseSelectable = true;
            this.btnSayfaKapat1.Click += new System.EventHandler(this.btnSayfaKapat1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkRed;
            this.btnKaydet.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(115, 132);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 50);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSifre
            // 
            // 
            // 
            // 
            this.txtSifre.CustomButton.Image = null;
            this.txtSifre.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txtSifre.CustomButton.Name = "";
            this.txtSifre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSifre.CustomButton.TabIndex = 1;
            this.txtSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSifre.CustomButton.UseSelectable = true;
            this.txtSifre.CustomButton.Visible = false;
            this.txtSifre.Lines = new string[0];
            this.txtSifre.Location = new System.Drawing.Point(115, 103);
            this.txtSifre.MaxLength = 150;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(199, 23);
            this.txtSifre.TabIndex = 18;
            this.txtSifre.UseSelectable = true;
            this.txtSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKullaniciAdi
            // 
            // 
            // 
            // 
            this.txtKullaniciAdi.CustomButton.Image = null;
            this.txtKullaniciAdi.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txtKullaniciAdi.CustomButton.Name = "";
            this.txtKullaniciAdi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKullaniciAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKullaniciAdi.CustomButton.TabIndex = 1;
            this.txtKullaniciAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKullaniciAdi.CustomButton.UseSelectable = true;
            this.txtKullaniciAdi.CustomButton.Visible = false;
            this.txtKullaniciAdi.Lines = new string[0];
            this.txtKullaniciAdi.Location = new System.Drawing.Point(115, 63);
            this.txtKullaniciAdi.MaxLength = 50;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.ShortcutsEnabled = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(199, 23);
            this.txtKullaniciAdi.TabIndex = 19;
            this.txtKullaniciAdi.UseSelectable = true;
            this.txtKullaniciAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKullaniciAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSifre.Location = new System.Drawing.Point(3, 107);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(48, 19);
            this.lblSifre.TabIndex = 14;
            this.lblSifre.Text = "Şifre :";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.ItemHeight = 23;
            this.cmbPersonel.Location = new System.Drawing.Point(115, 16);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(199, 29);
            this.cmbPersonel.TabIndex = 17;
            this.cmbPersonel.UseSelectable = true;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(3, 67);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(100, 19);
            this.lblKullaniciAdi.TabIndex = 15;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPersonel.Location = new System.Drawing.Point(3, 26);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(75, 19);
            this.lblPersonel.TabIndex = 16;
            this.lblPersonel.Text = "Personel :";
            // 
            // tbKullaniciSil
            // 
            this.tbKullaniciSil.Controls.Add(this.btnSayfaKapat2);
            this.tbKullaniciSil.Controls.Add(this.btnKullaniciSil);
            this.tbKullaniciSil.Controls.Add(this.cmbKullanici);
            this.tbKullaniciSil.Controls.Add(this.lblKullanici);
            this.tbKullaniciSil.HorizontalScrollbarBarColor = true;
            this.tbKullaniciSil.HorizontalScrollbarHighlightOnWheel = false;
            this.tbKullaniciSil.HorizontalScrollbarSize = 10;
            this.tbKullaniciSil.Location = new System.Drawing.Point(4, 38);
            this.tbKullaniciSil.Name = "tbKullaniciSil";
            this.tbKullaniciSil.Size = new System.Drawing.Size(325, 186);
            this.tbKullaniciSil.TabIndex = 1;
            this.tbKullaniciSil.Text = "Kullanıcı Sil";
            this.tbKullaniciSil.VerticalScrollbarBarColor = true;
            this.tbKullaniciSil.VerticalScrollbarHighlightOnWheel = false;
            this.tbKullaniciSil.VerticalScrollbarSize = 10;
            // 
            // btnSayfaKapat2
            // 
            this.btnSayfaKapat2.BackColor = System.Drawing.Color.DarkRed;
            this.btnSayfaKapat2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSayfaKapat2.ForeColor = System.Drawing.Color.White;
            this.btnSayfaKapat2.Location = new System.Drawing.Point(222, 133);
            this.btnSayfaKapat2.Name = "btnSayfaKapat2";
            this.btnSayfaKapat2.Size = new System.Drawing.Size(92, 50);
            this.btnSayfaKapat2.TabIndex = 28;
            this.btnSayfaKapat2.Text = "Kapat";
            this.btnSayfaKapat2.UseSelectable = true;
            this.btnSayfaKapat2.Click += new System.EventHandler(this.btnSayfaKapat2_Click);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.BackColor = System.Drawing.Color.DarkRed;
            this.btnKullaniciSil.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKullaniciSil.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciSil.Location = new System.Drawing.Point(115, 133);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(101, 50);
            this.btnKullaniciSil.TabIndex = 29;
            this.btnKullaniciSil.Text = "Sil";
            this.btnKullaniciSil.UseSelectable = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // cmbKullanici
            // 
            this.cmbKullanici.FormattingEnabled = true;
            this.cmbKullanici.ItemHeight = 23;
            this.cmbKullanici.Location = new System.Drawing.Point(115, 17);
            this.cmbKullanici.Name = "cmbKullanici";
            this.cmbKullanici.Size = new System.Drawing.Size(199, 29);
            this.cmbKullanici.TabIndex = 25;
            this.cmbKullanici.UseSelectable = true;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKullanici.Location = new System.Drawing.Point(3, 17);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(91, 19);
            this.lblKullanici.TabIndex = 24;
            this.lblKullanici.Text = "Kullanıcılar :";
            // 
            // FormKullaniciTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(373, 308);
            this.Controls.Add(this.tbKullanici);
            this.Name = "FormKullaniciTanimla";
            this.Text = "Kullanıcı Tanımla";
            this.Load += new System.EventHandler(this.FormKullaniciTanimla_Load);
            this.tbKullanici.ResumeLayout(false);
            this.tbKullaniciEkle.ResumeLayout(false);
            this.tbKullaniciEkle.PerformLayout();
            this.tbKullaniciSil.ResumeLayout(false);
            this.tbKullaniciSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbKullanici;
        private MetroFramework.Controls.MetroTabPage tbKullaniciEkle;
        private MetroFramework.Controls.MetroButton btnSayfaKapat1;
        private MetroFramework.Controls.MetroButton btnKaydet;
        public MetroFramework.Controls.MetroTextBox txtSifre;
        public MetroFramework.Controls.MetroTextBox txtKullaniciAdi;
        private MetroFramework.Controls.MetroLabel lblSifre;
        public MetroFramework.Controls.MetroComboBox cmbPersonel;
        private MetroFramework.Controls.MetroLabel lblKullaniciAdi;
        private MetroFramework.Controls.MetroLabel lblPersonel;
        private MetroFramework.Controls.MetroTabPage tbKullaniciSil;
        private MetroFramework.Controls.MetroButton btnSayfaKapat2;
        private MetroFramework.Controls.MetroButton btnKullaniciSil;
        public MetroFramework.Controls.MetroComboBox cmbKullanici;
        private MetroFramework.Controls.MetroLabel lblKullanici;

    }
}