using IhsaniyeSKMuhasebe.BLL.Controller;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using IhsaniyeSKMuhasebe.Extension;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhsaniyeSKMuhasebe.WinUI.RaporlarMenu
{
    public partial class FormGelirGiderRapor : MetroForm
    {
        HesapIslemTurController _islemController;
        KasaIslemRaporDtoController _kirdc;
        public FormGelirGiderRapor()
        {
            InitializeComponent();
            _islemController = new HesapIslemTurController();
            _kirdc = new KasaIslemRaporDtoController();
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            KasaIslemRaporDtoController kasaRaporDtoC = new KasaIslemRaporDtoController();
            ICollection<KasaIslemRaporDTO> kasaRaporBind = kasaRaporDtoC.kasaRaporu(((HesapIslemTur)cmbHesapIslemTur.SelectedItem).ID, (int)cmbYillar.SelectedItem);
            this.kasaIslemRaporDTOBindingSource.DataSource = kasaRaporBind;
            this.reportViewer1.RefreshReport();
        }

        private void FormGelirGiderRapor_Load(object sender, EventArgs e)
        {
            Helper.BindComboBox(_islemController.GetEntities(), cmbHesapIslemTur, "HesapIslemTurAdi", "ID");
        }

        private void cmbHesapIslemTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbYillar.DataSource = _kirdc.IslemYapilanYillar(((HesapIslemTur)cmbHesapIslemTur.SelectedItem).ID);
            btnRaporla.Enabled = true;
        }
    }
}
