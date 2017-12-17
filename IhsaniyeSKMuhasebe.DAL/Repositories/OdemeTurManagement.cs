using IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities;
using IhsaniyeSKMuhasebe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;

namespace IhsaniyeSKMuhasebe.DAL.Repositories
{
    public class OdemeTurManagement:IOdemeTur
    {
        IhsaniyeSKContext _db;
        public OdemeTurManagement()
        {
            _db = new IhsaniyeSKContext();

        }
        public ICollection<OdemeTuru> GetEntities ()
        {
            List<OdemeTuru> lst = new List<OdemeTuru>();
            lst = (from odeme in _db.DbOdemeTuru
                   where odeme.AktifMi == true
                   select odeme).ToList();
            return lst;
        }

        public int AddEntitiy(OdemeTuru nesne)
        {
            _db.DbOdemeTuru.Add(nesne);
            SaveEntity();
            return nesne.ID;
        }

        public void DeleteEntity(int Id)
        {
            OdemeTuru od = (from o in _db.DbOdemeTuru where o.ID == Id select o).First();
            od.AktifMi = false;
            SaveEntity();
        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }
    }
}
