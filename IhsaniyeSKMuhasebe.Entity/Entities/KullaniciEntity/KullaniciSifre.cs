using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity
{
    public class KullaniciSifre
    {
        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public string Sifre { get; set; }
        public int OlusturanPersonelID { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }

        public virtual Kullanici NVGKullanici { get; set; }
    }
}
