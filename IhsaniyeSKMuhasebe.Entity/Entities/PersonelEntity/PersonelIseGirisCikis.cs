using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity
{
    public class PersonelIseGirisCikis
    {

        public int Id { get; set; }
        public int PersonelId { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public DateTime? IstenCikmaTarihi { get; set; }

        public int OlusturanPersonelId { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }

        public virtual Personel NVGPersonel { get; set; }
    }
}
