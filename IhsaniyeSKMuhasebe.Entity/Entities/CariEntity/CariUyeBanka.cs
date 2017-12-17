using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Entities.CariEntity
{
    public class CariUyeBanka
    {
        public int ID { get; set; }
        public int CariUyeID { get; set; }
        public int BankaID { get; set; }
        public string HesapNo { get; set; }
        public string IBAN { get; set; }
        public int OlusturanPersonelID { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusuturulmaTarihi { get; set; }
        public virtual CariUye NVGCariUye { get; set; }
        public virtual BankaTanim NVGBankaTanim { get; set; }
    }
}
