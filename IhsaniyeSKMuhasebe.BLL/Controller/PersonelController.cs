using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class PersonelController
    {
        PersonelManagement _pm;
        KullaniciController _kc;
        PersonelIsTanimController _pitc;
        public PersonelController()
        {
            _pm = new PersonelManagement();
            _kc = new KullaniciController();
            _pitc = new PersonelIsTanimController();
        }
        public ICollection<Personel> AktifPersonelleriGetir()
        {
            return _pm.GetPersonel(true);
        }

        public ICollection<Personel> PasifPersonelleriGetir()
        {
            return _pm.GetPersonel(false);
        }

        public void DeletePersonel(int ID)
        {
            _pm.DeleteEntity(ID);
            _kc.DeleteKullanici(ID);
            _pitc.DeleteIstanim(ID);
        }

        public void PersonelGuncelle(Personel personel)
        {
            _pm.PersonelGuncelle(personel);
        }
    }
}
