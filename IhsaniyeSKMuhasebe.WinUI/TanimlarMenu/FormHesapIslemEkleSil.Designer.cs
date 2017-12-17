namespace IhsaniyeSKMuhasebe.WinUI.TanimlarMenu
{
    partial class FormHesapIslemEkleSil
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
            this.mtcHesapIslemTur = new MetroFramework.Controls.MetroTabControl();
            this.mtpEkle = new MetroFramework.Controls.MetroTabPage();
            this.rdbGider = new MetroFramework.Controls.MetroRadioButton();
            this.rdbGelir = new MetroFramework.Controls.MetroRadioButton();
            this.txtAciklama1 = new MetroFramework.Controls.MetroTextBox();
            this.txtHesapIslemTurAdi = new MetroFramework.Controls.MetroTextBox();
            this.lblIslemYonu = new MetroFramework.Controls.MetroLabel();
            this.lblAciklama = new MetroFramework.Controls.MetroLabel();
            this.lblHesapIslemTurAdi = new MetroFramework.Controls.MetroLabel();
            this.btnIptal1 = new MetroFramework.Controls.MetroButton();
            this.mbtnEkle = new MetroFramework.Controls.MetroButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.rbGider = new MetroFramework.Controls.MetroRadioButton();
            this.rbGelir = new MetroFramework.Controls.MetroRadioButton();
            this.txtAciklamaGuncelle = new MetroFramework.Controls.MetroTextBox();
            this.txtTurAdi = new MetroFramework.Controls.MetroTextBox();
            this.lblIslemYon = new MetroFramework.Controls.MetroLabel();
            this.lblIslemAciklama = new MetroFramework.Controls.MetroLabel();
            this.lblTurAdi = new MetroFramework.Controls.MetroLabel();
            this.lblSeciniz = new MetroFramework.Controls.MetroLabel();
            this.btnGuncelle = new MetroFramework.Controls.MetroButton();
            this.cmbGuncelle = new MetroFramework.Controls.MetroComboBox();
            this.mtpSil = new MetroFramework.Controls.MetroTabPage();
            this.cmbHesapIslemTur = new MetroFramework.Controls.MetroComboBox();
            this.rdbSilGider = new MetroFramework.Controls.MetroRadioButton();
            this.rdbSilGelir = new MetroFramework.Controls.MetroRadioButton();
            this.txtSilAciklama = new MetroFramework.Controls.MetroTextBox();
            this.btnIptal2 = new MetroFramework.Controls.MetroButton();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.lblSilIslemYonu = new MetroFramework.Controls.MetroLabel();
            this.lblSilAciklama = new MetroFramework.Controls.MetroLabel();
            this.lblHesapIslemTurSil = new MetroFramework.Controls.MetroLabel();
            this.mtcHesapIslemTur.SuspendLayout();
            this.mtpEkle.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.mtpSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtcHesapIslemTur
            // 
            this.mtcHesapIslemTur.Controls.Add(this.mtpEkle);
            this.mtcHesapIslemTur.Controls.Add(this.metroTabPage1);
            this.mtcHesapIslemTur.Controls.Add(this.mtpSil);
            this.mtcHesapIslemTur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcHesapIslemTur.Location = new System.Drawing.Point(20, 60);
            this.mtcHesapIslemTur.Name = "mtcHesapIslemTur";
            this.mtcHesapIslemTur.SelectedIndex = 1;
            this.mtcHesapIslemTur.Size = new System.Drawing.Size(357, 290);
            this.mtcHesapIslemTur.TabIndex = 9;
            this.mtcHesapIslemTur.UseSelectable = true;
            // 
            // mtpEkle
            // 
            this.mtpEkle.Controls.Add(this.rdbGider);
            this.mtpEkle.Controls.Add(this.rdbGelir);
            this.mtpEkle.Controls.Add(this.txtAciklama1);
            this.mtpEkle.Controls.Add(this.txtHesapIslemTurAdi);
            this.mtpEkle.Controls.Add(this.lblIslemYonu);
            this.mtpEkle.Controls.Add(this.lblAciklama);
            this.mtpEkle.Controls.Add(this.lblHesapIslemTurAdi);
            this.mtpEkle.Controls.Add(this.btnIptal1);
            this.mtpEkle.Controls.Add(this.mbtnEkle);
            this.mtpEkle.HorizontalScrollbarBarColor = true;
            this.mtpEkle.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpEkle.HorizontalScrollbarSize = 10;
            this.mtpEkle.Location = new System.Drawing.Point(4, 38);
            this.mtpEkle.Name = "mtpEkle";
            this.mtpEkle.Size = new System.Drawing.Size(349, 248);
            this.mtpEkle.TabIndex = 0;
            this.mtpEkle.Text = "Ekle";
            this.mtpEkle.VerticalScrollbarBarColor = true;
            this.mtpEkle.VerticalScrollbarHighlightOnWheel = false;
            this.mtpEkle.VerticalScrollbarSize = 10;
            // 
            // rdbGider
            // 
            this.rdbGider.AutoSize = true;
            this.rdbGider.Location = new System.Drawing.Point(145, 133);
            this.rdbGider.Name = "rdbGider";
            this.rdbGider.Size = new System.Drawing.Size(73, 15);
            this.rdbGider.TabIndex = 36;
            this.rdbGider.Text = "Gider [ - ]";
            this.rdbGider.UseSelectable = true;
            this.rdbGider.CheckedChanged += new System.EventHandler(this.rdbGider_CheckedChanged);
            // 
            // rdbGelir
            // 
            this.rdbGelir.AutoSize = true;
            this.rdbGelir.Checked = true;
            this.rdbGelir.Location = new System.Drawing.Point(145, 112);
            this.rdbGelir.Name = "rdbGelir";
            this.rdbGelir.Size = new System.Drawing.Size(66, 15);
            this.rdbGelir.TabIndex = 36;
            this.rdbGelir.TabStop = true;
            this.rdbGelir.Text = "Gelir [+]";
            this.rdbGelir.UseSelectable = true;
            this.rdbGelir.CheckedChanged += new System.EventHandler(this.rdbGelir_CheckedChanged);
            // 
            // txtAciklama1
            // 
            // 
            // 
            // 
            this.txtAciklama1.CustomButton.Image = null;
            this.txtAciklama1.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtAciklama1.CustomButton.Name = "";
            this.txtAciklama1.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.txtAciklama1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAciklama1.CustomButton.TabIndex = 1;
            this.txtAciklama1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAciklama1.CustomButton.UseSelectable = true;
            this.txtAciklama1.CustomButton.Visible = false;
            this.txtAciklama1.Lines = new string[0];
            this.txtAciklama1.Location = new System.Drawing.Point(145, 43);
            this.txtAciklama1.MaxLength = 50;
            this.txtAciklama1.Multiline = true;
            this.txtAciklama1.Name = "txtAciklama1";
            this.txtAciklama1.PasswordChar = '\0';
            this.txtAciklama1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAciklama1.SelectedText = "";
            this.txtAciklama1.SelectionLength = 0;
            this.txtAciklama1.SelectionStart = 0;
            this.txtAciklama1.ShortcutsEnabled = true;
            this.txtAciklama1.Size = new System.Drawing.Size(144, 63);
            this.txtAciklama1.TabIndex = 35;
            this.txtAciklama1.UseSelectable = true;
            this.txtAciklama1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAciklama1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHesapIslemTurAdi
            // 
            // 
            // 
            // 
            this.txtHesapIslemTurAdi.CustomButton.Image = null;
            this.txtHesapIslemTurAdi.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtHesapIslemTurAdi.CustomButton.Name = "";
            this.txtHesapIslemTurAdi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHesapIslemTurAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHesapIslemTurAdi.CustomButton.TabIndex = 1;
            this.txtHesapIslemTurAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHesapIslemTurAdi.CustomButton.UseSelectable = true;
            this.txtHesapIslemTurAdi.CustomButton.Visible = false;
            this.txtHesapIslemTurAdi.Lines = new string[0];
            this.txtHesapIslemTurAdi.Location = new System.Drawing.Point(145, 7);
            this.txtHesapIslemTurAdi.MaxLength = 50;
            this.txtHesapIslemTurAdi.Name = "txtHesapIslemTurAdi";
            this.txtHesapIslemTurAdi.PasswordChar = '\0';
            this.txtHesapIslemTurAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHesapIslemTurAdi.SelectedText = "";
            this.txtHesapIslemTurAdi.SelectionLength = 0;
            this.txtHesapIslemTurAdi.SelectionStart = 0;
            this.txtHesapIslemTurAdi.ShortcutsEnabled = true;
            this.txtHesapIslemTurAdi.Size = new System.Drawing.Size(144, 23);
            this.txtHesapIslemTurAdi.TabIndex = 35;
            this.txtHesapIslemTurAdi.UseSelectable = true;
            this.txtHesapIslemTurAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHesapIslemTurAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblIslemYonu
            // 
            this.lblIslemYonu.AutoSize = true;
            this.lblIslemYonu.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIslemYonu.Location = new System.Drawing.Point(3, 108);
            this.lblIslemYonu.Name = "lblIslemYonu";
            this.lblIslemYonu.Size = new System.Drawing.Size(89, 19);
            this.lblIslemYonu.TabIndex = 34;
            this.lblIslemYonu.Text = "İşlem Yönü :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAciklama.Location = new System.Drawing.Point(3, 43);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(79, 19);
            this.lblAciklama.TabIndex = 34;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // lblHesapIslemTurAdi
            // 
            this.lblHesapIslemTurAdi.AutoSize = true;
            this.lblHesapIslemTurAdi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHesapIslemTurAdi.Location = new System.Drawing.Point(3, 7);
            this.lblHesapIslemTurAdi.Name = "lblHesapIslemTurAdi";
            this.lblHesapIslemTurAdi.Size = new System.Drawing.Size(104, 19);
            this.lblHesapIslemTurAdi.TabIndex = 34;
            this.lblHesapIslemTurAdi.Text = "İşlem Tür Adı :";
            // 
            // btnIptal1
            // 
            this.btnIptal1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnIptal1.Location = new System.Drawing.Point(145, 206);
            this.btnIptal1.Name = "btnIptal1";
            this.btnIptal1.Size = new System.Drawing.Size(144, 30);
            this.btnIptal1.TabIndex = 33;
            this.btnIptal1.Text = "İptal";
            this.btnIptal1.UseSelectable = true;
            this.btnIptal1.Click += new System.EventHandler(this.btnIptal1_Click);
            // 
            // mbtnEkle
            // 
            this.mbtnEkle.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtnEkle.Location = new System.Drawing.Point(145, 170);
            this.mbtnEkle.Name = "mbtnEkle";
            this.mbtnEkle.Size = new System.Drawing.Size(144, 30);
            this.mbtnEkle.TabIndex = 33;
            this.mbtnEkle.Text = "Ekle";
            this.mbtnEkle.UseSelectable = true;
            this.mbtnEkle.Click += new System.EventHandler(this.mbtnEkle_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.rbGider);
            this.metroTabPage1.Controls.Add(this.rbGelir);
            this.metroTabPage1.Controls.Add(this.txtAciklamaGuncelle);
            this.metroTabPage1.Controls.Add(this.txtTurAdi);
            this.metroTabPage1.Controls.Add(this.lblIslemYon);
            this.metroTabPage1.Controls.Add(this.lblIslemAciklama);
            this.metroTabPage1.Controls.Add(this.lblTurAdi);
            this.metroTabPage1.Controls.Add(this.lblSeciniz);
            this.metroTabPage1.Controls.Add(this.btnGuncelle);
            this.metroTabPage1.Controls.Add(this.cmbGuncelle);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(349, 248);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Güncelle";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // rbGider
            // 
            this.rbGider.AutoSize = true;
            this.rbGider.Location = new System.Drawing.Point(129, 174);
            this.rbGider.Name = "rbGider";
            this.rbGider.Size = new System.Drawing.Size(73, 15);
            this.rbGider.TabIndex = 42;
            this.rbGider.Text = "Gider [ - ]";
            this.rbGider.UseSelectable = true;
            // 
            // rbGelir
            // 
            this.rbGelir.AutoSize = true;
            this.rbGelir.Checked = true;
            this.rbGelir.Location = new System.Drawing.Point(129, 153);
            this.rbGelir.Name = "rbGelir";
            this.rbGelir.Size = new System.Drawing.Size(66, 15);
            this.rbGelir.TabIndex = 43;
            this.rbGelir.TabStop = true;
            this.rbGelir.Text = "Gelir [+]";
            this.rbGelir.UseSelectable = true;
            // 
            // txtAciklamaGuncelle
            // 
            // 
            // 
            // 
            this.txtAciklamaGuncelle.CustomButton.Image = null;
            this.txtAciklamaGuncelle.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtAciklamaGuncelle.CustomButton.Name = "";
            this.txtAciklamaGuncelle.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.txtAciklamaGuncelle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAciklamaGuncelle.CustomButton.TabIndex = 1;
            this.txtAciklamaGuncelle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAciklamaGuncelle.CustomButton.UseSelectable = true;
            this.txtAciklamaGuncelle.CustomButton.Visible = false;
            this.txtAciklamaGuncelle.Lines = new string[0];
            this.txtAciklamaGuncelle.Location = new System.Drawing.Point(129, 84);
            this.txtAciklamaGuncelle.MaxLength = 50;
            this.txtAciklamaGuncelle.Multiline = true;
            this.txtAciklamaGuncelle.Name = "txtAciklamaGuncelle";
            this.txtAciklamaGuncelle.PasswordChar = '\0';
            this.txtAciklamaGuncelle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAciklamaGuncelle.SelectedText = "";
            this.txtAciklamaGuncelle.SelectionLength = 0;
            this.txtAciklamaGuncelle.SelectionStart = 0;
            this.txtAciklamaGuncelle.ShortcutsEnabled = true;
            this.txtAciklamaGuncelle.Size = new System.Drawing.Size(199, 63);
            this.txtAciklamaGuncelle.TabIndex = 40;
            this.txtAciklamaGuncelle.UseSelectable = true;
            this.txtAciklamaGuncelle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAciklamaGuncelle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTurAdi
            // 
            // 
            // 
            // 
            this.txtTurAdi.CustomButton.Image = null;
            this.txtTurAdi.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txtTurAdi.CustomButton.Name = "";
            this.txtTurAdi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTurAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTurAdi.CustomButton.TabIndex = 1;
            this.txtTurAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTurAdi.CustomButton.UseSelectable = true;
            this.txtTurAdi.CustomButton.Visible = false;
            this.txtTurAdi.Lines = new string[0];
            this.txtTurAdi.Location = new System.Drawing.Point(129, 44);
            this.txtTurAdi.MaxLength = 50;
            this.txtTurAdi.Name = "txtTurAdi";
            this.txtTurAdi.PasswordChar = '\0';
            this.txtTurAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTurAdi.SelectedText = "";
            this.txtTurAdi.SelectionLength = 0;
            this.txtTurAdi.SelectionStart = 0;
            this.txtTurAdi.ShortcutsEnabled = true;
            this.txtTurAdi.Size = new System.Drawing.Size(199, 23);
            this.txtTurAdi.TabIndex = 41;
            this.txtTurAdi.UseSelectable = true;
            this.txtTurAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTurAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblIslemYon
            // 
            this.lblIslemYon.AutoSize = true;
            this.lblIslemYon.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIslemYon.Location = new System.Drawing.Point(3, 149);
            this.lblIslemYon.Name = "lblIslemYon";
            this.lblIslemYon.Size = new System.Drawing.Size(89, 19);
            this.lblIslemYon.TabIndex = 37;
            this.lblIslemYon.Text = "İşlem Yönü :";
            // 
            // lblIslemAciklama
            // 
            this.lblIslemAciklama.AutoSize = true;
            this.lblIslemAciklama.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIslemAciklama.Location = new System.Drawing.Point(3, 84);
            this.lblIslemAciklama.Name = "lblIslemAciklama";
            this.lblIslemAciklama.Size = new System.Drawing.Size(79, 19);
            this.lblIslemAciklama.TabIndex = 38;
            this.lblIslemAciklama.Text = "Açıklama :";
            // 
            // lblTurAdi
            // 
            this.lblTurAdi.AutoSize = true;
            this.lblTurAdi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTurAdi.Location = new System.Drawing.Point(3, 48);
            this.lblTurAdi.Name = "lblTurAdi";
            this.lblTurAdi.Size = new System.Drawing.Size(104, 19);
            this.lblTurAdi.TabIndex = 39;
            this.lblTurAdi.Text = "İşlem Tür Adı :";
            // 
            // lblSeciniz
            // 
            this.lblSeciniz.AutoSize = true;
            this.lblSeciniz.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSeciniz.Location = new System.Drawing.Point(3, 15);
            this.lblSeciniz.Name = "lblSeciniz";
            this.lblSeciniz.Size = new System.Drawing.Size(63, 19);
            this.lblSeciniz.TabIndex = 36;
            this.lblSeciniz.Text = "Seçiniz :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkRed;
            this.btnGuncelle.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(236, 210);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(92, 31);
            this.btnGuncelle.TabIndex = 34;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseSelectable = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbGuncelle
            // 
            this.cmbGuncelle.FormattingEnabled = true;
            this.cmbGuncelle.ItemHeight = 23;
            this.cmbGuncelle.Location = new System.Drawing.Point(129, 5);
            this.cmbGuncelle.Name = "cmbGuncelle";
            this.cmbGuncelle.Size = new System.Drawing.Size(199, 29);
            this.cmbGuncelle.TabIndex = 33;
            this.cmbGuncelle.UseSelectable = true;
            this.cmbGuncelle.SelectedIndexChanged += new System.EventHandler(this.cmbGuncelle_SelectedIndexChanged);
            // 
            // mtpSil
            // 
            this.mtpSil.Controls.Add(this.cmbHesapIslemTur);
            this.mtpSil.Controls.Add(this.rdbSilGider);
            this.mtpSil.Controls.Add(this.rdbSilGelir);
            this.mtpSil.Controls.Add(this.txtSilAciklama);
            this.mtpSil.Controls.Add(this.btnIptal2);
            this.mtpSil.Controls.Add(this.btnSil);
            this.mtpSil.Controls.Add(this.lblSilIslemYonu);
            this.mtpSil.Controls.Add(this.lblSilAciklama);
            this.mtpSil.Controls.Add(this.lblHesapIslemTurSil);
            this.mtpSil.HorizontalScrollbarBarColor = true;
            this.mtpSil.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpSil.HorizontalScrollbarSize = 10;
            this.mtpSil.Location = new System.Drawing.Point(4, 38);
            this.mtpSil.Name = "mtpSil";
            this.mtpSil.Size = new System.Drawing.Size(349, 248);
            this.mtpSil.TabIndex = 1;
            this.mtpSil.Text = "Sil";
            this.mtpSil.VerticalScrollbarBarColor = true;
            this.mtpSil.VerticalScrollbarHighlightOnWheel = false;
            this.mtpSil.VerticalScrollbarSize = 10;
            // 
            // cmbHesapIslemTur
            // 
            this.cmbHesapIslemTur.FormattingEnabled = true;
            this.cmbHesapIslemTur.ItemHeight = 23;
            this.cmbHesapIslemTur.Location = new System.Drawing.Point(126, 4);
            this.cmbHesapIslemTur.Name = "cmbHesapIslemTur";
            this.cmbHesapIslemTur.Size = new System.Drawing.Size(163, 29);
            this.cmbHesapIslemTur.TabIndex = 44;
            this.cmbHesapIslemTur.UseSelectable = true;
            this.cmbHesapIslemTur.SelectedIndexChanged += new System.EventHandler(this.cmbHesapIslemTur_SelectedIndexChanged);
            // 
            // rdbSilGider
            // 
            this.rdbSilGider.AutoSize = true;
            this.rdbSilGider.Enabled = false;
            this.rdbSilGider.Location = new System.Drawing.Point(126, 129);
            this.rdbSilGider.Name = "rdbSilGider";
            this.rdbSilGider.Size = new System.Drawing.Size(73, 15);
            this.rdbSilGider.TabIndex = 42;
            this.rdbSilGider.Text = "Gider [ - ]";
            this.rdbSilGider.UseSelectable = true;
            // 
            // rdbSilGelir
            // 
            this.rdbSilGelir.AutoSize = true;
            this.rdbSilGelir.Enabled = false;
            this.rdbSilGelir.Location = new System.Drawing.Point(126, 108);
            this.rdbSilGelir.Name = "rdbSilGelir";
            this.rdbSilGelir.Size = new System.Drawing.Size(66, 15);
            this.rdbSilGelir.TabIndex = 43;
            this.rdbSilGelir.Text = "Gelir [+]";
            this.rdbSilGelir.UseSelectable = true;
            // 
            // txtSilAciklama
            // 
            // 
            // 
            // 
            this.txtSilAciklama.CustomButton.Image = null;
            this.txtSilAciklama.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.txtSilAciklama.CustomButton.Name = "";
            this.txtSilAciklama.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.txtSilAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSilAciklama.CustomButton.TabIndex = 1;
            this.txtSilAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSilAciklama.CustomButton.UseSelectable = true;
            this.txtSilAciklama.CustomButton.Visible = false;
            this.txtSilAciklama.Enabled = false;
            this.txtSilAciklama.Lines = new string[0];
            this.txtSilAciklama.Location = new System.Drawing.Point(126, 39);
            this.txtSilAciklama.MaxLength = 32767;
            this.txtSilAciklama.Multiline = true;
            this.txtSilAciklama.Name = "txtSilAciklama";
            this.txtSilAciklama.PasswordChar = '\0';
            this.txtSilAciklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSilAciklama.SelectedText = "";
            this.txtSilAciklama.SelectionLength = 0;
            this.txtSilAciklama.SelectionStart = 0;
            this.txtSilAciklama.ShortcutsEnabled = true;
            this.txtSilAciklama.Size = new System.Drawing.Size(163, 63);
            this.txtSilAciklama.TabIndex = 40;
            this.txtSilAciklama.UseSelectable = true;
            this.txtSilAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSilAciklama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnIptal2
            // 
            this.btnIptal2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnIptal2.Location = new System.Drawing.Point(135, 202);
            this.btnIptal2.Name = "btnIptal2";
            this.btnIptal2.Size = new System.Drawing.Size(144, 30);
            this.btnIptal2.TabIndex = 38;
            this.btnIptal2.Text = "İptal";
            this.btnIptal2.UseSelectable = true;
            this.btnIptal2.Click += new System.EventHandler(this.btnIptal2_Click);
            // 
            // btnSil
            // 
            this.btnSil.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSil.Location = new System.Drawing.Point(135, 166);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 30);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "Sil";
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblSilIslemYonu
            // 
            this.lblSilIslemYonu.AutoSize = true;
            this.lblSilIslemYonu.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSilIslemYonu.Location = new System.Drawing.Point(3, 108);
            this.lblSilIslemYonu.Name = "lblSilIslemYonu";
            this.lblSilIslemYonu.Size = new System.Drawing.Size(89, 19);
            this.lblSilIslemYonu.TabIndex = 35;
            this.lblSilIslemYonu.Text = "İşlem Yönü :";
            // 
            // lblSilAciklama
            // 
            this.lblSilAciklama.AutoSize = true;
            this.lblSilAciklama.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSilAciklama.Location = new System.Drawing.Point(3, 43);
            this.lblSilAciklama.Name = "lblSilAciklama";
            this.lblSilAciklama.Size = new System.Drawing.Size(79, 19);
            this.lblSilAciklama.TabIndex = 36;
            this.lblSilAciklama.Text = "Açıklama :";
            // 
            // lblHesapIslemTurSil
            // 
            this.lblHesapIslemTurSil.AutoSize = true;
            this.lblHesapIslemTurSil.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHesapIslemTurSil.Location = new System.Drawing.Point(3, 7);
            this.lblHesapIslemTurSil.Name = "lblHesapIslemTurSil";
            this.lblHesapIslemTurSil.Size = new System.Drawing.Size(104, 19);
            this.lblHesapIslemTurSil.TabIndex = 37;
            this.lblHesapIslemTurSil.Text = "İşlem Tür Adı :";
            // 
            // FormHesapIslemEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 370);
            this.Controls.Add(this.mtcHesapIslemTur);
            this.Name = "FormHesapIslemEkleSil";
            this.Text = "Hesap İşlem Tür";
            this.Load += new System.EventHandler(this.FormHesapIslemEkleSil_Load);
            this.mtcHesapIslemTur.ResumeLayout(false);
            this.mtpEkle.ResumeLayout(false);
            this.mtpEkle.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.mtpSil.ResumeLayout(false);
            this.mtpSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcHesapIslemTur;
        private MetroFramework.Controls.MetroTabPage mtpEkle;
        public MetroFramework.Controls.MetroButton mbtnEkle;
        private MetroFramework.Controls.MetroTabPage mtpSil;
        private MetroFramework.Controls.MetroRadioButton rdbGider;
        private MetroFramework.Controls.MetroRadioButton rdbGelir;
        private MetroFramework.Controls.MetroTextBox txtAciklama1;
        private MetroFramework.Controls.MetroTextBox txtHesapIslemTurAdi;
        private MetroFramework.Controls.MetroLabel lblIslemYonu;
        private MetroFramework.Controls.MetroLabel lblAciklama;
        private MetroFramework.Controls.MetroLabel lblHesapIslemTurAdi;
        public MetroFramework.Controls.MetroButton btnIptal1;
        private MetroFramework.Controls.MetroRadioButton rdbSilGider;
        private MetroFramework.Controls.MetroRadioButton rdbSilGelir;
        private MetroFramework.Controls.MetroTextBox txtSilAciklama;
        public MetroFramework.Controls.MetroButton btnIptal2;
        public MetroFramework.Controls.MetroButton btnSil;
        private MetroFramework.Controls.MetroLabel lblSilIslemYonu;
        private MetroFramework.Controls.MetroLabel lblSilAciklama;
        private MetroFramework.Controls.MetroLabel lblHesapIslemTurSil;
        public MetroFramework.Controls.MetroComboBox cmbHesapIslemTur;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroRadioButton rbGider;
        private MetroFramework.Controls.MetroRadioButton rbGelir;
        private MetroFramework.Controls.MetroTextBox txtAciklamaGuncelle;
        private MetroFramework.Controls.MetroTextBox txtTurAdi;
        private MetroFramework.Controls.MetroLabel lblIslemYon;
        private MetroFramework.Controls.MetroLabel lblIslemAciklama;
        private MetroFramework.Controls.MetroLabel lblTurAdi;
        private MetroFramework.Controls.MetroLabel lblSeciniz;
        private MetroFramework.Controls.MetroButton btnGuncelle;
        public MetroFramework.Controls.MetroComboBox cmbGuncelle;
    }
}