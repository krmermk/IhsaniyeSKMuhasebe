using IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities;
using IhsaniyeSKMuhasebe.Entity;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.Repositories
{
  public  class CariUyeBilgileriManagement:ICariUyeBilgileri
    {
      IhsaniyeSKContext _db;
      public CariUyeBilgileriManagement()
      {
          _db = new IhsaniyeSKContext();
      }
    

        public void DeleteEntity(int Id)
        {
            CariUyeBilgileri temp =(from tablo in _db.DbCariUyeBilgileri where tablo.CariUyeID==Id && tablo.AktifMi==true select tablo).First();
            temp.AktifMi = false;
            SaveEntity();
        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }

        public int AddEntitiy(CariUyeBilgileri nesne)
        {
            _db.DbCariUyeBilgileri.Add(nesne);
            
            SaveEntity();
            int ID = nesne.ID;
            return ID;
        }

        public void BilgileriGuncelle(CariUyeBilgileri nesne)
        {
            CariUyeBilgileri temp = new CariUyeBilgileri();
            temp = (from cub in _db.DbCariUyeBilgileri
                    where cub.AktifMi == true && cub.CariUyeID == nesne.CariUyeID
                    select cub).FirstOrDefault();
            if (temp!=null)
            {
                DeleteEntity(temp.ID);
            }            
            AddEntitiy(nesne);
            SaveEntity();
        }
    }
}
