using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface ICariUyeBanka : IAdd<CariUyeBanka>, IDelete<CariUyeBanka>, ISave
    {
        void BankaBilgileriGuncelle(CariUyeBanka nesne);
    }
}
