namespace IhsaniyeSKMuhasebe.WinUI.KasaIslemMenu
{
    partial class FormKasaIslem
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
            this.mtcGelirGider = new MetroFramework.Controls.MetroTabControl();
            this.mtpEkleGelirGider = new MetroFramework.Controls.MetroTabPage();
            this.mbtnEkle = new MetroFramework.Controls.MetroButton();
            this.dtpEkleIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtEkleReferansBelgeNo = new System.Windows.Forms.TextBox();
            this.txtEkleMiktar = new System.Windows.Forms.TextBox();
            this.rtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.cmbEkleOdemeTur = new System.Windows.Forms.ComboBox();
            this.cmbEkleCariUye = new System.Windows.Forms.ComboBox();
            this.cmbEkleHesapIslemTur = new System.Windows.Forms.ComboBox();
            this.lblEkleAciklama = new System.Windows.Forms.Label();
            this.lblEkleReferansBelgeNo = new System.Windows.Forms.Label();
            this.lblEkleMiktar = new System.Windows.Forms.Label();
            this.lblEkleCariUye = new System.Windows.Forms.Label();
            this.lblEkleIslemTarihi = new System.Windows.Forms.Label();
            this.lblEkleOdemeTur = new System.Windows.Forms.Label();
            this.lblEkleHesapIslem = new System.Windows.Forms.Label();
            this.mtpSil = new MetroFramework.Controls.MetroTabPage();
            this.mbtnSil = new MetroFramework.Controls.MetroButton();
            this.dgvSilKasaIslemwinform = new System.Windows.Forms.DataGridView();
            this.mtcGelirGider.SuspendLayout();
            this.mtpEkleGelirGider.SuspendLayout();
            this.mtpSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilKasaIslemwinform)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcGelirGider
            // 
            this.mtcGelirGider.Controls.Add(this.mtpEkleGelirGider);
            this.mtcGelirGider.Controls.Add(this.mtpSil);
            this.mtcGelirGider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcGelirGider.Location = new System.Drawing.Point(20, 60);
            this.mtcGelirGider.Name = "mtcGelirGider";
            this.mtcGelirGider.SelectedIndex = 0;
            this.mtcGelirGider.Size = new System.Drawing.Size(656, 305);
            this.mtcGelirGider.TabIndex = 1;
            this.mtcGelirGider.UseSelectable = true;
            // 
            // mtpEkleGelirGider
            // 
            this.mtpEkleGelirGider.Controls.Add(this.mbtnEkle);
            this.mtpEkleGelirGider.Controls.Add(this.dtpEkleIslemTarihi);
            this.mtpEkleGelirGider.Controls.Add(this.txtEkleReferansBelgeNo);
            this.mtpEkleGelirGider.Controls.Add(this.txtEkleMiktar);
            this.mtpEkleGelirGider.Controls.Add(this.rtxtAciklama);
            this.mtpEkleGelirGider.Controls.Add(this.cmbEkleOdemeTur);
            this.mtpEkleGelirGider.Controls.Add(this.cmbEkleCariUye);
            this.mtpEkleGelirGider.Controls.Add(this.cmbEkleHesapIslemTur);
            this.mtpEkleGelirGider.Controls.Add(this.lblEkleAciklama);
            this.mtpEkleGelirGider.Controls.Add(this.lblEkleReferansBelgeNo);
            this.mtpEkleGelirGider.Controls.Add(this.lblEkleMiktar);
            this.mtpEkleGelirGider.Controls.Add(this.lblEkleCariUye);
            this.mtpEkleGelirGider.Controls.Add(this.lblEkleIslemTarihi);
            this.mtpEkleGelirGider.Controls.Add(this.lblEkleOdemeTur);
            this.mtpEkleGelirGider.Controls.Add(this.lblEkleHesapIslem);
            this.mtpEkleGelirGider.HorizontalScrollbarBarColor = true;
            this.mtpEkleGelirGider.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpEkleGelirGider.HorizontalScrollbarSize = 10;
            this.mtpEkleGelirGider.Location = new System.Drawing.Point(4, 38);
            this.mtpEkleGelirGider.Name = "mtpEkleGelirGider";
            this.mtpEkleGelirGider.Size = new System.Drawing.Size(648, 263);
            this.mtpEkleGelirGider.TabIndex = 0;
            this.mtpEkleGelirGider.Text = "Ekle";
            this.mtpEkleGelirGider.VerticalScrollbarBarColor = true;
            this.mtpEkleGelirGider.VerticalScrollbarHighlightOnWheel = false;
            this.mtpEkleGelirGider.VerticalScrollbarSize = 10;
            // 
            // mbtnEkle
            // 
            this.mbtnEkle.Location = new System.Drawing.Point(379, 164);
            this.mbtnEkle.Name = "mbtnEkle";
            this.mbtnEkle.Size = new System.Drawing.Size(121, 23);
            this.mbtnEkle.TabIndex = 34;
            this.mbtnEkle.Text = "Ekle";
            this.mbtnEkle.UseSelectable = true;
            this.mbtnEkle.Click += new System.EventHandler(this.mbtnEkle_Click);
            // 
            // dtpEkleIslemTarihi
            // 
            this.dtpEkleIslemTarihi.Location = new System.Drawing.Point(379, 14);
            this.dtpEkleIslemTarihi.Name = "dtpEkleIslemTarihi";
            this.dtpEkleIslemTarihi.Size = new System.Drawing.Size(121, 20);
            this.dtpEkleIslemTarihi.TabIndex = 29;
            // 
            // txtEkleReferansBelgeNo
            // 
            this.txtEkleReferansBelgeNo.Location = new System.Drawing.Point(379, 42);
            this.txtEkleReferansBelgeNo.MaxLength = 20;
            this.txtEkleReferansBelgeNo.Name = "txtEkleReferansBelgeNo";
            this.txtEkleReferansBelgeNo.Size = new System.Drawing.Size(121, 20);
            this.txtEkleReferansBelgeNo.TabIndex = 27;
            // 
            // txtEkleMiktar
            // 
            this.txtEkleMiktar.Location = new System.Drawing.Point(98, 114);
            this.txtEkleMiktar.Name = "txtEkleMiktar";
            this.txtEkleMiktar.Size = new System.Drawing.Size(121, 20);
            this.txtEkleMiktar.TabIndex = 28;
            this.txtEkleMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEkleMiktar_KeyPress);
            // 
            // rtxtAciklama
            // 
            this.rtxtAciklama.Location = new System.Drawing.Point(379, 82);
            this.rtxtAciklama.MaxLength = 50;
            this.rtxtAciklama.Name = "rtxtAciklama";
            this.rtxtAciklama.Size = new System.Drawing.Size(121, 66);
            this.rtxtAciklama.TabIndex = 26;
            this.rtxtAciklama.Text = "";
            // 
            // cmbEkleOdemeTur
            // 
            this.cmbEkleOdemeTur.FormattingEnabled = true;
            this.cmbEkleOdemeTur.Location = new System.Drawing.Point(98, 85);
            this.cmbEkleOdemeTur.Name = "cmbEkleOdemeTur";
            this.cmbEkleOdemeTur.Size = new System.Drawing.Size(121, 21);
            this.cmbEkleOdemeTur.TabIndex = 23;
            // 
            // cmbEkleCariUye
            // 
            this.cmbEkleCariUye.FormattingEnabled = true;
            this.cmbEkleCariUye.Location = new System.Drawing.Point(98, 47);
            this.cmbEkleCariUye.Name = "cmbEkleCariUye";
            this.cmbEkleCariUye.Size = new System.Drawing.Size(121, 21);
            this.cmbEkleCariUye.TabIndex = 24;
            // 
            // cmbEkleHesapIslemTur
            // 
            this.cmbEkleHesapIslemTur.FormattingEnabled = true;
            this.cmbEkleHesapIslemTur.Location = new System.Drawing.Point(98, 14);
            this.cmbEkleHesapIslemTur.Name = "cmbEkleHesapIslemTur";
            this.cmbEkleHesapIslemTur.Size = new System.Drawing.Size(121, 21);
            this.cmbEkleHesapIslemTur.TabIndex = 25;
            // 
            // lblEkleAciklama
            // 
            this.lblEkleAciklama.AutoSize = true;
            this.lblEkleAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lblEkleAciklama.Location = new System.Drawing.Point(298, 82);
            this.lblEkleAciklama.Name = "lblEkleAciklama";
            this.lblEkleAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblEkleAciklama.TabIndex = 16;
            this.lblEkleAciklama.Text = "Açıklama";
            // 
            // lblEkleReferansBelgeNo
            // 
            this.lblEkleReferansBelgeNo.AutoSize = true;
            this.lblEkleReferansBelgeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblEkleReferansBelgeNo.Location = new System.Drawing.Point(298, 49);
            this.lblEkleReferansBelgeNo.Name = "lblEkleReferansBelgeNo";
            this.lblEkleReferansBelgeNo.Size = new System.Drawing.Size(51, 13);
            this.lblEkleReferansBelgeNo.TabIndex = 17;
            this.lblEkleReferansBelgeNo.Text = "Belge No";
            // 
            // lblEkleMiktar
            // 
            this.lblEkleMiktar.AutoSize = true;
            this.lblEkleMiktar.BackColor = System.Drawing.Color.Transparent;
            this.lblEkleMiktar.Location = new System.Drawing.Point(17, 121);
            this.lblEkleMiktar.Name = "lblEkleMiktar";
            this.lblEkleMiktar.Size = new System.Drawing.Size(36, 13);
            this.lblEkleMiktar.TabIndex = 18;
            this.lblEkleMiktar.Text = "Miktar";
            // 
            // lblEkleCariUye
            // 
            this.lblEkleCariUye.AutoSize = true;
            this.lblEkleCariUye.BackColor = System.Drawing.Color.Transparent;
            this.lblEkleCariUye.Location = new System.Drawing.Point(17, 55);
            this.lblEkleCariUye.Name = "lblEkleCariUye";
            this.lblEkleCariUye.Size = new System.Drawing.Size(55, 13);
            this.lblEkleCariUye.TabIndex = 19;
            this.lblEkleCariUye.Text = "Cari / Üye";
            // 
            // lblEkleIslemTarihi
            // 
            this.lblEkleIslemTarihi.AutoSize = true;
            this.lblEkleIslemTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblEkleIslemTarihi.Location = new System.Drawing.Point(298, 21);
            this.lblEkleIslemTarihi.Name = "lblEkleIslemTarihi";
            this.lblEkleIslemTarihi.Size = new System.Drawing.Size(60, 13);
            this.lblEkleIslemTarihi.TabIndex = 20;
            this.lblEkleIslemTarihi.Text = "İşlem Tarihi";
            // 
            // lblEkleOdemeTur
            // 
            this.lblEkleOdemeTur.AutoSize = true;
            this.lblEkleOdemeTur.BackColor = System.Drawing.Color.Transparent;
            this.lblEkleOdemeTur.Location = new System.Drawing.Point(17, 93);
            this.lblEkleOdemeTur.Name = "lblEkleOdemeTur";
            this.lblEkleOdemeTur.Size = new System.Drawing.Size(66, 13);
            this.lblEkleOdemeTur.TabIndex = 21;
            this.lblEkleOdemeTur.Text = "Ödeme Türü";
            // 
            // lblEkleHesapIslem
            // 
            this.lblEkleHesapIslem.AutoSize = true;
            this.lblEkleHesapIslem.BackColor = System.Drawing.Color.Transparent;
            this.lblEkleHesapIslem.Location = new System.Drawing.Point(17, 22);
            this.lblEkleHesapIslem.Name = "lblEkleHesapIslem";
            this.lblEkleHesapIslem.Size = new System.Drawing.Size(65, 13);
            this.lblEkleHesapIslem.TabIndex = 22;
            this.lblEkleHesapIslem.Text = "Hesap Işlem";
            // 
            // mtpSil
            // 
            this.mtpSil.Controls.Add(this.mbtnSil);
            this.mtpSil.Controls.Add(this.dgvSilKasaIslemwinform);
            this.mtpSil.HorizontalScrollbarBarColor = true;
            this.mtpSil.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpSil.HorizontalScrollbarSize = 10;
            this.mtpSil.Location = new System.Drawing.Point(4, 38);
            this.mtpSil.Name = "mtpSil";
            this.mtpSil.Size = new System.Drawing.Size(648, 263);
            this.mtpSil.TabIndex = 1;
            this.mtpSil.Text = "Sil";
            this.mtpSil.VerticalScrollbarBarColor = true;
            this.mtpSil.VerticalScrollbarHighlightOnWheel = false;
            this.mtpSil.VerticalScrollbarSize = 10;
            // 
            // mbtnSil
            // 
            this.mbtnSil.Location = new System.Drawing.Point(3, 232);
            this.mbtnSil.Name = "mbtnSil";
            this.mbtnSil.Size = new System.Drawing.Size(156, 23);
            this.mbtnSil.TabIndex = 35;
            this.mbtnSil.Text = "Sil";
            this.mbtnSil.UseSelectable = true;
            this.mbtnSil.Click += new System.EventHandler(this.mbtnSil_Click);
            // 
            // dgvSilKasaIslemwinform
            // 
            this.dgvSilKasaIslemwinform.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvSilKasaIslemwinform.BackgroundColor = System.Drawing.Color.White;
            this.dgvSilKasaIslemwinform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSilKasaIslemwinform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSilKasaIslemwinform.Location = new System.Drawing.Point(0, 9);
            this.dgvSilKasaIslemwinform.Name = "dgvSilKasaIslemwinform";
            this.dgvSilKasaIslemwinform.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSilKasaIslemwinform.Size = new System.Drawing.Size(636, 217);
            this.dgvSilKasaIslemwinform.TabIndex = 34;
            this.dgvSilKasaIslemwinform.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSilKasaIslem_CellClick);
            // 
            // FormKasaIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 385);
            this.Controls.Add(this.mtcGelirGider);
            this.Name = "FormKasaIslem";
            this.Text = "Gelir Gider";
            this.Load += new System.EventHandler(this.FormKasaIslem_Load);
            this.mtcGelirGider.ResumeLayout(false);
            this.mtpEkleGelirGider.ResumeLayout(false);
            this.mtpEkleGelirGider.PerformLayout();
            this.mtpSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilKasaIslemwinform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcGelirGider;
        private MetroFramework.Controls.MetroTabPage mtpEkleGelirGider;
        private System.Windows.Forms.Label lblEkleAciklama;
        private System.Windows.Forms.Label lblEkleReferansBelgeNo;
        private System.Windows.Forms.Label lblEkleMiktar;
        private System.Windows.Forms.Label lblEkleCariUye;
        private System.Windows.Forms.Label lblEkleIslemTarihi;
        private System.Windows.Forms.Label lblEkleOdemeTur;
        private System.Windows.Forms.Label lblEkleHesapIslem;
        private MetroFramework.Controls.MetroTabPage mtpSil;
        public MetroFramework.Controls.MetroButton mbtnEkle;
        public System.Windows.Forms.DateTimePicker dtpEkleIslemTarihi;
        public System.Windows.Forms.TextBox txtEkleReferansBelgeNo;
        public System.Windows.Forms.TextBox txtEkleMiktar;
        public System.Windows.Forms.RichTextBox rtxtAciklama;
        public System.Windows.Forms.ComboBox cmbEkleOdemeTur;
        public System.Windows.Forms.ComboBox cmbEkleCariUye;
        public System.Windows.Forms.ComboBox cmbEkleHesapIslemTur;
        public MetroFramework.Controls.MetroButton mbtnSil;
        public System.Windows.Forms.DataGridView dgvSilKasaIslemwinform;

    }
}