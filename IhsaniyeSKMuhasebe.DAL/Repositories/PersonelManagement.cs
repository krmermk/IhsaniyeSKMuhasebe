using IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.Repositories
{
    public class PersonelManagement : IPersonel
    {
        IhsaniyeSKContext _db;

        public PersonelManagement()
        {
            _db = new IhsaniyeSKContext();
        }


        public void DeleteEntity(int Id)
        {
            Personel personel = new Personel();
            personel = (from p in _db.DbPersonel where p.Id == Id select p).First();
            personel.AktifMi = false;
            SaveEntity();
        }

        public void SaveEntity()
        {
            _db.SaveChanges();
        }

        public int AddEntitiy(Personel nesne)
        {
            _db.DbPersonel.Add(nesne);
            SaveEntity();
            int id = nesne.Id;
            return id;
        }

        public ICollection<Personel> GetPersonel(bool aktifMi)
        {
            return (from p in _db.DbPersonel where p.AktifMi == aktifMi select p).ToList();
        }


        public void PersonelGuncelle(Personel nesne)
        {
            Personel temp = new Personel();
            temp = (from p in _db.DbPersonel
                    where p.Id == nesne.Id
                    select p).FirstOrDefault();
            temp.PersonelAdi = nesne.PersonelAdi;
            temp.PersonelSoyadi = nesne.PersonelSoyadi;
            temp.TcNo = temp.TcNo;
            temp.OlusturulmaTarihi = DateTime.Now;
            temp.OlusturanPersonelId = nesne.OlusturanPersonelId;
            temp.DogumTarihi = nesne.DogumTarihi;
            temp.AktifMi = nesne.AktifMi;
            SaveEntity();
        }


        public ICollection<PersonelGoruntuleDTO> GetPersonelGoruntuleDTO()
        {
            List<PersonelGoruntuleDTO> lst = new List<PersonelGoruntuleDTO>();
            lst = (from personel in _db.DbPersonel
                   join cariUye in _db.DbCariUye on personel.Id equals cariUye.PersonelID
                   join cbilgi in _db.DbCariUyeBilgileri on cariUye.ID equals cbilgi.CariUyeID into temp1
                   from t1 in temp1.DefaultIfEmpty()
                   join istanim in _db.DbPersonelIsTanim on personel.Id equals istanim.PersonelId into temp2
                   from t2 in temp2.DefaultIfEmpty()
                   join unvan in _db.DbUnvan on t2.UnvanId equals unvan.Id
                   join departman in _db.DbDepartman on t2.DepartmanId equals departman.Id
                   join pers2 in _db.DbPersonel on t2.YoneticiId equals pers2.Id into temp3
                   from t3 in temp3.DefaultIfEmpty()
                   where personel.AktifMi == true && cariUye.AktifMi == true && t2.AktifMi != false && t1.AktifMi != false && t3.AktifMi != false
                   select new PersonelGoruntuleDTO
                   {
                       PersonelID = personel.Id,
                       TCNO = personel.TcNo,
                       Adi = personel.PersonelAdi,
                       Soyadi = personel.PersonelSoyadi,
                       DogumTarihi = personel.DogumTarihi,
                       EMail = t1.Email,
                       Telefon = t1.Telefon,
                       Adres = t1.Adres,
                       UnvanAdi = unvan.GorevAdi,
                       DepartmanAdi = departman.DepartmanAdi,
                       YoneticiAdi = t3.PersonelAdi + " " + t3.PersonelSoyadi,
                       Maas = t2.MaasMiktar,
                       GorevAciklamasi = t2.Aciklama,
                       UnvanID = t2.UnvanId,
                       DepartmanID = t2.DepartmanId,
                       YoneticiID = t2.YoneticiId,
                       CariUyeID = cariUye.ID,
                       OlusturanPersonelID = cariUye.OlusturanPersonelID
                   }).ToList();
            return lst;
        }

        public ICollection<PersonelGoruntuleDTO> GetPersonelGoruntuleDTO(string isim)
        {
            List<PersonelGoruntuleDTO> lst = new List<PersonelGoruntuleDTO>();
            lst = (from personel in _db.DbPersonel
                   join cariUye in _db.DbCariUye on personel.Id equals cariUye.PersonelID
                   join cbilgi in _db.DbCariUyeBilgileri on cariUye.ID equals cbilgi.CariUyeID into temp1
                   from t1 in temp1.DefaultIfEmpty()
                   join istanim in _db.DbPersonelIsTanim on personel.Id equals istanim.PersonelId into temp2
                   from t2 in temp2.DefaultIfEmpty()
                   join unvan in _db.DbUnvan on t2.UnvanId equals unvan.Id
                   join departman in _db.DbDepartman on t2.DepartmanId equals departman.Id
                   join pers2 in _db.DbPersonel on t2.YoneticiId equals pers2.Id into temp3
                   from t3 in temp3.DefaultIfEmpty()
                   where personel.AktifMi == true && cariUye.AktifMi == true && t2.AktifMi != false && t1.AktifMi != false && t3.AktifMi != false && personel.PersonelAdi.Contains(isim)
                   
                   select new PersonelGoruntuleDTO
                   {
                       PersonelID = personel.Id,
                       TCNO = personel.TcNo,
                       Adi = personel.PersonelAdi,
                       Soyadi = personel.PersonelSoyadi,
                       DogumTarihi = personel.DogumTarihi,
                       EMail = t1.Email,
                       Telefon = t1.Telefon,
                       Adres = t1.Adres,
                       UnvanAdi = unvan.GorevAdi,
                       DepartmanAdi = departman.DepartmanAdi,
                       YoneticiAdi = t3.PersonelAdi,
                       Maas = t2.MaasMiktar,
                       GorevAciklamasi = t2.Aciklama,
                       UnvanID = t2.UnvanId,
                       DepartmanID = t2.DepartmanId,
                       YoneticiID = t2.YoneticiId,
                       CariUyeID = cariUye.ID,
                       OlusturanPersonelID = cariUye.OlusturanPersonelID
                   }).ToList();
            return lst;
        }
    }
}
