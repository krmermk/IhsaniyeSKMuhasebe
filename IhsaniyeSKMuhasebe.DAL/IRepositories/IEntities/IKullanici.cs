using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface IKullanici : IAdd<Kullanici>, IDelete<Kullanici>, ISave
    {
        ICollection<Kullanici> GetKullanici();
        ICollection<Personel> KullanicisiOlmayanlar();
    }
}
