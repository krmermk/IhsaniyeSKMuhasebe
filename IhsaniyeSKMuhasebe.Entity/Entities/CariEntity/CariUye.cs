using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;

namespace IhsaniyeSKMuhasebe.Entity.Entities.CariEntity
{
   public class CariUye
    {
        public int ID { get; set; }
        public string CariAdi { get; set; }
        public int? PersonelID { get; set; }
        public bool? UyeMi { get; set; }
        public string Aciklama { get; set; }
        public DateTime? KurulusTarihi { get; set; }
        public int OlusturanPersonelID { get; set; }
        public bool  AktifMi { get; set; }
        public DateTime OlusuturulmaTarihi { get; set; }

        public virtual Personel NVGPersonel { get; set; }
        public virtual ICollection<CariUyeBanka> NVGCariUyeBanka { get; set; }
        public virtual ICollection<KasaIslem> NVGKasaIslem { get; set; }
        public virtual ICollection<CariUyeBilgileri> NVGCariUyeBilgileri { get; set; }
    }
}
