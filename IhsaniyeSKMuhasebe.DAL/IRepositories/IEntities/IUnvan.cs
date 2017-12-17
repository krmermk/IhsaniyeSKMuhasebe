using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface IUnvan:IAdd<Unvan>,IDelete<Unvan>,ISave
    {
        ICollection<Unvan> GetUnvan();
    }
}
