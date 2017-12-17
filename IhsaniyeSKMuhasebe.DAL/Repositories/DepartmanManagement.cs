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
    public class DepartmanManagement : IDepartman
    {
        IhsaniyeSKContext _db;
        public DepartmanManagement()
        {
            _db = new IhsaniyeSKContext();
        }



        public void DeleteEntity(int Id)
        {
            Departman temp = (from tablo in _db.DbDepartman where tablo.Id == Id select tablo).First();
            temp.AktifMi = false;
            SaveEntity();


        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }

        public int AddEntitiy(Departman nesne)
        {
            _db.DbDepartman.Add(nesne);
            SaveEntity();
            int id = nesne.Id;
            return id;
        }



        public ICollection<Departman> GetDepartman()
        {
            return (from d in _db.DbDepartman where d.AktifMi == true select d).ToList();
        }
    }
}
