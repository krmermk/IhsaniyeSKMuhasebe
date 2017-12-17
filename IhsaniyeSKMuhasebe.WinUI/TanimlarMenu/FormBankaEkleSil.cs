using IhsaniyeSKMuhasebe.BLL.Controller;
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

namespace IhsaniyeSKMuhasebe.WinUI.TanimlarMenu
{
    public partial class FormBankaEkleSil : MetroForm
    {
        BankaTanimController _bankaTanimControl;
        int islemiYapanPersonlId;
        public FormBankaEkleSil(int personelId)
        {
            InitializeComponent();
            _bankaTanimControl = new BankaTanimController();
            islemiYapanPersonlId = personelId;
        }

        private void FormBankaEkleSil_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }
        public void ComboDoldur()
        {
            Helper.BindComboBox<BankaTanim>(_bankaTanimControl.AktifBankaGetir(), cmbBankaGuncelle, "BankaAdi", "ID");
            Helper.BindComboBox<BankaTanim>(_bankaTanimControl.AktifBankaGetir(), cmbBankar, "BankaAdi", "ID");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                BankaTanim bt = new BankaTanim();
                if (Helper.NullableControl(txtBankaAdi.Text))
                {
                    bt.BankaAdi = txtBankaAdi.Text;
                    bt.AktifMi = true;
                    bt.OlusuturulmaTarihi = DateTime.Now;
                    bt.OlusturanPersonelID = islemiYapanPersonlId;
                    _bankaTanimControl.BankaEkle(bt);
                    MessageBox.Show("Yeni Banka eklendi");
                    ComboDoldur();
                }
                else
                {
                    MessageBox.Show("Lütfen Banka Adı Giriniz");
                }

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                BankaTanim bt = (BankaTanim)cmbBankar.SelectedItem;
                if (MessageBox.Show(bt.BankaAdi + "  silmek istediğinize eminmisiniz.", "Dikkat...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _bankaTanimControl.DeleteBanka(((BankaTanim)cmbBankar.SelectedItem).ID);
                    MessageBox.Show("İşlem başarıyla gercekleşti");
                    FormYenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSayfaKapat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBankaGuncelle_Click(object sender, EventArgs e)
        {
            BankaTanim guncelleBanka = (BankaTanim)cmbBankaGuncelle.SelectedItem;
            if (cmbBankaGuncelle.SelectedItem!=null)
            {
                if (Helper.NullableControl(txtBankaGuncelle.Text))
                {
                    guncelleBanka.BankaAdi = txtBankaGuncelle.Text;
                    _bankaTanimControl.UpdateBanka(guncelleBanka);
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

        private void cmbBankaGuncelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBankaGuncelle.SelectedIndex == -1)
            {
                txtBankaGuncelle.Text = string.Empty;
            }
            else
            {
                txtBankaGuncelle.Text = cmbBankaGuncelle.Text;

            }
        }
    }
}
