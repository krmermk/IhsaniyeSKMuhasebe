using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DTO.DTO
{
    public class KasaIslemRaporDTO
    {
        public int KasaIslemId { get; set; }
        public int CariUyeId { get; set; }
        public string CariUyeAdi { get; set; }
        public int? PersonelId { get; set; }
        public string PersonelAdi { get; set; }
        public int HesapIslemTurId { get; set; }
        public double? Miktar { get; set; }
        public string IslemYapilanAy { get; set; }
        public DateTime IslemTarihi { get; set; }
        public int IslemYapilanAyIndex { get; set; }

    }
}
