using IhsaniyeSKMuhasebe.BLL.Controller;
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

namespace IhsaniyeSKMuhasebe.WinUI.TanimlarMenu
{
    public partial class FormDepartmanEkleSil : MetroForm
    {
        DepartmanController _dc;
        int islemYapanKullanici;
        public FormDepartmanEkleSil(int mevcutKullanici)
        {
            InitializeComponent();
            _dc = new DepartmanController();
            islemYapanKullanici = mevcutKullanici;
            ComboDoldur();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSayfaKapat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYeniDepartman.Text))
            {
                if (_dc.DepartmanEkle(txtYeniDepartman.Text,islemYapanKullanici))
                {
                    MessageBox.Show("Yeni Departman Tanımlanmıştır.");
                    FormYenile();
                }
                else
                {
                    MessageBox.Show("Aynı isimde departman kaydı bulunmaktadır.");
                }               
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbDepartmanlar.SelectedItem is Departman)
            {
                Departman departman = (Departman)cmbDepartmanlar.SelectedItem;
                if (MessageBox.Show(departman.DepartmanAdi + " departmanını silmek istediğinize emin misiniz.", "Dikkat...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _dc.DepartmanSil(departman.Id);                  
                      MessageBox.Show("Departman silme işlemi başarıyla tamamlanmıştır.");
                      FormYenile();
                }
            }
        }
        public void ComboDoldur()
        {
            Helper.BindComboBox<Departman>(_dc.AktifDepartmanlariGetir(), cmbDepartmanlar, "DepartmanAdi", "ID");
            Helper.BindComboBox<Departman>(_dc.AktifDepartmanlariGetir(), cmbGuncelle, "DepartmanAdi", "ID");            
        }
        private void btnBankaGuncelle_Click(object sender, EventArgs e)
        {
            Departman guncelleDepartman = (Departman)cmbGuncelle.SelectedItem;
            if (cmbGuncelle.SelectedItem!=null)
            {
                if (Helper.NullableControl(txtGuncelle.Text))
                {
                    guncelleDepartman.DepartmanAdi = txtGuncelle.Text; 
                    _dc.UpdateDepartman(guncelleDepartman);
                    MessageBox.Show("Güncelleme Başarılı");
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Geçersiz Değer Girdiniz");
                }
            }
            FormYenile();
        }

        private void FormYenile()
        {
            Helper.Clears(this.Controls);
            ComboDoldur();
        }

        private void cmbGuncelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGuncelle.SelectedIndex == -1)
            {
                txtGuncelle.Text = string.Empty;
            }
            else
            {
                txtGuncelle.Text = cmbGuncelle.Text;

            }
        }
    }
}
