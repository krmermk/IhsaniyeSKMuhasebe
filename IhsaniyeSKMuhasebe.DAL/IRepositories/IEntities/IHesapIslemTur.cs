using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface IHesapIslemTur:IAdd<HesapIslemTur>,IDelete<HesapIslemTur>,ISave
    {
    }
}
