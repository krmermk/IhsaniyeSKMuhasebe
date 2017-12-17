using IhsaniyeSKMuhasebe.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IDto
{
    interface IKasaIslemRaporDto
    {
        ICollection<KasaIslemRaporDTO> GetKasaIslemRapor(int hesapIslemTurId,int yil);
        ICollection<int> IslemYapilanYillar(int hesapIslemTurId);
    }
}
