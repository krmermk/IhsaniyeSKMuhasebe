using IhsaniyeSKMuhasebe.BLL.Controller;
using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
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
    public partial class FormKullaniciTanimla : MetroForm
    {
        KullaniciController kc;
        int _olusturanPersonelID;
        public FormKullaniciTanimla(int kID)
        {
            InitializeComponent();
            kc = new KullaniciController();
            _olusturanPersonelID = kID;
        }

        private void btnSayfaKapat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSayfaKapat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKullaniciTanimla_Load(object sender, EventArgs e)
        {
            Helper.BindComboBox<Personel>(kc.KullanicisiOlmayanlar(), cmbPersonel, "FullName", "Id");
            Helper.BindComboBox<Kullanici>(kc.GetKullanici(), cmbKullanici, "KullaniciAdi", "KullaniciID");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            k.PersonelID = ((Personel)cmbPersonel.SelectedItem).Id;
            k.KullaniciAdi = txtKullaniciAdi.Text.Trim();
            k.OlusturanPersonelID = _olusturanPersonelID;
            k.OlusturulmaTarihi = DateTime.Now;
            k.AktifMi = true;
            MessageBox.Show(kc.AddKullanici(k, txtSifre.Text.Trim()));
            FormYenile();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(kc.DeleteKullanici(((Kullanici)cmbKullanici.SelectedItem).PersonelID));
            FormYenile();
        }

        private void FormYenile()
        {
            Helper.Clears(this.Controls);
            Helper.BindComboBox<Personel>(kc.KullanicisiOlmayanlar(), cmbPersonel, "FullName", "Id");
            Helper.BindComboBox<Kullanici>(kc.GetKullanici(), cmbKullanici, "KullaniciAdi", "KullaniciID");
        }
    }
}
