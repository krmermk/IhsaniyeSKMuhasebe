using System;
using IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
using IhsaniyeSKMuhasebe.Entity;

namespace IhsaniyeSKMuhasebe.DAL.Repositories
{
    public class KullaniciSifreManagement : IKullaniciSifre
    {
        IhsaniyeSKContext _db;
        public KullaniciSifreManagement()
        {
            _db = new IhsaniyeSKContext();
        }

        public int AddEntitiy(KullaniciSifre nesne)
        {
            _db.DbKullaniciSifre.Add(nesne);
            int ID = nesne.ID;
            return ID;
        }

        public void DeleteEntity(int Id)
        {
            KullaniciSifre ks = (from k in _db.DbKullaniciSifre where k.KullaniciID == Id where k.AktifMi==true select k).First();
            ks.AktifMi = false;
            SaveEntity();
        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }

        public string GetPassword(int _kullaniciID)
        {
            KullaniciSifre temp = new KullaniciSifre();
            temp = (from sifre in _db.DbKullaniciSifre
                    where sifre.AktifMi == true && sifre.KullaniciID == _kullaniciID
                    select sifre).FirstOrDefault();
            return temp.Sifre;
        }
    }
}
