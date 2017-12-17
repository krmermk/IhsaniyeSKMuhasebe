using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity
{
    public class Departman
    {

        public int Id { get; set; }
        public string DepartmanAdi { get; set; }
        public int OlusturanPersonelId { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }

        public virtual ICollection<PersonelIsTanim> NVGPersonelIsTanim { get; set; }
    }
}
