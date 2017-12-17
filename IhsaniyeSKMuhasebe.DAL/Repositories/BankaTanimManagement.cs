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
    public class BankaTanimManagement : IBankaEntity
    {
        IhsaniyeSKContext _db;
        public BankaTanimManagement()
        {
            _db = new IhsaniyeSKContext();
        }

      

        public void DeleteEntity(int Id)
        {
            BankaTanim bt = (from b in _db.DbBankaTanim where b.ID == Id select b).First();
            bt.AktifMi = false;
            SaveEntity();
        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }



        public int AddEntitiy(BankaTanim nesne)
        {
            _db.DbBankaTanim.Add(nesne);
            int BankaID = nesne.ID;
            return BankaID;
        }

        public ICollection<BankaTanim> GetBanka()
        {
            return (from b in _db.DbBankaTanim where b.AktifMi == true select b).ToList();
        }

    }
}
