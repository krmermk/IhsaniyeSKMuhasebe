using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Entities.CariEntity
{
   public class BankaTanim
    {
        public int ID { get; set; }
        public string BankaAdi { get; set; }
        public int OlusturanPersonelID { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusuturulmaTarihi { get; set; }
        public ICollection<CariUyeBanka> NVGCariUyeBanka { get; set; }
    }
}
