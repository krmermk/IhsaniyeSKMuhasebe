using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface ICariUyeBilgileri : IAdd<CariUyeBilgileri>, IDelete<CariUyeBilgileri>, ISave
    {
        void BilgileriGuncelle(CariUyeBilgileri nesne);
    }
}
