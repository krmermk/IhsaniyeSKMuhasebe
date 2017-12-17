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

namespace IhsaniyeSKMuhasebe.WinUI.GoruntuleMenu
{
    public partial class FormPersonelGoruntule : MetroForm
    {
        PersonelGoruntuleDTO pgDTO;
        UnvanController _unC;
        DepartmanController _depC;
        PersonelController _pc;
        CariUyeController _cc;
        PersonelIsTanimController _pitc;
        CariUyeBilgileriController _cubc;
        PersonelGoruntuleDTOController _pgDTOc;
        int _persID;
        public FormPersonelGoruntule(int olusturanPersonel)
        {
            InitializeComponent();
            _unC = new UnvanController();
            _depC = new DepartmanController();
            _pc = new PersonelController();
            _pgDTOc = new PersonelGoruntuleDTOController();
            _persID = olusturanPersonel;
            _cc = new CariUyeController();
            _pitc = new PersonelIsTanimController();
            _cubc = new CariUyeBilgileriController();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            YenidenDoldur();
        }
        public void YenidenDoldur()
        {
            grdPersonelListele.DataSource = null;
            Helper.Clears(pnlAltControls.Controls);
            string isim = txtAdAra.Text.Trim();
            if (Helper.NullableControl(isim))
            {

                grdPersonelListele.DataSource = _pgDTOc.GetPersonelGoruntuleDTO(isim);
            }
            else
            {
                grdPersonelListele.DataSource = _pgDTOc.GetPersonelGoruntuleDTO();
            }
            grdPersonelListele.Columns[13].Visible = false;
            grdPersonelListele.Columns[14].Visible = false;
            grdPersonelListele.Columns[15].Visible = false;
            grdPersonelListele.Columns[16].Visible = false;
            grdPersonelListele.Columns[17].Visible = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void FormPersonelGoruntule_Load(object sender, EventArgs e)
        {
            Helper.BindComboBox<Unvan>(_unC.GetUnvan(), cmbUnvan, "GorevAdi", "Id");
            Helper.BindComboBox<Departman>(_depC.AktifDepartmanlariGetir(), cmbDepartman, "DepartmanAdi", "Id");
            Helper.BindComboBox<Personel>(_pc.AktifPersonelleriGetir(), cmbYoneticisi, "FullName", "Id");
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void grdPersonelListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.Clears(pnlAltControls.Controls);
            pgDTO = new PersonelGoruntuleDTO();
            pgDTO = (PersonelGoruntuleDTO)grdPersonelListele.Rows[e.RowIndex].DataBoundItem;

            txtTcKimlikNo.Text = pgDTO.TCNO;
            txtAd.Text = pgDTO.Adi;
            txtSoyadi.Text = pgDTO.Soyadi;
            dtDogumTarihi.Value = pgDTO.DogumTarihi;
            txtEmail.Text = pgDTO.EMail;
            txtTelefon.Text = pgDTO.Telefon;
            txtAdres.Text = pgDTO.Adres;
            if (pgDTO.UnvanID != null) cmbUnvan.SelectedValue = pgDTO.UnvanID;
            if (pgDTO.DepartmanID != null) cmbDepartman.SelectedValue = pgDTO.DepartmanID;
            if (pgDTO.YoneticiID != null) cmbYoneticisi.SelectedValue = pgDTO.YoneticiID;
            txtMaas.Text = pgDTO.Maas.ToString();
            txtGorevAciklamasi.Text = pgDTO.GorevAciklamasi;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string mboxText = "";
            int maas = 0;
            PersonelGoruntuleDTO temp = new PersonelGoruntuleDTO();
            temp.PersonelID = pgDTO.PersonelID;
            temp.TCNO = txtTcKimlikNo.Text.Trim();
            temp.Adi = txtAd.Text.Trim();
            temp.Soyadi = txtSoyadi.Text.Trim();
            temp.DogumTarihi = dtDogumTarihi.Value;
            temp.EMail = txtEmail.Text.Trim();
            temp.Telefon = txtTelefon.Text.Trim();
            temp.Adres = txtAdres.Text.Trim();
                temp.UnvanAdi = ((Unvan)cmbUnvan.SelectedItem).GorevAdi;
            temp.UnvanID = ((Unvan)cmbUnvan.SelectedItem).Id;
            temp.DepartmanAdi = ((Departman)cmbDepartman.SelectedItem).DepartmanAdi;
            temp.DepartmanID = ((Departman)cmbDepartman.SelectedItem).Id;
            temp.YoneticiAdi = ((Personel)cmbYoneticisi.SelectedItem).FullName;
            temp.YoneticiID = ((Personel)cmbYoneticisi.SelectedItem).Id;
            if (int.TryParse(txtMaas.Text, out maas))
            {
                temp.Maas = Convert.ToDecimal(txtMaas.Text);
            }
            
            temp.CariUyeID = pgDTO.CariUyeID;
            temp.OlusturanPersonelID = _persID;
            MessageBox.Show(_pgDTOc.Guncelle(pgDTO, temp));
            YenidenDoldur();
        }

        private void txtTcKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _pc.DeletePersonel(pgDTO.PersonelID);
            _cc.DeleteCari((int)pgDTO.CariUyeID);
            YenidenDoldur();
        }
    }
}
