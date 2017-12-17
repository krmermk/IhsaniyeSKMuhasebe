using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class KullaniciController
    {
        KullaniciManagement km;
        KullaniciSifreManagement ksm;
        public KullaniciController()
        {
            km = new KullaniciManagement();
            ksm = new KullaniciSifreManagement();
        }

        public ICollection<Personel> KullanicisiOlmayanlar()
        {
            return km.KullanicisiOlmayanlar();
        }

        public string AddKullanici(Kullanici item,string sifre)
        {
            KullaniciSifre ks = new KullaniciSifre();
            if (item.PersonelID != null && !String.IsNullOrEmpty(sifre) && !String.IsNullOrEmpty(item.KullaniciAdi))
            {
                try
                {
                    ks.KullaniciID = km.AddEntitiy(item);
                    ks.Sifre = sifre;
                    ks.OlusturulmaTarihi = DateTime.Now;
                    ks.OlusturanPersonelID = item.OlusturanPersonelID;
                    ks.AktifMi = true;
                    ksm.AddEntitiy(ks);
                    ksm.SaveEntity();
                    return "İşlem Başarılı!";
                }
                catch (Exception)
                {
                    return "Lütfen Girdiğiniz değerleri konrol ediniz.";
                }                
            }
            return "Lütfen Girdiğiniz değerleri konrol ediniz.";
        }

        public ICollection<Kullanici> GetKullanici()
        {
            return km.GetKullanici();
        }

        public string DeleteKullanici(int PersID)
        {
            try
            {
                km.DeleteEntity(PersID);
                return "İşlem Başarılı";
            }
            catch (Exception)
            {
                return "Lütfen silmek istediğiniz kullanıcıyı seçiniz.";
            }
        }
    }
}
