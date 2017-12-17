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

namespace IhsaniyeSKMuhasebe.WinUI.EkleMenu
{
    public partial class FormSirketBireyEkle : MetroForm
    {
        PersonelCariDTO _pcDto;
        CariUyeDTO _cuDto;
        CariUyeDtoController _cuDtoCon;
        CariUyeBilgileriController _cariUyeBilgileriControl;
        CariUyeController _cariUyeControl;
        CariUyeBankaController _cariUyeBankaControl;
        BankaTanimController _bankaTanimControl;
        int _mevcutPage = 0;
        bool _dogruGirildi = true;
        bool _isButton = false;
        public FormSirketBireyEkle(int olusturanPersonel)
        {
            InitializeComponent();
            _pcDto = new PersonelCariDTO();
            _cariUyeControl = new CariUyeController();
            _cariUyeBankaControl = new CariUyeBankaController();
            _cariUyeBilgileriControl = new CariUyeBilgileriController();
            _bankaTanimControl = new BankaTanimController();
            _cuDtoCon = new CariUyeDtoController();            
            _cuDto = new CariUyeDTO();
            Helper.BindComboBox<BankaTanim>(_bankaTanimControl.AktifBankaGetir(), cmbBankaGoruntule, "BankaAdi", "ID");
            Helper.BindComboBox<BankaTanim>(_bankaTanimControl.AktifBankaGetir(), mcmbBankaAdi, "BankaAdi", "ID");
            _cuDto.OlusturdanPersonelID = olusturanPersonel;
            cmbBankaGoruntule.SelectedIndex = -1;
            mcmbBankaAdi.SelectedIndex = - 1;

        }
        private void FormSirketBireyEkle_Load(object sender, EventArgs e)
        {
            tbCariUyeEkle.SelectTab(_mevcutPage);
        }

        private void mbtnIleri_Click(object sender, EventArgs e)
        {
            _isButton = true;
            tbCariUyeEkle.SelectTab(1);
            if (!_dogruGirildi)
            {
                tbCariUyeEkle.SelectTab(0);
                _isButton = false;
            }
        }

        private void mbtnBankaBilgileri_Click(object sender, EventArgs e)
        {
            tbCariUyeEkle.SelectTab(2);
        }

        private void mbtnIletisimIleri_Click(object sender, EventArgs e)
        {
            tbCariUyeEkle.SelectTab(3);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string[] mesajlar = _cuDtoCon.KayitEkle(_cuDto);
            foreach (string item in mesajlar)
            {
                MessageBox.Show(item);
            }
            this.Close();
        }

        private void tbCariUyeEkle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dogruGirildi = true;
            if (_mevcutPage == 0 && tbCariUyeEkle.SelectedIndex != 0)
            {
                _cuDto.CariUyeAdi = txtSirketAdi.Text;
                _cuDto.KurulusTarihi = dtKurulusTarihi.Value;
                _cuDto.Aciklama = txtAciklama.Text;
                if (!Helper.NullableControl(_cuDto.CariUyeAdi, _cuDto.KurulusTarihi.ToString()))
                {
                    _dogruGirildi = false;
                }
            }
            else if (_mevcutPage == 1)
            {
                if (mcmbBankaAdi.SelectedItem != null)
                {
                    _cuDto.BankaID = ((BankaTanim)mcmbBankaAdi.SelectedItem).ID;
                }

                else
                {
                    _cuDto.BankaID = null;
                }
                _cuDto.HesapNo = mtxtHesapNo.Text;
                _cuDto.IBAN = mtxtIBAN.Text;
            }
            else if (_mevcutPage == 2)
            {
                _cuDto.Email = mtxtEMail.Text;
                _cuDto.Telefon = mtxtTelefon.Text;
                _cuDto.Adres = mtxtAdres.Text;
            }
            if (tbCariUyeEkle.SelectedIndex == 3)
            {
                if (_cuDto.BankaID!=null)
                {                   
                    cmbBankaGoruntule.SelectedValue = _cuDto.BankaID;                   
                }
                txtSirketAdiGoruntule.Text = _cuDto.CariUyeAdi;
                txtKurulustarihiGoruntule.Text = _cuDto.KurulusTarihi.ToString();
                txtAciklamaGoruntule.Text = _cuDto.Aciklama;
                txtEmailGoruntule.Text = _cuDto.Email;
                txtTelefonGoruntule.Text = _cuDto.Telefon;
                txtHesapNoGoruntule.Text = _cuDto.HesapNo;
                txtIBANGoruntule.Text = _cuDto.IBAN;
                txtAdresGoruntule.Text = _cuDto.Adres;
            }
            if (_dogruGirildi)
            {
                _mevcutPage = tbCariUyeEkle.SelectedIndex;
            }
            else
            {
                MessageBox.Show("İlgili veriler eksik girilemez.");
                if (!_isButton)
                {
                    tbCariUyeEkle.SelectTab(_mevcutPage);
                }
                
            }

        }

        private void mtxtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtxtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FormYenile()
        {
            Helper.Clears(this.Controls);
            Helper.BindComboBox<BankaTanim>(_bankaTanimControl.AktifBankaGetir(), cmbBankaGoruntule, "BankaAdi", "ID");
            Helper.BindComboBox<BankaTanim>(_bankaTanimControl.AktifBankaGetir(), mcmbBankaAdi, "BankaAdi", "ID");
            cmbBankaGoruntule.SelectedIndex = -1;
            mcmbBankaAdi.SelectedIndex = -1;
        }
    }
}
