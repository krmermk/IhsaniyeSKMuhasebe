using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity
{
    public class OdemeTuru
    {
        public int ID { get; set; }
        public string OdemeTuruAdi { get; set; }
        public int OlusturanPersonelID { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusturlmaTarihi { get; set; }

        public virtual ICollection<KasaIslem> NVGKasaIslem { get; set; }
    }
}
