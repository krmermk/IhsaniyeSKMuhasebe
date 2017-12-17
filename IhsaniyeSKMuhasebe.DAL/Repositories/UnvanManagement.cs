using IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities;
using IhsaniyeSKMuhasebe.Entity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.Repositories
{
   public class UnvanManagement:IUnvan
    {
        IhsaniyeSKContext _db;

        public UnvanManagement()
        {
            _db = new IhsaniyeSKContext();
        }


        public void DeleteEntity(int Id)
        {
            Unvan un = (from u in _db.DbUnvan where u.Id == Id select u).First();
            un.AktifMi = false;
            SaveEntity();

        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }

        public int AddEntitiy(Unvan nesne)
        {
            _db.DbUnvan.Add(nesne);
            int id = nesne.Id;
            return id;
        }

        public ICollection<Unvan> GetUnvan()
        {
            ICollection<Unvan> lst = (from un in _db.DbUnvan
                                      where un.AktifMi == true
                                      select un).ToList();
            return lst;
        }
    }
}
