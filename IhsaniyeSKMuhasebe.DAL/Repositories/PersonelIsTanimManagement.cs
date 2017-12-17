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
    public class PersonelIsTanimManagement : IPersonelIsTanim
    {
        IhsaniyeSKContext _db;

        public PersonelIsTanimManagement()
        {
            _db = new IhsaniyeSKContext();
        }

        public void DeleteEntity(int Id)
        {
            PersonelIsTanim personelIsTanim = (from pit in _db.DbPersonelIsTanim where pit.PersonelId == Id && pit.AktifMi == true select pit).First();
            personelIsTanim.AktifMi = false;
            SaveEntity();
        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }

        public int AddEntitiy(PersonelIsTanim nesne)
        {
            _db.DbPersonelIsTanim.Add(nesne);
            SaveEntity();
            int id = nesne.Id;
            return id;
        }

        public void PersonelIsTanimGuncelle(PersonelIsTanim nesne)
        {
            PersonelIsTanim temp = new PersonelIsTanim();
            temp = (from pit in _db.DbPersonelIsTanim
                    where pit.AktifMi == true && pit.PersonelId == nesne.PersonelId
                    select pit).FirstOrDefault();
            DeleteEntity(temp.Id);
            AddEntitiy(nesne);
            SaveEntity();
        }
    }
}
