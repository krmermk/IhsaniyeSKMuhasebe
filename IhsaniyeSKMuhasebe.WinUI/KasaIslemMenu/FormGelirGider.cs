using IhsaniyeSKMuhasebe.BLL.Controller;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
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

namespace IhsaniyeSKMuhasebe.WinUI.KasaIslemMenu
{

    //
    //
    //      CARİ UYE BOŞ OLDUĞU İÇİN HATA VERİR 
    //
    public partial class FormKasaIslem : MetroForm
    {
        int DegistirenID;
        public FormKasaIslem(int PersID)
        {
            InitializeComponent();
            GelirGiderComboDoldur();
            DegistirenID = PersID;

        }
        HesapIslemTurController hitc;
        CariUyeController cuc;
        OdemeTurController otc;
        KasaIslem _kasa;
        KasaIslemController _kic;
        public void GelirGiderComboDoldur()
        {
            hitc = new HesapIslemTurController();
            Helper.BindComboBox<HesapIslemTur>(hitc.GetEntities().ToList(), cmbEkleHesapIslemTur, "HesapIslemTurAdi", "ID");
            cuc = new CariUyeController();
            Helper.BindComboBox<CariUye>(cuc.GetEntities().ToList(), cmbEkleCariUye, "CariAdi", "ID");
            otc = new OdemeTurController();
            Helper.BindComboBox<OdemeTuru>(otc.OdemeTurGetir().ToList(), cmbEkleOdemeTur, "OdemeTuruAdi", "ID");
        }

        private void FormKasaIslem_Load(object sender, EventArgs e)
        {
            GelirGiderComboDoldur();
            KasaIslemDTOGetir();
            this.Location = new Point(0, 0);
            mbtnSil.Enabled = false;
        }

        public void KasaIslemDTOGetir()
        {
            KasaIslemDTOContoller kidc = new KasaIslemDTOContoller();
            dgvSilKasaIslemwinform.DataSource = kidc.KasaIslemDTOGetir().ToList();
            dgvSilKasaIslemwinform.Columns[0].Visible = false;
        }
        private void mbtnEkle_Click(object sender, EventArgs e)
        {
            double miktar;
            _kasa = new KasaIslem();
            if ((((HesapIslemTur)cmbEkleHesapIslemTur.SelectedItem).ID != null) && (((CariUye)cmbEkleCariUye.SelectedItem).ID != null) && (((OdemeTuru)cmbEkleOdemeTur.SelectedItem).ID != null) && (double.TryParse(txtEkleMiktar.Text, out miktar)) && (dtpEkleIslemTarihi.Value !=null))
            {
                _kasa.HesapIslemID = ((HesapIslemTur)cmbEkleHesapIslemTur.SelectedItem).ID;
                _kasa.CariUyeID = ((CariUye)cmbEkleCariUye.SelectedItem).ID;
                _kasa.OdemeID = ((OdemeTuru)cmbEkleOdemeTur.SelectedItem).ID;
                _kasa.Miktar = miktar;
                _kasa.Aciklama = rtxtAciklama.Text;
                _kasa.ReferansBelgeNo = txtEkleReferansBelgeNo.Text;

                _kasa.OlusturanPersonelID = DegistirenID;
                _kasa.AktifMi = true;
                _kasa.OlusturlmaTarihi = DateTime.Now;
                _kasa.IslemTarihi = dtpEkleIslemTarihi.Value;

                _kic = new KasaIslemController();
                MessageBox.Show(_kic.KasaIslemEkle(_kasa));
                FormYenile();
                Helper.Clears(mtpEkleGelirGider.Controls);
            }
            else
            {
                MessageBox.Show("Lütfen seçimlerinizi yapınız & bilgileri doldurunuz !!!");
            }
        }
        private void mbtnSil_Click(object sender, EventArgs e)
        {
            KasaIslemDTOGetir();
        }


        private void dgvSilKasaIslem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mbtnSil.Enabled = true;
            _kasa = new KasaIslem();
            _kic = new KasaIslemController();
            if (e.RowIndex>0&&e.RowIndex<dgvSilKasaIslemwinform.RowCount-1)//köşeye tıklandığında patlamasın diye 
            {

                _kasa.ID = (int)((DataGridView)sender).Rows[e.RowIndex].Cells["ID"].Value;
            }
            _kic.KasaIslemSil(_kasa.ID);        
        }

        private void FormYenile()
        {
            Helper.Clears(this.Controls);
            Helper.BindComboBox<HesapIslemTur>(hitc.GetEntities().ToList(), cmbEkleHesapIslemTur, "HesapIslemTurAdi", "ID");
            Helper.BindComboBox<CariUye>(cuc.GetEntities().ToList(), cmbEkleCariUye, "CariAdi", "ID");
            Helper.BindComboBox<OdemeTuru>(otc.OdemeTurGetir().ToList(), cmbEkleOdemeTur, "OdemeTuruAdi", "ID");
        }

        private void txtEkleMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            char Virgul = (char)8;
            if (!txtEkleMiktar.Text.Contains(","))
            {
                Virgul = (char)44;
            }

            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != Virgul;
        }
    }
}