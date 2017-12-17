using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface IPersonelIsTanim:IAdd<PersonelIsTanim>,IDelete<PersonelIsTanim>,ISave
    {
        void PersonelIsTanimGuncelle(PersonelIsTanim nesne);
    }
}
