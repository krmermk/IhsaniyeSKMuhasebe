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
    public class HesapIslemTurManagement : IHesapIslemTur
    {
        IhsaniyeSKContext _db;
        public HesapIslemTurManagement()
        {
            _db = new IhsaniyeSKContext();


        }

        public ICollection<HesapIslemTur> GetEntities()
        {
            ICollection<HesapIslemTur> lst = new List<HesapIslemTur>();
            lst = (from hi in _db.DbHesapIslemTur
                   where hi.AktifMi == true
                   select hi).ToList();
            return lst;
        }

        public int AddEntitiy(HesapIslemTur nesne)
        {
            _db.DbHesapIslemTur.Add(nesne);
            return nesne.ID;

        }

        public void DeleteEntity(int Id)
        {
            HesapIslemTur temp = (from tablo in _db.DbHesapIslemTur where tablo.ID == Id select tablo).First();
            temp.AktifMi = false;
            SaveEntity();
        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }
    }
}
