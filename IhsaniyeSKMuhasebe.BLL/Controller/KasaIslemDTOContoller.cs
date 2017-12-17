using IhsaniyeSKMuhasebe.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.DAL.Repositories;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class KasaIslemDTOContoller
    {
        KasaIslemDTOManagment _kasa;
        public KasaIslemDTOContoller()
        {
            _kasa = new KasaIslemDTOManagment();
        }

        public ICollection<KasaIslemDTO> KasaIslemDTOGetir()
        {
            return _kasa.IslemGetir();
        }


    }
}
