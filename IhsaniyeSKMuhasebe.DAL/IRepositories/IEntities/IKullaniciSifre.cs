using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface IKullaniciSifre : IAdd<KullaniciSifre>, IDelete<KullaniciSifre>, ISave
    {
        string GetPassword(int ID);
    }
}
