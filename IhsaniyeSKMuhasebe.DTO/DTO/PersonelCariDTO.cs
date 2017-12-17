using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DTO.DTO
{
    public class PersonelCariDTO
    {
        public int? PersonelID { get; set; }
        public string TCNo { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }


        
        public Unvan Unvani { get; set; }
        public Departman Departmani { get; set; }
        public string MaasMiktar { get; set; }
        public Personel Yoneticisi { get; set; }
        public string Aciklama { get; set; }
        public string CariAdi { get; set; }
        public bool UyeMi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public BankaTanim Bankasi { get; set; }
        public string HesapNo { get; set; }
        public string IBAN { get; set; }
        public string BankaAdi { get; set; }

        public int OlusturanPersonelID { get; set; }
        public bool AktifMi { get; set; }
        public DateTime OlusturlmaTarihi { get; set; }

    }
}
