using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface IDepartman : IAdd<Departman>, IDelete<Departman>, ISave
    {
        ICollection<Departman> GetDepartman();
    }
}
