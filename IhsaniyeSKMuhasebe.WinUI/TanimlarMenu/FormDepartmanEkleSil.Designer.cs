namespace IhsaniyeSKMuhasebe.WinUI.TanimlarMenu
{
    partial class FormDepartmanEkleSil
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
            this.tbDepartmanTanimla = new MetroFramework.Controls.MetroTabControl();
            this.mtpDepartmanTanimla = new MetroFramework.Controls.MetroTabPage();
            this.txtYeniDepartman = new MetroFramework.Controls.MetroTextBox();
            this.btnKapat = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.lblYeniDepartman = new MetroFramework.Controls.MetroLabel();
            this.tbDepartmanGuncelle = new MetroFramework.Controls.MetroTabPage();
            this.txtGuncelle = new MetroFramework.Controls.MetroTextBox();
            this.lblDuzenle = new MetroFramework.Controls.MetroLabel();
            this.lblSeciniz = new MetroFramework.Controls.MetroLabel();
            this.btnBankaGuncelle = new MetroFramework.Controls.MetroButton();
            this.cmbGuncelle = new MetroFramework.Controls.MetroComboBox();
            this.tbUyeliktenCikar = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSayfaKapat2 = new MetroFramework.Controls.MetroButton();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.cmbDepartmanlar = new MetroFramework.Controls.MetroComboBox();
            this.tbDepartmanTanimla.SuspendLayout();
            this.mtpDepartmanTanimla.SuspendLayout();
            this.tbDepartmanGuncelle.SuspendLayout();
            this.tbUyeliktenCikar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDepartmanTanimla
            // 
            this.tbDepartmanTanimla.Controls.Add(this.mtpDepartmanTanimla);
            this.tbDepartmanTanimla.Controls.Add(this.tbDepartmanGuncelle);
            this.tbDepartmanTanimla.Controls.Add(this.tbUyeliktenCikar);
            this.tbDepartmanTanimla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDepartmanTanimla.Location = new System.Drawing.Point(20, 60);
            this.tbDepartmanTanimla.Name = "tbDepartmanTanimla";
            this.tbDepartmanTanimla.SelectedIndex = 1;
            this.tbDepartmanTanimla.Size = new System.Drawing.Size(355, 249);
            this.tbDepartmanTanimla.TabIndex = 1;
            this.tbDepartmanTanimla.UseSelectable = true;
            // 
            // mtpDepartmanTanimla
            // 
            this.mtpDepartmanTanimla.Controls.Add(this.txtYeniDepartman);
            this.mtpDepartmanTanimla.Controls.Add(this.btnKapat);
            this.mtpDepartmanTanimla.Controls.Add(this.btnKaydet);
            this.mtpDepartmanTanimla.Controls.Add(this.lblYeniDepartman);
            this.mtpDepartmanTanimla.HorizontalScrollbarBarColor = true;
            this.mtpDepartmanTanimla.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpDepartmanTanimla.HorizontalScrollbarSize = 10;
            this.mtpDepartmanTanimla.Location = new System.Drawing.Point(4, 38);
            this.mtpDepartmanTanimla.Name = "mtpDepartmanTanimla";
            this.mtpDepartmanTanimla.Size = new System.Drawing.Size(347, 207);
            this.mtpDepartmanTanimla.TabIndex = 0;
            this.mtpDepartmanTanimla.Text = "Ekle";
            this.mtpDepartmanTanimla.VerticalScrollbarBarColor = true;
            this.mtpDepartmanTanimla.VerticalScrollbarHighlightOnWheel = false;
            this.mtpDepartmanTanimla.VerticalScrollbarSize = 10;
            // 
            // txtYeniDepartman
            // 
            // 
            // 
            // 
            this.txtYeniDepartman.CustomButton.Image = null;
            this.txtYeniDepartman.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txtYeniDepartman.CustomButton.Name = "";
            this.txtYeniDepartman.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtYeniDepartman.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYeniDepartman.CustomButton.TabIndex = 1;
            this.txtYeniDepartman.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYeniDepartman.CustomButton.UseSelectable = true;
            this.txtYeniDepartman.CustomButton.Visible = false;
            this.txtYeniDepartman.Lines = new string[0];
            this.txtYeniDepartman.Location = new System.Drawing.Point(131, 18);
            this.txtYeniDepartman.MaxLength = 50;
            this.txtYeniDepartman.Name = "txtYeniDepartman";
            this.txtYeniDepartman.PasswordChar = '\0';
            this.txtYeniDepartman.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYeniDepartman.SelectedText = "";
            this.txtYeniDepartman.SelectionLength = 0;
            this.txtYeniDepartman.SelectionStart = 0;
            this.txtYeniDepartman.ShortcutsEnabled = true;
            this.txtYeniDepartman.Size = new System.Drawing.Size(199, 23);
            this.txtYeniDepartman.TabIndex = 14;
            this.txtYeniDepartman.UseSelectable = true;
            this.txtYeniDepartman.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYeniDepartman.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // lblYeniDepartman
            // 
            this.lblYeniDepartman.AutoSize = true;
            this.lblYeniDepartman.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblYeniDepartman.Location = new System.Drawing.Point(3, 18);
            this.lblYeniDepartman.Name = "lblYeniDepartman";
            this.lblYeniDepartman.Size = new System.Drawing.Size(124, 19);
            this.lblYeniDepartman.TabIndex = 8;
            this.lblYeniDepartman.Text = "Yeni Departman :";
            // 
            // tbDepartmanGuncelle
            // 
            this.tbDepartmanGuncelle.Controls.Add(this.txtGuncelle);
            this.tbDepartmanGuncelle.Controls.Add(this.lblDuzenle);
            this.tbDepartmanGuncelle.Controls.Add(this.lblSeciniz);
            this.tbDepartmanGuncelle.Controls.Add(this.btnBankaGuncelle);
            this.tbDepartmanGuncelle.Controls.Add(this.cmbGuncelle);
            this.tbDepartmanGuncelle.HorizontalScrollbarBarColor = true;
            this.tbDepartmanGuncelle.HorizontalScrollbarHighlightOnWheel = false;
            this.tbDepartmanGuncelle.HorizontalScrollbarSize = 10;
            this.tbDepartmanGuncelle.Location = new System.Drawing.Point(4, 38);
            this.tbDepartmanGuncelle.Name = "tbDepartmanGuncelle";
            this.tbDepartmanGuncelle.Size = new System.Drawing.Size(347, 207);
            this.tbDepartmanGuncelle.TabIndex = 2;
            this.tbDepartmanGuncelle.Text = "Güncelle";
            this.tbDepartmanGuncelle.VerticalScrollbarBarColor = true;
            this.tbDepartmanGuncelle.VerticalScrollbarHighlightOnWheel = false;
            this.tbDepartmanGuncelle.VerticalScrollbarSize = 10;
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
            this.txtGuncelle.Location = new System.Drawing.Point(129, 63);
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
            this.lblDuzenle.Location = new System.Drawing.Point(3, 67);
            this.lblDuzenle.Name = "lblDuzenle";
            this.lblDuzenle.Size = new System.Drawing.Size(101, 19);
            this.lblDuzenle.TabIndex = 30;
            this.lblDuzenle.Text = "Düzenleyiniz :";
            // 
            // lblSeciniz
            // 
            this.lblSeciniz.AutoSize = true;
            this.lblSeciniz.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSeciniz.Location = new System.Drawing.Point(3, 22);
            this.lblSeciniz.Name = "lblSeciniz";
            this.lblSeciniz.Size = new System.Drawing.Size(63, 19);
            this.lblSeciniz.TabIndex = 31;
            this.lblSeciniz.Text = "Seçiniz :";
            // 
            // btnBankaGuncelle
            // 
            this.btnBankaGuncelle.BackColor = System.Drawing.Color.DarkRed;
            this.btnBankaGuncelle.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBankaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnBankaGuncelle.Location = new System.Drawing.Point(236, 109);
            this.btnBankaGuncelle.Name = "btnBankaGuncelle";
            this.btnBankaGuncelle.Size = new System.Drawing.Size(92, 31);
            this.btnBankaGuncelle.TabIndex = 29;
            this.btnBankaGuncelle.Text = "Güncelle";
            this.btnBankaGuncelle.UseSelectable = true;
            this.btnBankaGuncelle.Click += new System.EventHandler(this.btnBankaGuncelle_Click);
            // 
            // cmbGuncelle
            // 
            this.cmbGuncelle.FormattingEnabled = true;
            this.cmbGuncelle.ItemHeight = 23;
            this.cmbGuncelle.Location = new System.Drawing.Point(129, 12);
            this.cmbGuncelle.Name = "cmbGuncelle";
            this.cmbGuncelle.Size = new System.Drawing.Size(199, 29);
            this.cmbGuncelle.TabIndex = 28;
            this.cmbGuncelle.UseSelectable = true;
            this.cmbGuncelle.SelectedIndexChanged += new System.EventHandler(this.cmbGuncelle_SelectedIndexChanged);
            // 
            // tbUyeliktenCikar
            // 
            this.tbUyeliktenCikar.Controls.Add(this.metroLabel1);
            this.tbUyeliktenCikar.Controls.Add(this.btnSayfaKapat2);
            this.tbUyeliktenCikar.Controls.Add(this.btnSil);
            this.tbUyeliktenCikar.Controls.Add(this.cmbDepartmanlar);
            this.tbUyeliktenCikar.HorizontalScrollbarBarColor = true;
            this.tbUyeliktenCikar.HorizontalScrollbarHighlightOnWheel = false;
            this.tbUyeliktenCikar.HorizontalScrollbarSize = 10;
            this.tbUyeliktenCikar.Location = new System.Drawing.Point(4, 38);
            this.tbUyeliktenCikar.Name = "tbUyeliktenCikar";
            this.tbUyeliktenCikar.Size = new System.Drawing.Size(347, 207);
            this.tbUyeliktenCikar.TabIndex = 1;
            this.tbUyeliktenCikar.Text = "Sil";
            this.tbUyeliktenCikar.VerticalScrollbarBarColor = true;
            this.tbUyeliktenCikar.VerticalScrollbarHighlightOnWheel = false;
            this.tbUyeliktenCikar.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(5, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Yeni Departman :";
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
            // cmbDepartmanlar
            // 
            this.cmbDepartmanlar.FormattingEnabled = true;
            this.cmbDepartmanlar.ItemHeight = 23;
            this.cmbDepartmanlar.Location = new System.Drawing.Point(131, 10);
            this.cmbDepartmanlar.Name = "cmbDepartmanlar";
            this.cmbDepartmanlar.Size = new System.Drawing.Size(199, 29);
            this.cmbDepartmanlar.TabIndex = 15;
            this.cmbDepartmanlar.UseSelectable = true;
            // 
            // FormDepartmanEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 329);
            this.Controls.Add(this.tbDepartmanTanimla);
            this.Name = "FormDepartmanEkleSil";
            this.Text = "Departman";
            this.tbDepartmanTanimla.ResumeLayout(false);
            this.mtpDepartmanTanimla.ResumeLayout(false);
            this.mtpDepartmanTanimla.PerformLayout();
            this.tbDepartmanGuncelle.ResumeLayout(false);
            this.tbDepartmanGuncelle.PerformLayout();
            this.tbUyeliktenCikar.ResumeLayout(false);
            this.tbUyeliktenCikar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbDepartmanTanimla;
        private MetroFramework.Controls.MetroTabPage mtpDepartmanTanimla;
        private MetroFramework.Controls.MetroButton btnKapat;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroLabel lblYeniDepartman;
        private MetroFramework.Controls.MetroTabPage tbUyeliktenCikar;
        private MetroFramework.Controls.MetroButton btnSayfaKapat2;
        private MetroFramework.Controls.MetroButton btnSil;
        public MetroFramework.Controls.MetroComboBox cmbDepartmanlar;
        private MetroFramework.Controls.MetroTextBox txtYeniDepartman;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage tbDepartmanGuncelle;
        public MetroFramework.Controls.MetroTextBox txtGuncelle;
        private MetroFramework.Controls.MetroLabel lblDuzenle;
        private MetroFramework.Controls.MetroLabel lblSeciniz;
        private MetroFramework.Controls.MetroButton btnBankaGuncelle;
        public MetroFramework.Controls.MetroComboBox cmbGuncelle;
    }
}