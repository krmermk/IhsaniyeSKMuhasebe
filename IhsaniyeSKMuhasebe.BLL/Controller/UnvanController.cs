using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class UnvanController
    {
        UnvanManagement _unvan;
        public UnvanController()
        {
            _unvan = new UnvanManagement();
        }
        public void UnvanEkle(Unvan nesne)
        {
            _unvan.AddEntitiy(nesne);
            _unvan.SaveEntity();
        }
        public ICollection<Unvan> GetUnvan()
        {
            return _unvan.GetUnvan();
        }

        public void DeleteUnvan(int ID)
        {
            _unvan.DeleteEntity(ID);
        }

        public bool UpdateUnvan(Unvan nesne)
        {
            if (nesne != null)
            {
                _unvan.SaveEntity();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
