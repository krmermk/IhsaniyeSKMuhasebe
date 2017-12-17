using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DTO.DTO
{
    public class PersonelGoruntuleDTO
    {
        public int PersonelID { get; set; } //0
        public string TCNO { get; set; } //1
        public string Adi { get; set; } //2
        public string Soyadi { get; set; } //3
        public DateTime DogumTarihi { get; set; } //4
        public string EMail { get; set; } //5
        public string Telefon { get; set; } //6
        public string Adres { get; set; } //7
        public string UnvanAdi { get; set; } //8
        public string DepartmanAdi { get; set; } //9
        public string YoneticiAdi { get; set; } //10
        public decimal? Maas { get; set; } //11
        public string GorevAciklamasi { get; set; } //12
        public int? UnvanID { get; set; } //13
        public int? DepartmanID { get; set; } //14
        public int? YoneticiID { get; set; } //15
        public int? CariUyeID { get; set; } //16
        public int? OlusturanPersonelID { get; set; } //17

    }
}
