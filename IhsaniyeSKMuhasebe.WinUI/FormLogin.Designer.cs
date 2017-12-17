namespace IhsaniyeSKMuhasebe.WinUI
{
    partial class FormLogin
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
            this.txtKullaniciAdi = new MetroFramework.Controls.MetroTextBox();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.ExitTile = new MetroFramework.Controls.MetroTile();
            this.MinimizeTile = new MetroFramework.Controls.MetroTile();
            this.pctLoginName = new System.Windows.Forms.PictureBox();
            this.pctPassword = new System.Windows.Forms.PictureBox();
            this.pctWait = new System.Windows.Forms.PictureBox();
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctLoginName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWait)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            // 
            // 
            // 
            this.txtKullaniciAdi.CustomButton.Image = null;
            this.txtKullaniciAdi.CustomButton.Location = new System.Drawing.Point(148, 2);
            this.txtKullaniciAdi.CustomButton.Name = "";
            this.txtKullaniciAdi.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtKullaniciAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKullaniciAdi.CustomButton.TabIndex = 1;
            this.txtKullaniciAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKullaniciAdi.CustomButton.UseSelectable = true;
            this.txtKullaniciAdi.CustomButton.Visible = false;
            this.txtKullaniciAdi.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtKullaniciAdi.Lines = new string[0];
            this.txtKullaniciAdi.Location = new System.Drawing.Point(271, 180);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.PromptText = "Kullanıcı Adı";
            this.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.ShortcutsEnabled = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(182, 36);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.UseSelectable = true;
            this.txtKullaniciAdi.WaterMark = "Kullanıcı Adı";
            this.txtKullaniciAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKullaniciAdi.WaterMarkFont = new System.Drawing.Font("Segoe Marker", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(1)), true);
            // 
            // txtSifre
            // 
            // 
            // 
            // 
            this.txtSifre.CustomButton.Image = null;
            this.txtSifre.CustomButton.Location = new System.Drawing.Point(148, 2);
            this.txtSifre.CustomButton.Name = "";
            this.txtSifre.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSifre.CustomButton.TabIndex = 1;
            this.txtSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSifre.CustomButton.UseSelectable = true;
            this.txtSifre.CustomButton.Visible = false;
            this.txtSifre.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSifre.Lines = new string[0];
            this.txtSifre.Location = new System.Drawing.Point(271, 233);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.PromptText = "Şifre";
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(182, 36);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSelectable = true;
            this.txtSifre.WaterMark = "Şifre";
            this.txtSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSifre.WaterMarkFont = new System.Drawing.Font("Segoe Marker", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(1)), true);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // ExitTile
            // 
            this.ExitTile.ActiveControl = null;
            this.ExitTile.BackColor = System.Drawing.Color.Transparent;
            this.ExitTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitTile.Location = new System.Drawing.Point(624, 3);
            this.ExitTile.Name = "ExitTile";
            this.ExitTile.Size = new System.Drawing.Size(24, 23);
            this.ExitTile.TabIndex = 1;
            this.ExitTile.TileImage = global::IhsaniyeSKMuhasebe.WinUI.Properties.Resources.closed;
            this.ExitTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.ExitTile.UseCustomBackColor = true;
            this.ExitTile.UseSelectable = true;
            this.ExitTile.UseTileImage = true;
            this.ExitTile.Click += new System.EventHandler(this.ExitTile_Click);
            // 
            // MinimizeTile
            // 
            this.MinimizeTile.ActiveControl = null;
            this.MinimizeTile.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeTile.Location = new System.Drawing.Point(594, 3);
            this.MinimizeTile.Name = "MinimizeTile";
            this.MinimizeTile.Size = new System.Drawing.Size(24, 23);
            this.MinimizeTile.TabIndex = 1;
            this.MinimizeTile.TileImage = global::IhsaniyeSKMuhasebe.WinUI.Properties.Resources.minimized;
            this.MinimizeTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.MinimizeTile.UseCustomBackColor = true;
            this.MinimizeTile.UseSelectable = true;
            this.MinimizeTile.UseTileImage = true;
            this.MinimizeTile.Click += new System.EventHandler(this.MinimizeTile_Click);
            // 
            // pctLoginName
            // 
            this.pctLoginName.BackColor = System.Drawing.Color.White;
            this.pctLoginName.BackgroundImage = global::IhsaniyeSKMuhasebe.WinUI.Properties.Resources.business_man;
            this.pctLoginName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLoginName.Location = new System.Drawing.Point(238, 180);
            this.pctLoginName.Name = "pctLoginName";
            this.pctLoginName.Size = new System.Drawing.Size(34, 36);
            this.pctLoginName.TabIndex = 2;
            this.pctLoginName.TabStop = false;
            // 
            // pctPassword
            // 
            this.pctPassword.BackColor = System.Drawing.Color.White;
            this.pctPassword.BackgroundImage = global::IhsaniyeSKMuhasebe.WinUI.Properties.Resources.lock_padlock_symbol_for_protect;
            this.pctPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctPassword.Location = new System.Drawing.Point(238, 233);
            this.pctPassword.Name = "pctPassword";
            this.pctPassword.Size = new System.Drawing.Size(34, 36);
            this.pctPassword.TabIndex = 2;
            this.pctPassword.TabStop = false;
            // 
            // pctWait
            // 
            this.pctWait.BackColor = System.Drawing.Color.Transparent;
            this.pctWait.BackgroundImage = global::IhsaniyeSKMuhasebe.WinUI.Properties.Resources.logo2;
            this.pctWait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctWait.Location = new System.Drawing.Point(301, 68);
            this.pctWait.Name = "pctWait";
            this.pctWait.Size = new System.Drawing.Size(78, 78);
            this.pctWait.TabIndex = 3;
            this.pctWait.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(238, 295);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(215, 53);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseCustomBackColor = true;
            this.btnGiris.UseCustomForeColor = true;
            this.btnGiris.UseSelectable = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IhsaniyeSKMuhasebe.WinUI.Properties.Resources.loginbackfoto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 459);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.pctWait);
            this.Controls.Add(this.pctPassword);
            this.Controls.Add(this.pctLoginName);
            this.Controls.Add(this.MinimizeTile);
            this.Controls.Add(this.ExitTile);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctLoginName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtKullaniciAdi;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private MetroFramework.Controls.MetroTile ExitTile;
        private MetroFramework.Controls.MetroTile MinimizeTile;
        private System.Windows.Forms.PictureBox pctLoginName;
        private System.Windows.Forms.PictureBox pctPassword;
        private System.Windows.Forms.PictureBox pctWait;
        private MetroFramework.Controls.MetroButton btnGiris;
    }
}