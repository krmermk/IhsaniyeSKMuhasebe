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
    public partial class FormUnvanEkleSil : MetroForm
    {
        UnvanController _unvan;
        int islemiYapanPersonlId;
        public FormUnvanEkleSil(int personelId)
        {
            InitializeComponent();
            _unvan = new UnvanController();
            islemiYapanPersonlId = personelId;
           
            
        }

        private void FormUnvanEkleSil_Load(object sender, EventArgs e)
        {
            ComboDoldur();

        }
        public void ComboDoldur()
        {
            Helper.BindComboBox<Unvan>(_unvan.GetUnvan(), cmbUnvanlar, "GorevAdi", "ID");
            Helper.BindComboBox<Unvan>(_unvan.GetUnvan(), cmbGuncelle, "GorevAdi", "ID");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Unvan un = new Unvan();
                if (Helper.NullableControl(txt.Text))
                {
                    un.GorevAdi = txt.Text;
                    un.AktifMi = true;
                    un.OlusturulmaTarihi = DateTime.Now;
                    un.OlusturanPersonelId = islemiYapanPersonlId;
                }
                else
                {
                    MessageBox.Show("Lütfen Ünvan Adı Giriniz");
                }
                _unvan.UnvanEkle(un);
                MessageBox.Show("Yeni ünvan eklendi");

                FormYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSayfaKapat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Unvan unvan = (Unvan)cmbUnvanlar.SelectedItem;
                if (MessageBox.Show(unvan.GorevAdi + " unvanını silmek istediğinize eminmisiniz.", "Dikkat...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _unvan.DeleteUnvan(((Unvan)cmbUnvanlar.SelectedItem).Id);
                    MessageBox.Show("İşlem başarıyla gercekleşti");
                    FormYenile();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if ((cmbGuncelle.SelectedItem!=null)&&(Helper.NullableControl( txtGuncelle.Text)))
            {
                Unvan guncelleUnvan = (Unvan)cmbGuncelle.SelectedItem;
                guncelleUnvan.GorevAdi = txtGuncelle.Text;
                _unvan.UpdateUnvan(guncelleUnvan);
                FormYenile();
            }
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
