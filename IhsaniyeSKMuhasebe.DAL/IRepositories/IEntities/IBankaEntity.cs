using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface IBankaEntity:IAdd<BankaTanim>,IDelete<BankaTanim>,ISave
    {
        ICollection<BankaTanim> GetBanka();
    }
}
