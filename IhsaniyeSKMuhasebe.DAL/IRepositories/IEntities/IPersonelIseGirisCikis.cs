using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface IPersonelIseGirisCikis:IAdd<PersonelIseGirisCikis>,IDelete<PersonelIseGirisCikis>,ISave
    {
        PersonelIseGirisCikis GetPersonelIseGirisCikis(int personelId);
        void PersonelIseGirisCikisGuncelle(PersonelIseGirisCikis personelIseGirisCikis);
    }
}
