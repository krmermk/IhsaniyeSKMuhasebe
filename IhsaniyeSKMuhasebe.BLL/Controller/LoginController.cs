using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class LoginController
    {
        KullaniciManagement km;
        KullaniciSifreManagement ksm;
        public LoginController()
        {
            km = new KullaniciManagement();
            ksm = new KullaniciSifreManagement();
        }

        public int Giris(string _kullaniciAdi,string _sifre)
        {
            try
            {
                ICollection<Kullanici> kullanicilar = km.GetKullanici();
                foreach (Kullanici item in kullanicilar)
                {
                    if (item.KullaniciAdi == _kullaniciAdi)
                    {
                        string kullaniciPass = ksm.GetPassword(item.KullaniciID);
                        if (_sifre == kullaniciPass)
                        {
                            return item.PersonelID;
                        }
                    }
                }
                return -1;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
            }            
        }
    }
}
