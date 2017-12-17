using IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities;
using IhsaniyeSKMuhasebe.Entity;
using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.Repositories
{
    public class KullaniciManagement : IKullanici
    {
        PersonelManagement _pm;
        IhsaniyeSKContext _db;
        KullaniciSifreManagement _ksm;
        public KullaniciManagement()
        {
            _db = new IhsaniyeSKContext();
            _pm = new PersonelManagement();
            _ksm = new KullaniciSifreManagement();
        }

        public ICollection<Kullanici> GetKullanici()
        {
            List<Kullanici> listem = (from k in _db.DbKullanici
                                      where k.AktifMi == true
                                      select k).ToList();
            return listem;
        }

        public int AddEntitiy(Kullanici nesne)
        {
            _db.DbKullanici.Add(nesne);
            SaveEntity();
            return nesne.KullaniciID;
        }

        public void DeleteEntity(int Id)
        {
            Kullanici temp = (from tablo in _db.DbKullanici where tablo.PersonelID == Id && tablo.AktifMi==true select tablo).First();
            _ksm.DeleteEntity(temp.KullaniciID);
            temp.AktifMi = false;
            SaveEntity();
        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }



        public ICollection<Personel> KullanicisiOlmayanlar()
        {
            ICollection<Personel> lstPer = _pm.GetPersonel(true);
            ICollection<Kullanici> lstKul = GetKullanici();

            List<Personel> donecekListe = new List<Personel>();

            foreach (Personel item in lstPer)
            {
                int? ID = (from p in _db.DbKullanici where p.PersonelID == item.Id select p.PersonelID).FirstOrDefault();
                if (ID != null)
                {
                    donecekListe.Add(item);
                }
            }

            return donecekListe;
        }
    }
}
