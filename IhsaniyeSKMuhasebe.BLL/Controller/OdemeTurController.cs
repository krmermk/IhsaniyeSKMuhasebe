using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class OdemeTurController
    {
        OdemeTurManagement _odeme;
        public OdemeTurController()
        {
            _odeme = new OdemeTurManagement();
        }
        public string OdemeTurEkle(OdemeTuru odeme)
        {
            try
            {
                _odeme.AddEntitiy(odeme);
                return "İşlem Başarılı";
            }
            catch (Exception)
            {
                return "İşlem Başarısız ";
            }
        }
        public string OdemeTurSil(int ID)
        {
            try
            {
                _odeme.DeleteEntity(ID);
                return "İşlem Başarılı";
            }
            catch (Exception)
            {
                return "İşlem Başarısız";
            }

        }
        public ICollection<OdemeTuru> OdemeTurGetir()
        {
            return _odeme.GetEntities().ToList();
        }
        public bool OdemeTurGuncelle(OdemeTuru nesne)
        {
            try
            {
                _odeme.SaveEntity();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
