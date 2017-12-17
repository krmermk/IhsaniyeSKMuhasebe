using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    
   public class KasaIslemController
    {
       KasaIslemManagement _kasa;
       public KasaIslemController()
       {
           _kasa = new KasaIslemManagement();
       }

       public string KasaIslemEkle(KasaIslem kasa)
       {
           try
           {
               _kasa.AddEntitiy(kasa);
               return "İşlem Başarılı";
           }
           catch (Exception)
           {
               return "İşlem Başarısız";
           }

       }
       public string KasaIslemSil(int ID)
       {
           try
           {
               _kasa.DeleteEntity(ID);
               return "İşlem Başarılı";
           }
           catch (Exception)
           {
               return "İşlem Başarısız";
           }
       }



    }
}
