using IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities;
using IhsaniyeSKMuhasebe.Entity;
using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.Repositories
{
    public class KasaIslemManagement:IKasaIslem

    {
        IhsaniyeSKContext _db;
        public KasaIslemManagement()
        {
            _db = new IhsaniyeSKContext();
        }

        public int AddEntitiy(Entity.Entities.KasaEntity.KasaIslem nesne)
        {
            _db.DbKasaIslem.Add(nesne);
            SaveEntity();
            return nesne.ID;
        }


        public void DeleteEntity(int Id)
        {

            KasaIslem tempki = new KasaIslem();
            tempki = (from kasaislem in _db.DbKasaIslem
                      where kasaislem.ID ==Id
                      select kasaislem).FirstOrDefault();
            tempki.AktifMi = false;
            SaveEntity();

        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }
      
    }
}
