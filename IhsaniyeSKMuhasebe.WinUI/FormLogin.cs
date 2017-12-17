using IhsaniyeSKMuhasebe.BLL.Controller;
using IhsaniyeSKMuhasebe.Entity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhsaniyeSKMuhasebe.WinUI
{
    public partial class FormLogin : Form
    {
        BankaTanimController _btc;
        LoginController lc;
        int _personelID;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public FormLogin()
        {
            InitializeComponent();
            _btc = new BankaTanimController();
            _btc.AktifBankaGetir();
            lc = new LoginController();
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitTile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeTile_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Giris();
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Giris();
            }
        }

        private void Giris()
        {
            _personelID = lc.Giris(txtKullaniciAdi.Text, txtSifre.Text);
            if (_personelID != -1)
            {
                Form1 frm = new Form1(_personelID);
                frm.Show();
                this.Hide();
            }
            else
            {
                txtKullaniciAdi.WithError = true;
                txtSifre.WithError = true;
            }
        }
    }
}
