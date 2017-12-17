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
    public class PersonelIseGirisCikisManagement:IPersonelIseGirisCikis
    {
        IhsaniyeSKContext _db;
        public PersonelIseGirisCikisManagement()
        {
            _db = new IhsaniyeSKContext();
        }
        
        
        
        public PersonelIseGirisCikis GetPersonelIseGirisCikis(int personelId)
        {
            return (from t in _db.DbPersonelIseGirisCikis where t.PersonelId == personelId orderby t.Id descending select t).First();
          
        }

        public int AddEntitiy(PersonelIseGirisCikis nesne)
        {
            _db.DbPersonelIseGirisCikis.Add(nesne);
            SaveEntity();
            return nesne.Id;
        }

        public void DeleteEntity(int Id)
        {
            PersonelIseGirisCikis temp = (from tablo in _db.DbPersonelIseGirisCikis where tablo.Id == Id select tablo).First();
            temp.AktifMi = false;
            SaveEntity();
        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }


        public void PersonelIseGirisCikisGuncelle(PersonelIseGirisCikis personelIseGirisCikis)
        {
            SaveEntity();
        }
    }
}
