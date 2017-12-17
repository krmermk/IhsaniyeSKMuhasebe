namespace IhsaniyeSKMuhasebe.WinUI.RaporlarMenu
{
    partial class FormGelirGiderRapor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.kasaIslemRaporDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbHesapIslemTur = new MetroFramework.Controls.MetroComboBox();
            this.lblHesapIslemTur = new MetroFramework.Controls.MetroLabel();
            this.cmbYillar = new MetroFramework.Controls.MetroComboBox();
            this.lblYil = new MetroFramework.Controls.MetroLabel();
            this.btnRaporla = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.kasaIslemRaporDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kasaIslemRaporDTOBindingSource
            // 
            this.kasaIslemRaporDTOBindingSource.DataSource = typeof(IhsaniyeSKMuhasebe.DTO.DTO.KasaIslemRaporDTO);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource4.Name = "DataSetAidatRapor";
            reportDataSource4.Value = this.kasaIslemRaporDTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "IhsaniyeSKMuhasebe.WinUI.RaporlarMenu.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(891, 317);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbHesapIslemTur
            // 
            this.cmbHesapIslemTur.FormattingEnabled = true;
            this.cmbHesapIslemTur.ItemHeight = 23;
            this.cmbHesapIslemTur.Location = new System.Drawing.Point(153, 402);
            this.cmbHesapIslemTur.Name = "cmbHesapIslemTur";
            this.cmbHesapIslemTur.Size = new System.Drawing.Size(169, 29);
            this.cmbHesapIslemTur.TabIndex = 1;
            this.cmbHesapIslemTur.UseSelectable = true;
            this.cmbHesapIslemTur.SelectedIndexChanged += new System.EventHandler(this.cmbHesapIslemTur_SelectedIndexChanged);
            // 
            // lblHesapIslemTur
            // 
            this.lblHesapIslemTur.AutoSize = true;
            this.lblHesapIslemTur.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHesapIslemTur.Location = new System.Drawing.Point(23, 402);
            this.lblHesapIslemTur.Name = "lblHesapIslemTur";
            this.lblHesapIslemTur.Size = new System.Drawing.Size(124, 19);
            this.lblHesapIslemTur.TabIndex = 2;
            this.lblHesapIslemTur.Text = "Raporlama Türü :";
            // 
            // cmbYillar
            // 
            this.cmbYillar.FormattingEnabled = true;
            this.cmbYillar.ItemHeight = 23;
            this.cmbYillar.Location = new System.Drawing.Point(492, 402);
            this.cmbYillar.Name = "cmbYillar";
            this.cmbYillar.Size = new System.Drawing.Size(169, 29);
            this.cmbYillar.TabIndex = 1;
            this.cmbYillar.UseSelectable = true;
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblYil.Location = new System.Drawing.Point(362, 402);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(116, 19);
            this.lblYil.TabIndex = 2;
            this.lblYil.Text = "Raporlama Yılı :";
            // 
            // btnRaporla
            // 
            this.btnRaporla.Enabled = false;
            this.btnRaporla.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRaporla.Location = new System.Drawing.Point(722, 402);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(132, 29);
            this.btnRaporla.TabIndex = 3;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.UseSelectable = true;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // FormGelirGiderRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 454);
            this.Controls.Add(this.btnRaporla);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblHesapIslemTur);
            this.Controls.Add(this.cmbYillar);
            this.Controls.Add(this.cmbHesapIslemTur);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormGelirGiderRapor";
            this.Text = "Gelir-Gider Raporu";
            this.Load += new System.EventHandler(this.FormGelirGiderRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kasaIslemRaporDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource kasaIslemRaporDTOBindingSource;
        private MetroFramework.Controls.MetroComboBox cmbHesapIslemTur;
        private MetroFramework.Controls.MetroLabel lblHesapIslemTur;
        private MetroFramework.Controls.MetroComboBox cmbYillar;
        private MetroFramework.Controls.MetroLabel lblYil;
        private MetroFramework.Controls.MetroButton btnRaporla;

    }
}