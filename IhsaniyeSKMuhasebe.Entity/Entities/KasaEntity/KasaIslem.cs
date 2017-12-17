using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;

namespace IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity
{
   public class KasaIslem
    {
        public int ID { get; set; }
        public int HesapIslemID { get; set; }
        public int CariUyeID { get; set; }
        public int OdemeID { get; set; }
        public double Miktar { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string ReferansBelgeNo { get; set; }
        public string Aciklama { get; set; }
        public int OlusturanPersonelID { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusturlmaTarihi { get; set; }

        public virtual HesapIslemTur NVGHesapIslemTur { get; set; }
        public virtual CariUye NVGCariUye { get; set; }
        public virtual OdemeTuru NVGOdemeTuru { get; set; }

    }
}
