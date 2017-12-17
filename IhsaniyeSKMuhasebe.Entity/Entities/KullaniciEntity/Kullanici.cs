using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;

namespace IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public int PersonelID { get; set; }
        public string KullaniciAdi { get; set; }
        public int OlusturanPersonelID { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }

        public virtual Personel NVGPersonel { get; set; }
        public virtual ICollection<KullaniciSifre> NVGKullaniciSifre { get; set; }

    }
}
