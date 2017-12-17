namespace IhsaniyeSKMuhasebe.WinUI.GoruntuleMenu
{
    partial class FormSirketBireyGoruntule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSirketGuncelle = new MetroFramework.Controls.MetroButton();
            this.txtAdAra = new MetroFramework.Controls.MetroTextBox();
            this.btnSirketListele = new MetroFramework.Controls.MetroButton();
            this.mlblAdAra = new MetroFramework.Controls.MetroLabel();
            this.grdSirketListele = new MetroFramework.Controls.MetroGrid();
            this.txtAciklama = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefon = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblAdres = new MetroFramework.Controls.MetroLabel();
            this.lblTelefon = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtIBAN = new MetroFramework.Controls.MetroTextBox();
            this.txtHesapNo = new MetroFramework.Controls.MetroTextBox();
            this.lblIBAN = new MetroFramework.Controls.MetroLabel();
            this.cmbBankaAdi = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtAdres = new MetroFramework.Controls.MetroTextBox();
            this.lblAcıklama = new MetroFramework.Controls.MetroLabel();
            this.dtKurulusTarihi = new MetroFramework.Controls.MetroDateTime();
            this.txtSirketAdi = new MetroFramework.Controls.MetroTextBox();
            this.lblKurulusTarihi = new MetroFramework.Controls.MetroLabel();
            this.lblSirketAdi = new MetroFramework.Controls.MetroLabel();
            this.btnIptal = new MetroFramework.Controls.MetroButton();
            this.pnlAltControls = new System.Windows.Forms.Panel();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdSirketListele)).BeginInit();
            this.pnlAltControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSirketGuncelle
            // 
            this.btnSirketGuncelle.Location = new System.Drawing.Point(596, 249);
            this.btnSirketGuncelle.Name = "btnSirketGuncelle";
            this.btnSirketGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnSirketGuncelle.TabIndex = 71;
            this.btnSirketGuncelle.Text = "Güncelle";
            this.btnSirketGuncelle.UseSelectable = true;
            this.btnSirketGuncelle.Click += new System.EventHandler(this.btnSirketGuncelle_Click);
            // 
            // txtAdAra
            // 
            // 
            // 
            // 
            this.txtAdAra.CustomButton.Image = null;
            this.txtAdAra.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtAdAra.CustomButton.Name = "";
            this.txtAdAra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdAra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdAra.CustomButton.TabIndex = 1;
            this.txtAdAra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdAra.CustomButton.UseSelectable = true;
            this.txtAdAra.CustomButton.Visible = false;
            this.txtAdAra.Lines = new string[0];
            this.txtAdAra.Location = new System.Drawing.Point(139, 62);
            this.txtAdAra.MaxLength = 32767;
            this.txtAdAra.Name = "txtAdAra";
            this.txtAdAra.PasswordChar = '\0';
            this.txtAdAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdAra.SelectedText = "";
            this.txtAdAra.SelectionLength = 0;
            this.txtAdAra.SelectionStart = 0;
            this.txtAdAra.ShortcutsEnabled = true;
            this.txtAdAra.Size = new System.Drawing.Size(145, 23);
            this.txtAdAra.TabIndex = 58;
            this.txtAdAra.UseSelectable = true;
            this.txtAdAra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdAra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSirketListele
            // 
            this.btnSirketListele.Location = new System.Drawing.Point(298, 61);
            this.btnSirketListele.Name = "btnSirketListele";
            this.btnSirketListele.Size = new System.Drawing.Size(75, 23);
            this.btnSirketListele.TabIndex = 57;
            this.btnSirketListele.Text = "Ara";
            this.btnSirketListele.UseSelectable = true;
            this.btnSirketListele.Click += new System.EventHandler(this.btnSirketListele_Click);
            // 
            // mlblAdAra
            // 
            this.mlblAdAra.AutoSize = true;
            this.mlblAdAra.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblAdAra.Location = new System.Drawing.Point(16, 63);
            this.mlblAdAra.Name = "mlblAdAra";
            this.mlblAdAra.Size = new System.Drawing.Size(117, 19);
            this.mlblAdAra.TabIndex = 56;
            this.mlblAdAra.Text = "Adına Göre Ara:";
            // 
            // grdSirketListele
            // 
            this.grdSirketListele.AllowUserToResizeRows = false;
            this.grdSirketListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdSirketListele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSirketListele.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdSirketListele.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSirketListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSirketListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSirketListele.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdSirketListele.EnableHeadersVisualStyles = false;
            this.grdSirketListele.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdSirketListele.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdSirketListele.Location = new System.Drawing.Point(20, 100);
            this.grdSirketListele.MultiSelect = false;
            this.grdSirketListele.Name = "grdSirketListele";
            this.grdSirketListele.ReadOnly = true;
            this.grdSirketListele.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSirketListele.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSirketListele.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdSirketListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSirketListele.Size = new System.Drawing.Size(766, 235);
            this.grdSirketListele.TabIndex = 55;
            this.grdSirketListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSirketListele_CellClick);
            // 
            // txtAciklama
            // 
            // 
            // 
            // 
            this.txtAciklama.CustomButton.Image = null;
            this.txtAciklama.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txtAciklama.CustomButton.Name = "";
            this.txtAciklama.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAciklama.CustomButton.TabIndex = 1;
            this.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAciklama.CustomButton.UseSelectable = true;
            this.txtAciklama.CustomButton.Visible = false;
            this.txtAciklama.Lines = new string[0];
            this.txtAciklama.Location = new System.Drawing.Point(110, 149);
            this.txtAciklama.MaxLength = 32767;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.ShortcutsEnabled = true;
            this.txtAciklama.Size = new System.Drawing.Size(240, 108);
            this.txtAciklama.TabIndex = 87;
            this.txtAciklama.UseSelectable = true;
            this.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAciklama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelefon
            // 
            // 
            // 
            // 
            this.txtTelefon.CustomButton.Image = null;
            this.txtTelefon.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtTelefon.CustomButton.Name = "";
            this.txtTelefon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefon.CustomButton.TabIndex = 1;
            this.txtTelefon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefon.CustomButton.UseSelectable = true;
            this.txtTelefon.CustomButton.Visible = false;
            this.txtTelefon.Lines = new string[0];
            this.txtTelefon.Location = new System.Drawing.Point(110, 79);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PasswordChar = '\0';
            this.txtTelefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefon.SelectedText = "";
            this.txtTelefon.SelectionLength = 0;
            this.txtTelefon.SelectionStart = 0;
            this.txtTelefon.ShortcutsEnabled = true;
            this.txtTelefon.Size = new System.Drawing.Size(157, 23);
            this.txtTelefon.TabIndex = 88;
            this.txtTelefon.UseSelectable = true;
            this.txtTelefon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(110, 48);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(157, 23);
            this.txtEmail.TabIndex = 89;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAdres.Location = new System.Drawing.Point(364, 135);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(56, 19);
            this.lblAdres.TabIndex = 84;
            this.lblAdres.Text = "Adres :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTelefon.Location = new System.Drawing.Point(3, 82);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(66, 19);
            this.lblTelefon.TabIndex = 85;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEmail.Location = new System.Drawing.Point(3, 48);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 19);
            this.lblEmail.TabIndex = 86;
            this.lblEmail.Text = "E-Mail :";
            // 
            // txtIBAN
            // 
            // 
            // 
            // 
            this.txtIBAN.CustomButton.Image = null;
            this.txtIBAN.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtIBAN.CustomButton.Name = "";
            this.txtIBAN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIBAN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIBAN.CustomButton.TabIndex = 1;
            this.txtIBAN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIBAN.CustomButton.UseSelectable = true;
            this.txtIBAN.CustomButton.Visible = false;
            this.txtIBAN.Lines = new string[0];
            this.txtIBAN.Location = new System.Drawing.Point(455, 84);
            this.txtIBAN.MaxLength = 26;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.PasswordChar = '\0';
            this.txtIBAN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIBAN.SelectedText = "";
            this.txtIBAN.SelectionLength = 0;
            this.txtIBAN.SelectionStart = 0;
            this.txtIBAN.ShortcutsEnabled = true;
            this.txtIBAN.Size = new System.Drawing.Size(157, 23);
            this.txtIBAN.TabIndex = 82;
            this.txtIBAN.UseSelectable = true;
            this.txtIBAN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIBAN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHesapNo
            // 
            // 
            // 
            // 
            this.txtHesapNo.CustomButton.Image = null;
            this.txtHesapNo.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtHesapNo.CustomButton.Name = "";
            this.txtHesapNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHesapNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHesapNo.CustomButton.TabIndex = 1;
            this.txtHesapNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHesapNo.CustomButton.UseSelectable = true;
            this.txtHesapNo.CustomButton.Visible = false;
            this.txtHesapNo.Lines = new string[0];
            this.txtHesapNo.Location = new System.Drawing.Point(455, 52);
            this.txtHesapNo.MaxLength = 19;
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.PasswordChar = '\0';
            this.txtHesapNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHesapNo.SelectedText = "";
            this.txtHesapNo.SelectionLength = 0;
            this.txtHesapNo.SelectionStart = 0;
            this.txtHesapNo.ShortcutsEnabled = true;
            this.txtHesapNo.Size = new System.Drawing.Size(157, 23);
            this.txtHesapNo.TabIndex = 83;
            this.txtHesapNo.UseSelectable = true;
            this.txtHesapNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHesapNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHesapNo_KeyPress);
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblIBAN.Location = new System.Drawing.Point(364, 90);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(51, 19);
            this.lblIBAN.TabIndex = 78;
            this.lblIBAN.Text = "IBAN :";
            // 
            // cmbBankaAdi
            // 
            this.cmbBankaAdi.FormattingEnabled = true;
            this.cmbBankaAdi.ItemHeight = 23;
            this.cmbBankaAdi.Location = new System.Drawing.Point(455, 13);
            this.cmbBankaAdi.Name = "cmbBankaAdi";
            this.cmbBankaAdi.Size = new System.Drawing.Size(157, 29);
            this.cmbBankaAdi.TabIndex = 81;
            this.cmbBankaAdi.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(364, 54);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 79;
            this.metroLabel5.Text = "Hesap No :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(364, 17);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 19);
            this.metroLabel6.TabIndex = 80;
            this.metroLabel6.Text = "Banka Adi :";
            // 
            // txtAdres
            // 
            // 
            // 
            // 
            this.txtAdres.CustomButton.Image = null;
            this.txtAdres.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.txtAdres.CustomButton.Name = "";
            this.txtAdres.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.txtAdres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdres.CustomButton.TabIndex = 1;
            this.txtAdres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdres.CustomButton.UseSelectable = true;
            this.txtAdres.CustomButton.Visible = false;
            this.txtAdres.Lines = new string[0];
            this.txtAdres.Location = new System.Drawing.Point(456, 135);
            this.txtAdres.MaxLength = 32767;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.PasswordChar = '\0';
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdres.SelectedText = "";
            this.txtAdres.SelectionLength = 0;
            this.txtAdres.SelectionStart = 0;
            this.txtAdres.ShortcutsEnabled = true;
            this.txtAdres.Size = new System.Drawing.Size(303, 108);
            this.txtAdres.TabIndex = 77;
            this.txtAdres.UseSelectable = true;
            this.txtAdres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAcıklama
            // 
            this.lblAcıklama.AutoSize = true;
            this.lblAcıklama.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAcıklama.Location = new System.Drawing.Point(3, 140);
            this.lblAcıklama.Name = "lblAcıklama";
            this.lblAcıklama.Size = new System.Drawing.Size(79, 19);
            this.lblAcıklama.TabIndex = 76;
            this.lblAcıklama.Text = "Açıklama :";
            // 
            // dtKurulusTarihi
            // 
            this.dtKurulusTarihi.Location = new System.Drawing.Point(110, 108);
            this.dtKurulusTarihi.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtKurulusTarihi.Name = "dtKurulusTarihi";
            this.dtKurulusTarihi.Size = new System.Drawing.Size(157, 29);
            this.dtKurulusTarihi.TabIndex = 75;
            // 
            // txtSirketAdi
            // 
            // 
            // 
            // 
            this.txtSirketAdi.CustomButton.Image = null;
            this.txtSirketAdi.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtSirketAdi.CustomButton.Name = "";
            this.txtSirketAdi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSirketAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSirketAdi.CustomButton.TabIndex = 1;
            this.txtSirketAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSirketAdi.CustomButton.UseSelectable = true;
            this.txtSirketAdi.CustomButton.Visible = false;
            this.txtSirketAdi.Lines = new string[0];
            this.txtSirketAdi.Location = new System.Drawing.Point(110, 17);
            this.txtSirketAdi.MaxLength = 32767;
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.PasswordChar = '\0';
            this.txtSirketAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSirketAdi.SelectedText = "";
            this.txtSirketAdi.SelectionLength = 0;
            this.txtSirketAdi.SelectionStart = 0;
            this.txtSirketAdi.ShortcutsEnabled = true;
            this.txtSirketAdi.Size = new System.Drawing.Size(157, 23);
            this.txtSirketAdi.TabIndex = 74;
            this.txtSirketAdi.UseSelectable = true;
            this.txtSirketAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSirketAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblKurulusTarihi
            // 
            this.lblKurulusTarihi.AutoSize = true;
            this.lblKurulusTarihi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKurulusTarihi.Location = new System.Drawing.Point(3, 112);
            this.lblKurulusTarihi.Name = "lblKurulusTarihi";
            this.lblKurulusTarihi.Size = new System.Drawing.Size(107, 19);
            this.lblKurulusTarihi.TabIndex = 72;
            this.lblKurulusTarihi.Text = "Kuruluş Tarihi :";
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.AutoSize = true;
            this.lblSirketAdi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSirketAdi.Location = new System.Drawing.Point(3, 17);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(83, 19);
            this.lblSirketAdi.TabIndex = 73;
            this.lblSirketAdi.Text = "Şirket Adı :";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(683, 249);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 90;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseSelectable = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // pnlAltControls
            // 
            this.pnlAltControls.Controls.Add(this.txtSirketAdi);
            this.pnlAltControls.Controls.Add(this.btnIptal);
            this.pnlAltControls.Controls.Add(this.btnSil);
            this.pnlAltControls.Controls.Add(this.btnSirketGuncelle);
            this.pnlAltControls.Controls.Add(this.txtAciklama);
            this.pnlAltControls.Controls.Add(this.lblSirketAdi);
            this.pnlAltControls.Controls.Add(this.txtTelefon);
            this.pnlAltControls.Controls.Add(this.lblKurulusTarihi);
            this.pnlAltControls.Controls.Add(this.txtEmail);
            this.pnlAltControls.Controls.Add(this.dtKurulusTarihi);
            this.pnlAltControls.Controls.Add(this.lblAdres);
            this.pnlAltControls.Controls.Add(this.lblAcıklama);
            this.pnlAltControls.Controls.Add(this.lblTelefon);
            this.pnlAltControls.Controls.Add(this.txtAdres);
            this.pnlAltControls.Controls.Add(this.lblEmail);
            this.pnlAltControls.Controls.Add(this.metroLabel6);
            this.pnlAltControls.Controls.Add(this.txtIBAN);
            this.pnlAltControls.Controls.Add(this.metroLabel5);
            this.pnlAltControls.Controls.Add(this.txtHesapNo);
            this.pnlAltControls.Controls.Add(this.cmbBankaAdi);
            this.pnlAltControls.Controls.Add(this.lblIBAN);
            this.pnlAltControls.Location = new System.Drawing.Point(20, 341);
            this.pnlAltControls.Name = "pnlAltControls";
            this.pnlAltControls.Size = new System.Drawing.Size(769, 281);
            this.pnlAltControls.TabIndex = 91;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(515, 249);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 71;
            this.btnSil.Text = "Sil";
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FormSirketBireyGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 634);
            this.Controls.Add(this.pnlAltControls);
            this.Controls.Add(this.txtAdAra);
            this.Controls.Add(this.btnSirketListele);
            this.Controls.Add(this.mlblAdAra);
            this.Controls.Add(this.grdSirketListele);
            this.Name = "FormSirketBireyGoruntule";
            this.Text = "Şirket/Birey Görüntüle";
            this.Load += new System.EventHandler(this.FormSirketBireyGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSirketListele)).EndInit();
            this.pnlAltControls.ResumeLayout(false);
            this.pnlAltControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblAdAra;
        private MetroFramework.Controls.MetroLabel lblAdres;
        private MetroFramework.Controls.MetroLabel lblTelefon;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblIBAN;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblAcıklama;
        private MetroFramework.Controls.MetroLabel lblKurulusTarihi;
        private MetroFramework.Controls.MetroLabel lblSirketAdi;
        public MetroFramework.Controls.MetroButton btnSirketGuncelle;
        public MetroFramework.Controls.MetroTextBox txtAdAra;
        public MetroFramework.Controls.MetroButton btnSirketListele;
        public MetroFramework.Controls.MetroGrid grdSirketListele;
        public MetroFramework.Controls.MetroTextBox txtAciklama;
        public MetroFramework.Controls.MetroTextBox txtTelefon;
        public MetroFramework.Controls.MetroTextBox txtEmail;
        public MetroFramework.Controls.MetroTextBox txtIBAN;
        public MetroFramework.Controls.MetroTextBox txtHesapNo;
        public MetroFramework.Controls.MetroComboBox cmbBankaAdi;
        public MetroFramework.Controls.MetroTextBox txtAdres;
        public MetroFramework.Controls.MetroDateTime dtKurulusTarihi;
        public MetroFramework.Controls.MetroTextBox txtSirketAdi;
        public MetroFramework.Controls.MetroButton btnIptal;
        private System.Windows.Forms.Panel pnlAltControls;
        public MetroFramework.Controls.MetroButton btnSil;
    }
}