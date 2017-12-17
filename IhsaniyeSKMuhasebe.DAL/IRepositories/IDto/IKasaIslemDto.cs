using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IDto
{
    interface IKasaIslemDto
    {
        ICollection<KasaIslemDTO> IslemGetir();
    }
}
