using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.Entity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
   public class PersonelIseGirisCikisController
    {
       PersonelIseGirisCikisManagement _pigcm;
       public PersonelIseGirisCikisController()
       {
           _pigcm = new PersonelIseGirisCikisManagement();
       }

       public PersonelIseGirisCikis IseGirisCikisGetir(int personelId)
       {
           return _pigcm.GetPersonelIseGirisCikis(personelId);
       }

       public void IseGirisCikisEkle(PersonelIseGirisCikis iseGirisCikis)
       {
          _pigcm.AddEntitiy(iseGirisCikis);
       }

       public void IseGirisCikisSil(PersonelIseGirisCikis iseGirisCikis)
       {
           _pigcm.DeleteEntity(iseGirisCikis.Id);
       }
       public void IseGiricCikisGuncelle(PersonelIseGirisCikis iseGirisCikis)
       {
           _pigcm.PersonelIseGirisCikisGuncelle(iseGirisCikis);
       }
    }
}
