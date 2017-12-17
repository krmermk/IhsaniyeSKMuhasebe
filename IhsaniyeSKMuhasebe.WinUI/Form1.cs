using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using IhsaniyeSKMuhasebe.WinUI.GoruntuleMenu;
using IhsaniyeSKMuhasebe.WinUI.EkleMenu;
using IhsaniyeSKMuhasebe.WinUI.KasaIslemMenu;
using IhsaniyeSKMuhasebe.WinUI.TanimlarMenu;
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
using IhsaniyeSKMuhasebe.Entity;
using IhsaniyeSKMuhasebe.WinUI.RaporlarMenu;


namespace IhsaniyeSKMuhasebe.WinUI
{
    public partial class Form1 : MetroForm
    {
        IhsaniyeSKContext _db;
        int _olusturanPersonelID;
        public Form1(int persID)
        {
            InitializeComponent();
            _olusturanPersonelID = persID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _db = new IhsaniyeSKContext();

            List<Personel> prs = (from p in _db.DbPersonel select p).ToList();
        }

        private void personelBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonelGoruntule frm = new FormPersonelGoruntule(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspSirketBireyGoruntule_Click(object sender, EventArgs e)
        {
            FormSirketBireyGoruntule frm = new FormSirketBireyGoruntule(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspUyeGoruntule_Click(object sender, EventArgs e)
        {
            FormUyeGoruntule frm = new FormUyeGoruntule();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspPersonelEkle_Click(object sender, EventArgs e)
        {
            FormPersonelEkle frm = new FormPersonelEkle(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspSirketBireyEkle_Click(object sender, EventArgs e)
        {
            FormSirketBireyEkle frm = new FormSirketBireyEkle(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspUyeTanimla_Click(object sender, EventArgs e)
        {
            FormUyeTanimla frm = new FormUyeTanimla(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspKullaniciTanimla_Click(object sender, EventArgs e)
        {
            FormKullaniciTanimla frm = new FormKullaniciTanimla(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspIseGirisCikis_Click(object sender, EventArgs e)
        {
            FormIseGirisCikis frm = new FormIseGirisCikis(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspGelirGiderIslem_Click(object sender, EventArgs e)
        {
            FormKasaIslem frm = new FormKasaIslem(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspUnvanEkleSil_Click(object sender, EventArgs e)
        {
            FormUnvanEkleSil frm = new FormUnvanEkleSil(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspDepartmanEkleSil_Click(object sender, EventArgs e)
        {
            FormDepartmanEkleSil frm = new FormDepartmanEkleSil(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspOdemeTurEkleSil_Click(object sender, EventArgs e)
        {
            FormOdemeTurEkleSil frm = new FormOdemeTurEkleSil(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tspHesapIslemTurEkleSil_Click(object sender, EventArgs e)
        {
            FormHesapIslemEkleSil frm = new FormHesapIslemEkleSil(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void bankaEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBankaEkleSil frm = new FormBankaEkleSil(_olusturanPersonelID);
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tspGelirGiderRaporla_Click(object sender, EventArgs e)
        {

            FormGelirGiderRapor frm = new FormGelirGiderRapor();
            frm.MdiParent = this;
            frm.Show();

        }

    }
}
