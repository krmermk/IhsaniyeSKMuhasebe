namespace IhsaniyeSKMuhasebe.WinUI.EkleMenu
{
    partial class FormUyeTanimla
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
            this.tbUyeTanimla = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnKapat = new MetroFramework.Controls.MetroButton();
            this.btnUyeYap = new MetroFramework.Controls.MetroButton();
            this.cmbUyeOlmayanlar = new MetroFramework.Controls.MetroComboBox();
            this.lblSirketBirey = new MetroFramework.Controls.MetroLabel();
            this.tbUyeliktenCikar = new MetroFramework.Controls.MetroTabPage();
            this.btnSayfaKapat2 = new MetroFramework.Controls.MetroButton();
            this.btnUyeliktenCikar = new MetroFramework.Controls.MetroButton();
            this.cmbUyeOlanlar = new MetroFramework.Controls.MetroComboBox();
            this.lblUyeOlanlar = new MetroFramework.Controls.MetroLabel();
            this.tbUyeTanimla.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tbUyeliktenCikar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUyeTanimla
            // 
            this.tbUyeTanimla.Controls.Add(this.metroTabPage1);
            this.tbUyeTanimla.Controls.Add(this.tbUyeliktenCikar);
            this.tbUyeTanimla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUyeTanimla.Location = new System.Drawing.Point(20, 60);
            this.tbUyeTanimla.Name = "tbUyeTanimla";
            this.tbUyeTanimla.SelectedIndex = 1;
            this.tbUyeTanimla.Size = new System.Drawing.Size(329, 164);
            this.tbUyeTanimla.TabIndex = 0;
            this.tbUyeTanimla.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnKapat);
            this.metroTabPage1.Controls.Add(this.btnUyeYap);
            this.metroTabPage1.Controls.Add(this.cmbUyeOlmayanlar);
            this.metroTabPage1.Controls.Add(this.lblSirketBirey);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(321, 122);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Üye Tanımla";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.DarkRed;
            this.btnKapat.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(222, 56);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(92, 50);
            this.btnKapat.TabIndex = 12;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseSelectable = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUyeYap
            // 
            this.btnUyeYap.BackColor = System.Drawing.Color.DarkRed;
            this.btnUyeYap.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUyeYap.ForeColor = System.Drawing.Color.White;
            this.btnUyeYap.Location = new System.Drawing.Point(115, 56);
            this.btnUyeYap.Name = "btnUyeYap";
            this.btnUyeYap.Size = new System.Drawing.Size(101, 50);
            this.btnUyeYap.TabIndex = 13;
            this.btnUyeYap.Text = "Üye Yap";
            this.btnUyeYap.UseSelectable = true;
            this.btnUyeYap.Click += new System.EventHandler(this.btnUyeYap_Click);
            // 
            // cmbUyeOlmayanlar
            // 
            this.cmbUyeOlmayanlar.FormattingEnabled = true;
            this.cmbUyeOlmayanlar.ItemHeight = 23;
            this.cmbUyeOlmayanlar.Location = new System.Drawing.Point(115, 8);
            this.cmbUyeOlmayanlar.Name = "cmbUyeOlmayanlar";
            this.cmbUyeOlmayanlar.Size = new System.Drawing.Size(199, 29);
            this.cmbUyeOlmayanlar.TabIndex = 9;
            this.cmbUyeOlmayanlar.UseSelectable = true;
            // 
            // lblSirketBirey
            // 
            this.lblSirketBirey.AutoSize = true;
            this.lblSirketBirey.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSirketBirey.Location = new System.Drawing.Point(3, 8);
            this.lblSirketBirey.Name = "lblSirketBirey";
            this.lblSirketBirey.Size = new System.Drawing.Size(97, 19);
            this.lblSirketBirey.TabIndex = 8;
            this.lblSirketBirey.Text = "Şirket/Birey :";
            // 
            // tbUyeliktenCikar
            // 
            this.tbUyeliktenCikar.Controls.Add(this.btnSayfaKapat2);
            this.tbUyeliktenCikar.Controls.Add(this.btnUyeliktenCikar);
            this.tbUyeliktenCikar.Controls.Add(this.cmbUyeOlanlar);
            this.tbUyeliktenCikar.Controls.Add(this.lblUyeOlanlar);
            this.tbUyeliktenCikar.HorizontalScrollbarBarColor = true;
            this.tbUyeliktenCikar.HorizontalScrollbarHighlightOnWheel = false;
            this.tbUyeliktenCikar.HorizontalScrollbarSize = 10;
            this.tbUyeliktenCikar.Location = new System.Drawing.Point(4, 38);
            this.tbUyeliktenCikar.Name = "tbUyeliktenCikar";
            this.tbUyeliktenCikar.Size = new System.Drawing.Size(321, 122);
            this.tbUyeliktenCikar.TabIndex = 1;
            this.tbUyeliktenCikar.Text = "Üyelikten Çıkar";
            this.tbUyeliktenCikar.VerticalScrollbarBarColor = true;
            this.tbUyeliktenCikar.VerticalScrollbarHighlightOnWheel = false;
            this.tbUyeliktenCikar.VerticalScrollbarSize = 10;
            // 
            // btnSayfaKapat2
            // 
            this.btnSayfaKapat2.BackColor = System.Drawing.Color.DarkRed;
            this.btnSayfaKapat2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSayfaKapat2.ForeColor = System.Drawing.Color.White;
            this.btnSayfaKapat2.Location = new System.Drawing.Point(222, 58);
            this.btnSayfaKapat2.Name = "btnSayfaKapat2";
            this.btnSayfaKapat2.Size = new System.Drawing.Size(92, 50);
            this.btnSayfaKapat2.TabIndex = 16;
            this.btnSayfaKapat2.Text = "Kapat";
            this.btnSayfaKapat2.UseSelectable = true;
            this.btnSayfaKapat2.Click += new System.EventHandler(this.btnSayfaKapat2_Click);
            // 
            // btnUyeliktenCikar
            // 
            this.btnUyeliktenCikar.BackColor = System.Drawing.Color.DarkRed;
            this.btnUyeliktenCikar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUyeliktenCikar.ForeColor = System.Drawing.Color.White;
            this.btnUyeliktenCikar.Location = new System.Drawing.Point(115, 58);
            this.btnUyeliktenCikar.Name = "btnUyeliktenCikar";
            this.btnUyeliktenCikar.Size = new System.Drawing.Size(101, 50);
            this.btnUyeliktenCikar.TabIndex = 17;
            this.btnUyeliktenCikar.Text = "Üyelikten Çıkar";
            this.btnUyeliktenCikar.UseSelectable = true;
            this.btnUyeliktenCikar.Click += new System.EventHandler(this.btnUyeliktenCikar_Click);
            // 
            // cmbUyeOlanlar
            // 
            this.cmbUyeOlanlar.FormattingEnabled = true;
            this.cmbUyeOlanlar.ItemHeight = 23;
            this.cmbUyeOlanlar.Location = new System.Drawing.Point(115, 10);
            this.cmbUyeOlanlar.Name = "cmbUyeOlanlar";
            this.cmbUyeOlanlar.Size = new System.Drawing.Size(199, 29);
            this.cmbUyeOlanlar.TabIndex = 15;
            this.cmbUyeOlanlar.UseSelectable = true;
            // 
            // lblUyeOlanlar
            // 
            this.lblUyeOlanlar.AutoSize = true;
            this.lblUyeOlanlar.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUyeOlanlar.Location = new System.Drawing.Point(3, 10);
            this.lblUyeOlanlar.Name = "lblUyeOlanlar";
            this.lblUyeOlanlar.Size = new System.Drawing.Size(97, 19);
            this.lblUyeOlanlar.TabIndex = 14;
            this.lblUyeOlanlar.Text = "Şirket/Birey :";
            // 
            // FormUyeTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 244);
            this.Controls.Add(this.tbUyeTanimla);
            this.Name = "FormUyeTanimla";
            this.Text = "Üyelik İşlemleri";
            this.Load += new System.EventHandler(this.FormUyeTanimla_Load);
            this.tbUyeTanimla.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.tbUyeliktenCikar.ResumeLayout(false);
            this.tbUyeliktenCikar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbUyeTanimla;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage tbUyeliktenCikar;
        private MetroFramework.Controls.MetroButton btnKapat;
        private MetroFramework.Controls.MetroButton btnUyeYap;
        private MetroFramework.Controls.MetroLabel lblSirketBirey;
        private MetroFramework.Controls.MetroButton btnSayfaKapat2;
        private MetroFramework.Controls.MetroButton btnUyeliktenCikar;
        private MetroFramework.Controls.MetroLabel lblUyeOlanlar;
        public MetroFramework.Controls.MetroComboBox cmbUyeOlmayanlar;
        public MetroFramework.Controls.MetroComboBox cmbUyeOlanlar;
    }
}