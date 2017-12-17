using IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.Repositories
{
    public class CariUyeManagement : ICariUye
    {
        IhsaniyeSKContext _db;
        public CariUyeManagement()
        {
            _db = new IhsaniyeSKContext();
        }
        public int AddEntitiy(CariUye nesne)
        {
            _db.DbCariUye.Add(nesne);
            SaveEntity();
            int CariUyeID = nesne.ID;
            return CariUyeID;
        }

        public void DeleteEntity(int Id)
        {
            CariUye temp = (from tablo in _db.DbCariUye where tablo.ID == Id select tablo).First();
            temp.AktifMi = false;
            SaveEntity();

        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }
        public ICollection<CariUye> GetEntities()
        {
            List<CariUye> lst = new List<CariUye>();
            lst = (from cariUye in _db.DbCariUye
                   where cariUye.AktifMi == true
                   select cariUye).ToList();
            return lst;
        }

        public ICollection<CariUye> GetUyeOlanlar()
        {
            List<CariUye> lst = new List<CariUye>();
            lst = (from cariUye in _db.DbCariUye
                   where cariUye.AktifMi == true && cariUye.UyeMi == true
                   select cariUye).ToList();
            return lst;
        }

        public ICollection<CariUye> GetUyeOlmayanlar()
        {
            List<CariUye> lst = new List<CariUye>();
            lst = (from cariUye in _db.DbCariUye
                   where cariUye.AktifMi == true && cariUye.UyeMi == false
                   select cariUye).ToList();
            return lst;
        }

        public void UyelikIslemi(CariUye _cari, bool _islem)
        {
            _cari.UyeMi = _islem;
            SaveEntity();
        }
         
        public ICollection<CariUyeDTO> GetUyeOlanlarDTO(string isim)
        {
            List<CariUyeDTO> lst = new List<CariUyeDTO>();
            lst = (from cariUye in _db.DbCariUye
                   join cbilgi in _db.DbCariUyeBilgileri on cariUye.ID equals cbilgi.CariUyeID into temp1
                   from t1 in temp1.DefaultIfEmpty()
                   join cbanka in _db.DbCariUyeBanka on cariUye.ID equals cbanka.CariUyeID into temp2
                   from t2 in temp2.DefaultIfEmpty()
                   join banka in _db.DbBankaTanim on t2.BankaID equals banka.ID
                   where cariUye.AktifMi == true && cariUye.UyeMi == true && t1.AktifMi != false && banka.AktifMi != false && t2.AktifMi != false && cariUye.CariAdi.Contains(isim) && cariUye.PersonelID==null
                   select new CariUyeDTO
                   {
                       CariUyeID = cariUye.ID,
                       CariUyeAdi = cariUye.CariAdi,
                       KurulusTarihi = (DateTime)cariUye.KurulusTarihi,
                       Telefon = t1.Telefon,
                       Email = t1.Email,
                       Adres = t1.Adres,
                       Aciklama = cariUye.Aciklama,
                       BankaID = t2.BankaID,
                       HesapNo = t2.HesapNo,
                       IBAN = t2.IBAN,
                       BankaAdi = banka.BankaAdi,
                       OlusturdanPersonelID = cariUye.OlusturanPersonelID
                   }).ToList();
            return lst;
        }

        public ICollection<CariUyeDTO> GetUyeOlanlarDTO()
        {
            List<CariUyeDTO> lst = new List<CariUyeDTO>();
            lst = (from cariUye in _db.DbCariUye
                   join cbilgi in _db.DbCariUyeBilgileri on cariUye.ID equals cbilgi.CariUyeID into temp1
                   from t1 in temp1.DefaultIfEmpty()
                   join cbanka in _db.DbCariUyeBanka on cariUye.ID equals cbanka.CariUyeID into temp2
                   from t2 in temp2.DefaultIfEmpty()
                   join banka in _db.DbBankaTanim on t2.BankaID equals banka.ID
                   where cariUye.AktifMi == true && cariUye.UyeMi == true && t1.AktifMi != false && t2.AktifMi != false && banka.AktifMi != false && cariUye.PersonelID == null
                   select new CariUyeDTO
                   {
                       CariUyeID = cariUye.ID,
                       CariUyeAdi = cariUye.CariAdi,
                       KurulusTarihi = (DateTime)cariUye.KurulusTarihi,
                       Telefon = t1.Telefon,
                       Email = t1.Email,
                       Adres = t1.Adres,
                       Aciklama = cariUye.Aciklama,
                       BankaID = t2.BankaID,
                       HesapNo = t2.HesapNo,
                       IBAN = t2.IBAN,
                       BankaAdi = banka.BankaAdi,
                       OlusturdanPersonelID = cariUye.OlusturanPersonelID
                   }).ToList();
            return lst;
        }

        public ICollection<CariUyeDTO> GetCariDTO()
        {
            List<CariUyeDTO> lst = new List<CariUyeDTO>();
            lst = (from cariUye in _db.DbCariUye
                   join cbilgi in _db.DbCariUyeBilgileri on cariUye.ID equals cbilgi.CariUyeID into temp1
                   from t1 in temp1.DefaultIfEmpty()
                   join cbanka in _db.DbCariUyeBanka on cariUye.ID equals cbanka.CariUyeID into temp2
                   from t2 in temp2.DefaultIfEmpty()
                   join banka in _db.DbBankaTanim on t2.BankaID equals banka.ID   into temp3
                   from t3 in temp3.DefaultIfEmpty()
                   where cariUye.AktifMi == true && t1.AktifMi != false && t2.AktifMi != false
                   select new CariUyeDTO
                   {
                       CariUyeID = cariUye.ID,
                       CariUyeAdi = cariUye.CariAdi,
                       KurulusTarihi = cariUye.KurulusTarihi,
                       Telefon = t1.Telefon,
                       Email = t1.Email,
                       Adres = t1.Adres,
                       Aciklama = cariUye.Aciklama,
                       BankaID = t2.BankaID,
                       HesapNo = t2.HesapNo,
                       IBAN = t2.IBAN,
                       BankaAdi = t3.BankaAdi,
                       OlusturdanPersonelID = cariUye.OlusturanPersonelID
                   }).ToList();
            return lst;
        }

        public ICollection<CariUyeDTO> GetCariDTO(string isim)
        {
            List<CariUyeDTO> lst = new List<CariUyeDTO>();
            lst = (from cariUye in _db.DbCariUye
                   join cbilgi in _db.DbCariUyeBilgileri on cariUye.ID equals cbilgi.CariUyeID into temp1
                   from t1 in temp1.DefaultIfEmpty()
                   join cbanka in _db.DbCariUyeBanka on cariUye.ID equals cbanka.CariUyeID into temp2
                   from t2 in temp2.DefaultIfEmpty()
                   join banka in _db.DbBankaTanim on t2.BankaID equals banka.ID into temp3
                   from t3 in temp3.DefaultIfEmpty()
                   where cariUye.AktifMi == true && t1.AktifMi != false && t3.AktifMi != false && t2.AktifMi != false && cariUye.CariAdi.Contains(isim)
                   select new CariUyeDTO
                   {
                       CariUyeID = cariUye.ID,
                       CariUyeAdi = cariUye.CariAdi,
                       KurulusTarihi = (DateTime)cariUye.KurulusTarihi,
                       Telefon = t1.Telefon,
                       Email = t1.Email,
                       Adres = t1.Adres,
                       Aciklama = cariUye.Aciklama,
                       BankaID = t2.BankaID,
                       HesapNo = t2.HesapNo,
                       IBAN = t2.IBAN,
                       BankaAdi = t3.BankaAdi,
                       OlusturdanPersonelID = cariUye.OlusturanPersonelID
                   }).ToList();
            return lst;
        }

        public void CariGuncelle(CariUye nesne)
        {
            CariUye temp = new CariUye();
            temp = (from c in _db.DbCariUye
                    where c.ID==nesne.ID
                    select c).FirstOrDefault();
            temp.CariAdi = nesne.CariAdi;
            temp.OlusuturulmaTarihi = nesne.OlusuturulmaTarihi;
            temp.OlusturanPersonelID = nesne.OlusturanPersonelID;
            temp.KurulusTarihi = nesne.KurulusTarihi;
            temp.Aciklama = nesne.Aciklama;
            SaveEntity();
        }
    }
}
