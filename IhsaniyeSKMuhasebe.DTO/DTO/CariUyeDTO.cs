using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DTO.DTO
{
    public class CariUyeDTO
    {
        public int CariUyeID { get; set; }
        public string CariUyeAdi { get; set; }
        public DateTime? KurulusTarihi { get; set; }
        public string  Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
        public int? BankaID { get; set; }
        public string BankaAdi { get; set; }
        public string HesapNo { get; set; }
        public string IBAN { get; set; }
        public int? OlusturdanPersonelID { get; set; }
    }
}
