using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity
{
    public class PersonelIsTanim
    {


        public int Id { get; set; }
        public int PersonelId { get; set; }
        public int UnvanId { get; set; }
        public int DepartmanId { get; set; }
        public decimal? MaasMiktar { get; set; }
        public int? YoneticiId { get; set; }
        public string Aciklama { get; set; }
        public int OlusturanPersonelId { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }

        public virtual Personel NVGPersonel { get; set; }
        public virtual Personel NVGPersonel2 { get; set; }
        public virtual Unvan NVGUnvan { get; set; }
        public virtual Departman NVGDepartman { get; set; }
    }
}
