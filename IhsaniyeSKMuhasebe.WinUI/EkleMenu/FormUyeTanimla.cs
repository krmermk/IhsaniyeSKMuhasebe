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

namespace IhsaniyeSKMuhasebe.WinUI.EkleMenu
{
    public partial class FormUyeTanimla : MetroForm
    {
        CariUyeController _cariUC;
        int _olusturanPersonelID;
        public FormUyeTanimla(int olusturanPersonel)
        {
            InitializeComponent();
            _cariUC = new CariUyeController();
            _olusturanPersonelID = olusturanPersonel;
        }


        private void btnSayfaKapat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUyeTanimla_Load(object sender, EventArgs e)
        {
            Helper.BindComboBox<CariUye>(_cariUC.GetUyeOlanlar(), cmbUyeOlanlar, "CariAdi", "ID");
            Helper.BindComboBox<CariUye>(_cariUC.GetUyeOlmayanlar(), cmbUyeOlmayanlar, "CariAdi", "ID");
        }

        private void btnUyeYap_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_cariUC.UyelikIslemi((CariUye)cmbUyeOlmayanlar.SelectedItem, true,_olusturanPersonelID));
            this.Close();
        }

        private void btnUyeliktenCikar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_cariUC.UyelikIslemi((CariUye)cmbUyeOlanlar.SelectedItem, false,_olusturanPersonelID));
            this.Close();
        }

        private void FormYenile()
        {
            Helper.Clears(this.Controls);
            Helper.BindComboBox<CariUye>(_cariUC.GetUyeOlanlar(), cmbUyeOlanlar, "CariAdi", "ID");
            Helper.BindComboBox<CariUye>(_cariUC.GetUyeOlmayanlar(), cmbUyeOlmayanlar, "CariAdi", "ID");
        }
    }
}
