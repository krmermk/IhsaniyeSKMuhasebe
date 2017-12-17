using IhsaniyeSKMuhasebe.BLL.Controller;
using IhsaniyeSKMuhasebe.DTO.DTO;
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

namespace IhsaniyeSKMuhasebe.WinUI.EkleMenu
{
    public partial class FormIseGirisCikis : MetroForm
    {
        PersonelController _personelC;
        PersonelIseGirisCikisController _personelIseGirisCikisC;
        PersonelUnvanDepartmanDtoController _personelUnvanDepartmanC;
        Personel _personel;
        PersonelUnvanDepartmanDTO _perUnvanDepartman = new PersonelUnvanDepartmanDTO();
        int _olusturanPersonelId;

        public FormIseGirisCikis(int olusturanPersonelId)
        {
            InitializeComponent();
            _personelC = new PersonelController();
            _personelIseGirisCikisC = new PersonelIseGirisCikisController();
            _personelUnvanDepartmanC = new PersonelUnvanDepartmanDtoController();
            _olusturanPersonelId = olusturanPersonelId;
            FormuYenile();
        }

        private void cmbPasifPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            _personel = (Personel)cmbPasifPersoneller.SelectedItem;
            if (_personel != null)
            {
                _perUnvanDepartman = (PersonelUnvanDepartmanDTO)_personelUnvanDepartmanC.PersonelUnvanDepartmanGetir(_personel.Id);
                txtAdPasif.Text = _personel.FullName;
                txtTcKimlikNoPasif.Text = _personel.TcNo;

                if (_perUnvanDepartman != null)
                {
                    txtUnvanPasif.Text = _perUnvanDepartman.UnvanAdi;
                    txtDepartmanPasif.Text = _perUnvanDepartman.DepartmanAdi;
                }

            }
        }

        private void cmbAktifPersonller_SelectedIndexChanged(object sender, EventArgs e)
        {
            _personel = (Personel)cmbAktifPersonller.SelectedItem;

            if (_personel != null)
            {
                _perUnvanDepartman = (PersonelUnvanDepartmanDTO)_personelUnvanDepartmanC.PersonelUnvanDepartmanGetir(_personel.Id);
                txtAdAktif.Text = _personel.FullName;
                txtTcKimlikNoAktif.Text = _personel.TcNo;

                if (_perUnvanDepartman != null)
                {
                    txtUnvanAktif.Text = _perUnvanDepartman.UnvanAdi;
                    txtDepartmanAktif.Text = _perUnvanDepartman.DepartmanAdi;
                }

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormuYenile()
        {
            Helper.BindComboBox<Personel>(_personelC.PasifPersonelleriGetir(), cmbPasifPersoneller, "FullName", "ID");
            Helper.BindComboBox<Personel>(_personelC.AktifPersonelleriGetir(), cmbAktifPersonller, "FullName", "ID");
            cmbAktifPersonller.SelectedIndex = -1;
            cmbPasifPersoneller.SelectedIndex = -1;
            txtAdAktif.Text = "";
            txtAdPasif.Text = "";
            txtTcKimlikNoAktif.Text = "";
            txtTcKimlikNoPasif.Text = "";
            txtDepartmanAktif.Text = "";
            txtDepartmanPasif.Text = "";
            txtUnvanAktif.Text = "";
            txtUnvanPasif.Text = "";
        }

        private void btnKaydetCikis_Click(object sender, EventArgs e)
        {
            Personel personel = (Personel)cmbAktifPersonller.SelectedItem;
            if (personel != null)
            {
                PersonelIseGirisCikis personelIseGirisCikis = _personelIseGirisCikisC.IseGirisCikisGetir(personel.Id);
                personelIseGirisCikis.IstenCikmaTarihi = mdtIstenCikisTarihi.Value;
                personel.AktifMi = false;
                _personelC.PersonelGuncelle(personel);
                _personelIseGirisCikisC.IseGiricCikisGuncelle(personelIseGirisCikis);
                MessageBox.Show("Personel için çıkış kaydı oluşturuldu");
                FormuYenile();
            }
        }

        private void btnKaydetGiris_Click(object sender, EventArgs e)
        {
            Personel personel = (Personel)cmbPasifPersoneller.SelectedItem;

            if (personel != null)
            {
                PersonelIseGirisCikis personelIseGirisCikis = new PersonelIseGirisCikis();
                personelIseGirisCikis.IseBaslamaTarihi = mdtIseGirisTarihi.Value;
                personelIseGirisCikis.PersonelId = personel.Id;
                personelIseGirisCikis.OlusturulmaTarihi = DateTime.Now;
                personelIseGirisCikis.OlusturanPersonelId = _olusturanPersonelId;
                personelIseGirisCikis.AktifMi = true;
                _personelIseGirisCikisC.IseGirisCikisEkle(personelIseGirisCikis);
                personel.AktifMi = true;
                _personelC.PersonelGuncelle(personel);
                MessageBox.Show("Personel için giriş kaydı oluşturuldu");
                FormuYenile();
            }
        }
    }
}
