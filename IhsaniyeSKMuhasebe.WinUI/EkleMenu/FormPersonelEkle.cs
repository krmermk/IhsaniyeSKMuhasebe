using IhsaniyeSKMuhasebe.BLL.Controller;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
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

namespace IhsaniyeSKMuhasebe.WinUI
{
    public partial class FormPersonelEkle : MetroForm
    {
        PersonelCariDTO _pcDto;
        UnvanController _uc;
        DepartmanController _dc;
        PersonelController _pc;
        BankaTanimController _btc;
        PersonelCariDtoController _pcDtoCon;
        int _mevcutPage = 0;
        bool _dogruGirildi = true;
        bool _isButton = false;
        public FormPersonelEkle(int olusturanPersenel)
        {
            InitializeComponent();
            _pcDtoCon = new PersonelCariDtoController();
            _pcDto = new PersonelCariDTO();
            _uc = new UnvanController();
            _dc = new DepartmanController();
            _pc = new PersonelController();
            _btc = new BankaTanimController();
            _pcDto.OlusturanPersonelID = olusturanPersenel;
            Helper.BindComboBox<Unvan>(_uc.GetUnvan(), cmbUnvan, "GorevAdi", "Id");
            Helper.BindComboBox<Departman>(_dc.AktifDepartmanlariGetir(), cmbDepartman, "DepartmanAdi", "Id");
            Helper.BindComboBox<Personel>(_pc.AktifPersonelleriGetir(), cmbYonetici, "FullName", "Id");
            Helper.BindComboBox<BankaTanim>(_btc.AktifBankaGetir(), cmbBankaAdi, "BankaAdi", "ID");
            cmbUnvan.SelectedIndex = -1;
            cmbDepartman.SelectedIndex = -1;
            cmbYonetici.SelectedIndex = -1;
            cmbBankaAdi.SelectedIndex = -1;
        }


        private void mtlIlerleGenelBilgiler_Click(object sender, EventArgs e)
        {
            _isButton = true;
            tbPersonelEkle.SelectTab(1);
            if (!_dogruGirildi)
            {
                tbPersonelEkle.SelectedIndex = 0;
                _isButton = false;
            }
               
   

        }

        private void mtlIlerleIsTanim_Click(object sender, EventArgs e)
        {

            tbPersonelEkle.SelectTab(2);
        }

        private void mtlIlerleBankaBilgileri_Click(object sender, EventArgs e)
        {

            tbPersonelEkle.SelectTab(3);
        }

        private void mtlIlerleIletisim_Click(object sender, EventArgs e)
        {

            tbPersonelEkle.SelectTab(4);
        }

        private void mtlKaydet_Click(object sender, EventArgs e)
        {
            string mesaj = _pcDtoCon.KayitEkle(_pcDto);
            MessageBox.Show(mesaj);
            FormYenile();              
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void FormPersonelEkle_Load(object sender, EventArgs e)
        {
            tbPersonelEkle.SelectTab(_mevcutPage);
        }

        private void tbPersonelEkle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dogruGirildi = true;

            if (_mevcutPage == 0 && tbPersonelEkle.SelectedIndex != 0)
            {
                _pcDto.PersonelAdi = txtAdi.Text;
                _pcDto.PersonelSoyadi = txtSoyadi.Text;
                _pcDto.TCNo = txtTcNo.Text;
                _pcDto.DogumTarihi = mdtDogumTarihi.Value;
                if (!Helper.NullableControl(_pcDto.PersonelAdi, _pcDto.PersonelSoyadi, _pcDto.DogumTarihi.ToString()))
                {
                    _dogruGirildi = false;
                }
            }
            else if (_mevcutPage == 1)
            {

                _pcDto.Unvani = (Unvan)cmbUnvan.SelectedItem;
                _pcDto.Departmani = (Departman)cmbDepartman.SelectedItem;
                _pcDto.Yoneticisi = (Personel)cmbYonetici.SelectedItem;
                _pcDto.MaasMiktar = txtMaas.Text;

            }
            else if (_mevcutPage == 2)
            {

                _pcDto.Bankasi = (BankaTanim)cmbBankaAdi.SelectedItem;
                _pcDto.HesapNo = txtHesapNo.Text;
                _pcDto.IBAN = txtIban.Text;

            }
            else if (_mevcutPage == 3)
            {
                _pcDto.Email = txtEMail.Text;
                _pcDto.Telefon = txtTelefon.Text;
                _pcDto.Adres = txtAdres.Text;


            }
            if (tbPersonelEkle.SelectedIndex == 4)
            {
                txtAdGoruntule.Text = _pcDto.PersonelAdi;
                txtSoyadGoruntule.Text = _pcDto.PersonelSoyadi;
                txtTcGoruntule.Text = _pcDto.TCNo;
                txtDogumTarihiGoruntule.Text = _pcDto.DogumTarihi.ToString();
                
                if (_pcDto.Unvani!=null)
                {
                    txtUnvanGoruntule.Text = _pcDto.Unvani.GorevAdi;
                }
                else
                {
                    txtUnvanGoruntule.Text = "";
                }


                if (_pcDto.Departmani != null)
                {
                    txtDepartmanGoruntule.Text = _pcDto.Departmani.DepartmanAdi;
                }
                else
                {
                    txtDepartmanGoruntule.Text = "";
                }

                if (_pcDto.Yoneticisi != null)
                {
                    txtYoneticiGoruntule.Text = _pcDto.Yoneticisi.PersonelAdi;
                }
                else
                {
                    txtYoneticiGoruntule.Text = "";
                }
                txtMaasGoruntule.Text = _pcDto.MaasMiktar;


                txtHesapNoGoruntule.Text = txtHesapNo.Text;
                txtIbanGoruntule.Text = txtIban.Text;
                if (_pcDto.Bankasi != null)
                {
                    txtBankaAdiGoruntule.Text = _pcDto.Bankasi.BankaAdi;
                }
                else
                {
                    txtBankaAdiGoruntule.Text = "";
                }



                txtEmailGoruntule.Text = txtEMail.Text;
                txtTelefonGoruntule.Text = txtTelefon.Text;
                txtAdresGoruntule.Text = txtAdres.Text;

            }

            if (_dogruGirildi)
            {
                _mevcutPage = tbPersonelEkle.SelectedIndex;
            }
            else
            {
                MessageBox.Show("İlgili veriler eksik girilemez.");
                if (!_isButton)
                {
                    tbPersonelEkle.SelectTab(_mevcutPage);
                }

            }
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            char Virgul=(char)8;
            if(!txtMaas.Text.Contains(","))
            {
                Virgul = (char)44;
            }

            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar!=Virgul;
        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;           
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void FormYenile()
        {
            Helper.Clears(this.Controls);
            Helper.BindComboBox<Unvan>(_uc.GetUnvan(), cmbUnvan, "GorevAdi", "Id");
            Helper.BindComboBox<Departman>(_dc.AktifDepartmanlariGetir(), cmbDepartman, "DepartmanAdi", "Id");
            Helper.BindComboBox<Personel>(_pc.AktifPersonelleriGetir(), cmbYonetici, "FullName", "Id");
            Helper.BindComboBox<BankaTanim>(_btc.AktifBankaGetir(), cmbBankaAdi, "BankaAdi", "ID");
            cmbUnvan.SelectedIndex = -1;
            cmbDepartman.SelectedIndex = -1;
            cmbYonetici.SelectedIndex = -1;
            cmbBankaAdi.SelectedIndex = -1;
        }
    }
}
