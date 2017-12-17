using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using IhsaniyeSKMuhasebe.BLL.Controller;
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
    public partial class FormHesapIslemEkleSil : MetroForm
    {
        bool _yon = true;
        int _olusturanPersonelId;
        HesapIslemTurController _hitmControl;
        public FormHesapIslemEkleSil(int personelID)
        {
            InitializeComponent();
            _hitmControl = new HesapIslemTurController();
            _olusturanPersonelId = personelID;
        }

        private void btnIptal1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIptal2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtnEkle_Click(object sender, EventArgs e)
        {
            HesapIslemTur nesne = new HesapIslemTur();
            nesne.HesapIslemTurAdi = txtHesapIslemTurAdi.Text;
            nesne.Aciklama = txtAciklama1.Text;
            nesne.HesapIslemYonu = _yon;
            nesne.OlusturanPersonelID = _olusturanPersonelId;
            nesne.OlusturlmaTarihi = DateTime.Now;
            nesne.AktifMi = true;
            MessageBox.Show(_hitmControl.AddEntity(nesne));
            FormYenile();
        }

        private void rdbGelir_CheckedChanged(object sender, EventArgs e)
        {
            _yon = true;
        }

        private void rdbGider_CheckedChanged(object sender, EventArgs e)
        {
            _yon = false;
        }
        public void CmbDoldur()
        {
            Helper.BindComboBox<HesapIslemTur>(_hitmControl.GetEntities(), cmbGuncelle, "HesapIslemTurAdi", "ID");
            Helper.BindComboBox<HesapIslemTur>(_hitmControl.GetEntities(), cmbHesapIslemTur, "HesapIslemTurAdi", "ID");
        }
        private void FormHesapIslemEkleSil_Load(object sender, EventArgs e)
        {
            CmbDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _hitmControl.DeleteEntity(((HesapIslemTur)cmbHesapIslemTur.SelectedItem).ID);
            FormYenile();
        }

        private void cmbHesapIslemTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            HesapIslemTur item = (HesapIslemTur)cmbHesapIslemTur.SelectedItem;
            txtSilAciklama.Text = item.Aciklama;
            if (item.HesapIslemYonu)
            {
                rdbSilGelir.Checked = true;
            }
            else
            {
                rdbSilGider.Checked = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if ((cmbGuncelle.SelectedItem != null) && (Helper.NullableControl(txtTurAdi.Text))
                &&
                (Helper.NullableControl(txtAciklamaGuncelle.Text)) && ((rbGelir.Checked) || (rbGider.Checked)))
                    {
                        HesapIslemTur guncellehit = (HesapIslemTur)cmbGuncelle.SelectedItem;
                        guncellehit.HesapIslemTurAdi = txtHesapIslemTurAdi.Text;
                        guncellehit.Aciklama = txtAciklamaGuncelle.Text;
                        if (rdbGelir.Checked)
                        {
                            guncellehit.HesapIslemYonu = true;
                        }
                        if (rbGider.Checked)
                        {
                            guncellehit.HesapIslemYonu = true;
                        }
                        _hitmControl.UpdateEntity(guncellehit);
                    }
            FormYenile();
        }

        private void FormYenile()
        {
            Helper.Clears(this.Controls);
            CmbDoldur();
        }

        private void cmbGuncelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGuncelle.SelectedIndex == -1)
            {
                txtTurAdi.Text = string.Empty;
            }
            else
            {
                txtTurAdi.Text = cmbGuncelle.Text;
                
            }
        }
    }
}
