using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Entities.CariEntity
{
   public class CariUyeBilgileri
    {
       public int ID { get; set; }
       public int CariUyeID { get; set; }
       public string Email { get; set; }
       public string Telefon { get; set; }
       public string Adres { get; set; }
        public int OlusturanPersonelID { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusuturulmaTarihi { get; set; }
        public virtual  CariUye NVGCariUye { get; set; }
    }
}
