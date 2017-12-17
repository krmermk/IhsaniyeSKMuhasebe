using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
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
using IhsaniyeSKMuhasebe.Extension;
using IhsaniyeSKMuhasebe.BLL.Controller;

namespace IhsaniyeSKMuhasebe.WinUI.TanimlarMenu
{
    public partial class FormOdemeTurEkleSil : MetroForm
    {
        int DegistirenID;
        public FormOdemeTurEkleSil(int PersID)
        {
            InitializeComponent();
            DegistirenID = PersID;
        }
        OdemeTuru _odeme;
        OdemeTurController otc;
        
        private void FormOdemeTurEkleSil_Load(object sender, EventArgs e)
        {
            OdemeTurdoldur();
        }

        void OdemeTurdoldur()
        {
            otc = new OdemeTurController();
            ICollection<OdemeTuru> lstOdemeTuru = otc.OdemeTurGetir();
            Helper.BindComboBox<OdemeTuru>(lstOdemeTuru, cmbOdemeTurSil, "OdemeTuruAdi", "ID");
            Helper.BindComboBox<OdemeTuru>(lstOdemeTuru, cmbGuncelle, "OdemeTuruAdi", "ID");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _odeme = new OdemeTuru();
            if (Helper.NullableControl(txtOdemeTur.Text))
            {
                _odeme.OdemeTuruAdi = txtOdemeTur.Text;
                _odeme.OlusturanPersonelID = DegistirenID;
                _odeme.AktifMi = true;
                _odeme.OlusturlmaTarihi = DateTime.Now;
                otc = new OdemeTurController();
                MessageBox.Show(otc.OdemeTurEkle(_odeme));
                FormYenile();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
          

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
              if ((cmbGuncelle.SelectedItem!=null)&&(txtGuncelle.Text!=null))
            {

                OdemeTuru guncelleOd = (OdemeTuru)cmbGuncelle.SelectedItem;
                guncelleOd.OdemeTuruAdi = txtGuncelle.Text;
                otc.OdemeTurGuncelle(guncelleOd);
                FormYenile();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _odeme = (OdemeTuru)cmbOdemeTurSil.SelectedItem;
            if (MessageBox.Show(_odeme.OdemeTuruAdi + " Ödeme Türü silmek istediğinize eminmisiniz.", "Dikkat...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(otc.OdemeTurSil(((OdemeTuru)cmbOdemeTurSil.SelectedItem).ID));
                FormYenile();
            }
        }

        private void btnSayfaKapat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormYenile()
        {
            Helper.Clears(this.Controls);
            OdemeTurdoldur();
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

