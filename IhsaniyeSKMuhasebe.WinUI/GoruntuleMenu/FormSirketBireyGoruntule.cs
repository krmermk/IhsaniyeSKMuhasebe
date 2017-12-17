using IhsaniyeSKMuhasebe.BLL.Controller;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
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

namespace IhsaniyeSKMuhasebe.WinUI.GoruntuleMenu
{
    public partial class FormSirketBireyGoruntule : MetroForm
    {
        CariUyeDTO cdo;
        BankaTanimController _bankaTanimControl;
        CariUyeController _cariUC;
        CariUyeBilgileriController _bilgiC;
        CariUyeDtoController _cudc;
        int _olusturanPersonelID;
        public FormSirketBireyGoruntule(int olusturanPersonel)
        {
            InitializeComponent();
            _bankaTanimControl = new BankaTanimController();
            _cariUC = new CariUyeController();
            _bilgiC = new CariUyeBilgileriController();
            _cudc = new CariUyeDtoController();
            Helper.BindComboBox<BankaTanim>(_bankaTanimControl.AktifBankaGetir(), cmbBankaAdi, "BankaAdi", "ID");
            cmbBankaAdi.SelectedIndex = -1;
            _olusturanPersonelID = olusturanPersonel;

        }

        private void FormSirketBireyGoruntule_Load(object sender, EventArgs e)
        {
            btnSirketGuncelle.Enabled = false;
        }

        private void btnSirketListele_Click(object sender, EventArgs e)
        {
            YenidenDoldur();
        }
        public void YenidenDoldur()
        {
            grdSirketListele.DataSource = null;
            string isim = txtAdAra.Text.Trim();
            if (Helper.NullableControl(isim))
            {
                grdSirketListele.DataSource = _cariUC.GetCariDTO(isim);
            }
            else
            {
                grdSirketListele.DataSource = _cariUC.GetCariDTO();
            }
            Helper.Clears(pnlAltControls.Controls);
            btnSirketGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void grdSirketListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.Clears(pnlAltControls.Controls);
            cdo = new CariUyeDTO();
            cdo = (CariUyeDTO)grdSirketListele.Rows[e.RowIndex].DataBoundItem;

            #region Controlleri Doldur
            txtSirketAdi.Text = cdo.CariUyeAdi;
            txtEmail.Text = cdo.Email;
            txtTelefon.Text = cdo.Telefon;
            if (cdo.KurulusTarihi != null) { dtKurulusTarihi.Value = (DateTime)cdo.KurulusTarihi; }
            txtAciklama.Text = cdo.Aciklama;
            if (cdo.BankaID != null) cmbBankaAdi.SelectedValue = cdo.BankaID;
            txtHesapNo.Text = cdo.HesapNo;
            txtIBAN.Text = cdo.IBAN;
            txtAdres.Text = cdo.Adres;
            #endregion

            btnSirketGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnSirketGuncelle_Click(object sender, EventArgs e)
        {
            CariUyeDTO temp = new CariUyeDTO();
            temp.CariUyeID = cdo.CariUyeID;
            temp.CariUyeAdi = txtSirketAdi.Text.Trim();
            temp.Email = txtEmail.Text.Trim();
            temp.Telefon = txtTelefon.Text.Trim();
            if (dtKurulusTarihi.Value<DateTime.Now.AddDays(-1))
            {
                temp.KurulusTarihi = dtKurulusTarihi.Value; 
            }            
            temp.OlusturdanPersonelID = _olusturanPersonelID;
            temp.IBAN = txtIBAN.Text;
            temp.HesapNo = txtHesapNo.Text.Trim();
            temp.Aciklama = txtAciklama.Text.Trim();
            temp.Adres = txtAdres.Text.Trim();
            if ((BankaTanim)cmbBankaAdi.SelectedItem!=null)
            {
                temp.BankaAdi = ((BankaTanim)cmbBankaAdi.SelectedItem).BankaAdi;
                temp.BankaID = ((BankaTanim)cmbBankaAdi.SelectedItem).ID;
            }

            MessageBox.Show(_cudc.Guncelle(cdo, temp));
            YenidenDoldur();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _cariUC.DeleteCari(cdo.CariUyeID);
            YenidenDoldur();
        }
    }
}
