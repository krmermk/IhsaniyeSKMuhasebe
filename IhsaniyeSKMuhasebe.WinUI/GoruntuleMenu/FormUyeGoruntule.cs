using MetroFramework.Forms;
using IhsaniyeSKMuhasebe.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IhsaniyeSKMuhasebe.BLL.Controller;

namespace IhsaniyeSKMuhasebe.WinUI.GoruntuleMenu
{
    public partial class FormUyeGoruntule : MetroForm
    {
        CariUyeController _cariUC;
        public FormUyeGoruntule()
        {
            InitializeComponent();
            _cariUC = new CariUyeController();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void YenidenDoldur()
        {
            grdUyeListele.DataSource = null;
            string isim = txtAdAra.Text.Trim();
            if (Helper.NullableControl(isim))
            {
                grdUyeListele.DataSource = _cariUC.GetUyeOlanlarDTO(isim);
            }
            else
            {
                grdUyeListele.DataSource = _cariUC.GetUyeOlanlarDTO();
            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            YenidenDoldur();
        }
    }
}
