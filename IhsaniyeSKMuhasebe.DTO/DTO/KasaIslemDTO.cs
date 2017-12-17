using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DTO.DTO
{
   public class KasaIslemDTO
    {
        public int ID { get; set; }
        public string HesapIslemTurAdi { get; set; }
        public string CariUyeAdi { get; set; }
        public string OdemeTurAdi { get; set; }
        public double? Miktar { get; set; }
        public DateTime? IslemTarihi { get; set; }
        public string BelgeNo { get; set; }
        public string Aciklama { get; set; }
    }
}
