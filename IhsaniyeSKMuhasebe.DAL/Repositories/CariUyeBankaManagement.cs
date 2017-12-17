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
    public class CariUyeBankaManagement : ICariUyeBanka
    {
        IhsaniyeSKContext _db;
        public CariUyeBankaManagement()
        {
            _db = new IhsaniyeSKContext();
        }


        public void DeleteEntity(int Id)
        {
            CariUyeBanka temp = new CariUyeBanka();
            temp = (from cub in _db.DbCariUyeBanka
                    where cub.ID == Id && cub.AktifMi == true
                    select cub).FirstOrDefault();
            if (temp!=null)
            {
                temp.AktifMi = false;
            }            
            SaveEntity();
        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }

        public int AddEntitiy(CariUyeBanka nesne)
        {
            _db.DbCariUyeBanka.Add(nesne);
            SaveEntity();
            return 0;
        }

        public void BankaBilgileriGuncelle(CariUyeBanka nesne)
        {
            CariUyeBanka temp = new CariUyeBanka();
            temp = (from cub in _db.DbCariUyeBanka
                    where cub.AktifMi == true && cub.CariUyeID == nesne.CariUyeID
                    select cub).FirstOrDefault();
            if (temp != null)
            {
                DeleteEntity(temp.ID);
            }
            AddEntitiy(nesne);
            SaveEntity();
        }
    }
}
