using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity
{
    public class Personel
    {

        public int Id { get; set; }
        public string TcNo { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return this.PersonelAdi+" "+this.PersonelSoyadi;
            }
        }

        public DateTime DogumTarihi { get; set; }
        public int OlusturanPersonelId { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }

        public virtual ICollection<PersonelIsTanim> NVGPersonelIsTanim { get; set; }
        public virtual ICollection<PersonelIsTanim> NVGPersonelIsTanim2 { get; set; }
        public virtual ICollection<CariUye> NVGCariUye { get; set; }
        public virtual ICollection<Kullanici> NVGKullanici { get; set; }

        public virtual ICollection<PersonelIseGirisCikis> NVGPersonelIseGirisCikis { get; set; }


    }
}
