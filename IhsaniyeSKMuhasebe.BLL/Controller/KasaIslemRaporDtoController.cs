using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class KasaIslemRaporDtoController
    {
        KasaIslemRaporDtoManagement _kirdm;
        string[] _aylar = new string[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Agustos", "Eylül", "Ekim", "Kasım", "Aralık" };
        public KasaIslemRaporDtoController()
        {
            _kirdm = new KasaIslemRaporDtoManagement();
        }
        public ICollection<KasaIslemRaporDTO> kasaRaporu(int hesapIslemTurId, int yil)
        {
            List<KasaIslemRaporDTO> temp = new List<KasaIslemRaporDTO>();
            KasaIslemRaporDTO bos;
            for (int i = 0; i < 12; i++)
            {
                bos = new KasaIslemRaporDTO();
                bos.IslemYapilanAy = _aylar[i];
                bos.IslemYapilanAyIndex = i;
                temp.Add(bos);
            }
            ICollection<KasaIslemRaporDTO> temp2 = _kirdm.GetKasaIslemRapor(hesapIslemTurId, yil);
            foreach (KasaIslemRaporDTO item in temp2)
            {
                item.IslemYapilanAy = _aylar[item.IslemTarihi.Month - 1];
                item.IslemYapilanAyIndex = item.IslemTarihi.Month - 1;
                temp.Add(item);
            }
            return temp;
        }

        public ICollection<int> IslemYapilanYillar(int hesapIslemTurId)
        {
            return _kirdm.IslemYapilanYillar(hesapIslemTurId);
        }

    }
}
