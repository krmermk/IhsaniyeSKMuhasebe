namespace IhsaniyeSKMuhasebe.WinUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.görüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonelGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSirketBireyGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.tspUyeGoruntule = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonelEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSirketBireyEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspUyeTanimla = new System.Windows.Forms.ToolStripMenuItem();
            this.tspKullaniciTanimla = new System.Windows.Forms.ToolStripMenuItem();
            this.tspIseGirisCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspGelirGiderRaporla = new System.Windows.Forms.ToolStripMenuItem();
            this.tanimlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspUnvanEkleSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tspDepartmanEkleSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tspOdemeTurEkleSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tspHesapIslemTurEkleSil = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaEkleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaİşlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspGelirGiderIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görüntüleToolStripMenuItem,
            this.ekleToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.tanimlarToolStripMenuItem,
            this.kasaİşlemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(23, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // görüntüleToolStripMenuItem
            // 
            this.görüntüleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPersonelGoruntule,
            this.tspSirketBireyGoruntule,
            this.tspUyeGoruntule});
            this.görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            this.görüntüleToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.görüntüleToolStripMenuItem.Text = "Görüntüle";
            // 
            // tspPersonelGoruntule
            // 
            this.tspPersonelGoruntule.BackColor = System.Drawing.SystemColors.Control;
            this.tspPersonelGoruntule.Name = "tspPersonelGoruntule";
            this.tspPersonelGoruntule.Size = new System.Drawing.Size(176, 22);
            this.tspPersonelGoruntule.Text = "Personel Bilgileri";
            this.tspPersonelGoruntule.Click += new System.EventHandler(this.personelBilgileriToolStripMenuItem_Click);
            // 
            // tspSirketBireyGoruntule
            // 
            this.tspSirketBireyGoruntule.BackColor = System.Drawing.SystemColors.Control;
            this.tspSirketBireyGoruntule.Name = "tspSirketBireyGoruntule";
            this.tspSirketBireyGoruntule.Size = new System.Drawing.Size(176, 22);
            this.tspSirketBireyGoruntule.Text = "Şirket/Birey Bilgileri";
            this.tspSirketBireyGoruntule.Click += new System.EventHandler(this.tspSirketBireyGoruntule_Click);
            // 
            // tspUyeGoruntule
            // 
            this.tspUyeGoruntule.BackColor = System.Drawing.SystemColors.Control;
            this.tspUyeGoruntule.Name = "tspUyeGoruntule";
            this.tspUyeGoruntule.Size = new System.Drawing.Size(176, 22);
            this.tspUyeGoruntule.Text = "Üye Bilgileri";
            this.tspUyeGoruntule.Click += new System.EventHandler(this.tspUyeGoruntule_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPersonelEkle,
            this.tspSirketBireyEkle,
            this.tspUyeTanimla,
            this.tspKullaniciTanimla,
            this.tspIseGirisCikis});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // tspPersonelEkle
            // 
            this.tspPersonelEkle.Name = "tspPersonelEkle";
            this.tspPersonelEkle.Size = new System.Drawing.Size(164, 22);
            this.tspPersonelEkle.Text = "Personel";
            this.tspPersonelEkle.Click += new System.EventHandler(this.tspPersonelEkle_Click);
            // 
            // tspSirketBireyEkle
            // 
            this.tspSirketBireyEkle.Name = "tspSirketBireyEkle";
            this.tspSirketBireyEkle.Size = new System.Drawing.Size(164, 22);
            this.tspSirketBireyEkle.Text = "Şirket/Birey";
            this.tspSirketBireyEkle.Click += new System.EventHandler(this.tspSirketBireyEkle_Click);
            // 
            // tspUyeTanimla
            // 
            this.tspUyeTanimla.Name = "tspUyeTanimla";
            this.tspUyeTanimla.Size = new System.Drawing.Size(164, 22);
            this.tspUyeTanimla.Text = "Üye Tanımla";
            this.tspUyeTanimla.Click += new System.EventHandler(this.tspUyeTanimla_Click);
            // 
            // tspKullaniciTanimla
            // 
            this.tspKullaniciTanimla.Name = "tspKullaniciTanimla";
            this.tspKullaniciTanimla.Size = new System.Drawing.Size(164, 22);
            this.tspKullaniciTanimla.Text = "Kullanıcı Tanımla";
            this.tspKullaniciTanimla.Click += new System.EventHandler(this.tspKullaniciTanimla_Click);
            // 
            // tspIseGirisCikis
            // 
            this.tspIseGirisCikis.Name = "tspIseGirisCikis";
            this.tspIseGirisCikis.Size = new System.Drawing.Size(164, 22);
            this.tspIseGirisCikis.Text = "İşe Giriş/Çıkış";
            this.tspIseGirisCikis.Click += new System.EventHandler(this.tspIseGirisCikis_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspGelirGiderRaporla});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // tspGelirGiderRaporla
            // 
            this.tspGelirGiderRaporla.Name = "tspGelirGiderRaporla";
            this.tspGelirGiderRaporla.Size = new System.Drawing.Size(174, 22);
            this.tspGelirGiderRaporla.Text = "Gelir-Gider Raporla";
            this.tspGelirGiderRaporla.Click += new System.EventHandler(this.tspGelirGiderRaporla_Click);
            // 
            // tanimlarToolStripMenuItem
            // 
            this.tanimlarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tanimlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspUnvanEkleSil,
            this.tspDepartmanEkleSil,
            this.tspOdemeTurEkleSil,
            this.tspHesapIslemTurEkleSil,
            this.bankaEkleSilToolStripMenuItem});
            this.tanimlarToolStripMenuItem.Name = "tanimlarToolStripMenuItem";
            this.tanimlarToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tanimlarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tanimlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // tspUnvanEkleSil
            // 
            this.tspUnvanEkleSil.Name = "tspUnvanEkleSil";
            this.tspUnvanEkleSil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tspUnvanEkleSil.Size = new System.Drawing.Size(166, 22);
            this.tspUnvanEkleSil.Text = "Ünvan";
            this.tspUnvanEkleSil.Click += new System.EventHandler(this.tspUnvanEkleSil_Click);
            // 
            // tspDepartmanEkleSil
            // 
            this.tspDepartmanEkleSil.Name = "tspDepartmanEkleSil";
            this.tspDepartmanEkleSil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tspDepartmanEkleSil.Size = new System.Drawing.Size(166, 22);
            this.tspDepartmanEkleSil.Text = "Departman";
            this.tspDepartmanEkleSil.Click += new System.EventHandler(this.tspDepartmanEkleSil_Click);
            // 
            // tspOdemeTurEkleSil
            // 
            this.tspOdemeTurEkleSil.Name = "tspOdemeTurEkleSil";
            this.tspOdemeTurEkleSil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tspOdemeTurEkleSil.Size = new System.Drawing.Size(166, 22);
            this.tspOdemeTurEkleSil.Text = "Ödeme Türü";
            this.tspOdemeTurEkleSil.Click += new System.EventHandler(this.tspOdemeTurEkleSil_Click);
            // 
            // tspHesapIslemTurEkleSil
            // 
            this.tspHesapIslemTurEkleSil.Name = "tspHesapIslemTurEkleSil";
            this.tspHesapIslemTurEkleSil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tspHesapIslemTurEkleSil.Size = new System.Drawing.Size(166, 22);
            this.tspHesapIslemTurEkleSil.Text = "Hesap İşlem Türü";
            this.tspHesapIslemTurEkleSil.Click += new System.EventHandler(this.tspHesapIslemTurEkleSil_Click);
            // 
            // bankaEkleSilToolStripMenuItem
            // 
            this.bankaEkleSilToolStripMenuItem.Name = "bankaEkleSilToolStripMenuItem";
            this.bankaEkleSilToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bankaEkleSilToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.bankaEkleSilToolStripMenuItem.Text = "Banka";
            this.bankaEkleSilToolStripMenuItem.Click += new System.EventHandler(this.bankaEkleSilToolStripMenuItem_Click);
            // 
            // kasaİşlemToolStripMenuItem
            // 
            this.kasaİşlemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspGelirGiderIslem});
            this.kasaİşlemToolStripMenuItem.Name = "kasaİşlemToolStripMenuItem";
            this.kasaİşlemToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.kasaİşlemToolStripMenuItem.Text = "Kasa İşlem";
            // 
            // tspGelirGiderIslem
            // 
            this.tspGelirGiderIslem.Name = "tspGelirGiderIslem";
            this.tspGelirGiderIslem.Size = new System.Drawing.Size(160, 22);
            this.tspGelirGiderIslem.Text = "Gelir/Gider Girişi";
            this.tspGelirGiderIslem.Click += new System.EventHandler(this.tspGelirGiderIslem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::IhsaniyeSKMuhasebe.WinUI.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::IhsaniyeSKMuhasebe.WinUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "İHSANİYESPOR";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem görüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspPersonelGoruntule;
        private System.Windows.Forms.ToolStripMenuItem tspSirketBireyGoruntule;
        private System.Windows.Forms.ToolStripMenuItem tspUyeGoruntule;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspPersonelEkle;
        private System.Windows.Forms.ToolStripMenuItem tspSirketBireyEkle;
        private System.Windows.Forms.ToolStripMenuItem tspUyeTanimla;
        private System.Windows.Forms.ToolStripMenuItem tspKullaniciTanimla;
        private System.Windows.Forms.ToolStripMenuItem tspIseGirisCikis;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspGelirGiderRaporla;
        private System.Windows.Forms.ToolStripMenuItem tanimlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspUnvanEkleSil;
        private System.Windows.Forms.ToolStripMenuItem tspDepartmanEkleSil;
        private System.Windows.Forms.ToolStripMenuItem tspOdemeTurEkleSil;
        private System.Windows.Forms.ToolStripMenuItem tspHesapIslemTurEkleSil;
        private System.Windows.Forms.ToolStripMenuItem kasaİşlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspGelirGiderIslem;
        private System.Windows.Forms.ToolStripMenuItem bankaEkleSilToolStripMenuItem;

    }
}

