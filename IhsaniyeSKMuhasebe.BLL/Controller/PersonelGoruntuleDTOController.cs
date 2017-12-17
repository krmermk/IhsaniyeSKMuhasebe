using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using IhsaniyeSKMuhasebe.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class PersonelGoruntuleDTOController
    {
        CariUyeManagement _cm;
        CariUyeBilgileriManagement _cubm;
        PersonelIsTanimManagement _pitm;
        PersonelManagement _pm;

        public PersonelGoruntuleDTOController()
        {
            _cm = new CariUyeManagement();
            _cubm = new CariUyeBilgileriManagement();
            _pitm = new PersonelIsTanimManagement();
            _pm = new PersonelManagement();
        }

        public ICollection<PersonelGoruntuleDTO> GetPersonelGoruntuleDTO()
        {
            return _pm.GetPersonelGoruntuleDTO();
        }
        public ICollection<PersonelGoruntuleDTO> GetPersonelGoruntuleDTO(string isim)
        {
            return _pm.GetPersonelGoruntuleDTO(isim);
        }

        public string Guncelle(PersonelGoruntuleDTO eskiNesne, PersonelGoruntuleDTO yeniNesne)
        {
            PersonelGoruntuleDTO pgDTO = new PersonelGoruntuleDTO();
            PersonelIsTanim personelIsTanim = new PersonelIsTanim();
            CariUye cariUye = new CariUye();
            Personel pers = new Personel();
            CariUyeBilgileri cariUyeBilgileri = new CariUyeBilgileri();
            string mesaj = "";
            if (eskiNesne.Adi != yeniNesne.Adi || eskiNesne.Soyadi != yeniNesne.Soyadi || eskiNesne.TCNO != yeniNesne.TCNO || eskiNesne.DogumTarihi != yeniNesne.DogumTarihi)
            {
                if (Helper.NullableControl(yeniNesne.Adi, yeniNesne.Soyadi) && yeniNesne.DogumTarihi != null)
                {
                    try
                    {
                        pers.Id = yeniNesne.PersonelID;
                        pers.PersonelAdi = yeniNesne.Adi;
                        pers.PersonelSoyadi = yeniNesne.Soyadi;
                        pers.DogumTarihi = yeniNesne.DogumTarihi;
                        pers.TcNo = yeniNesne.TCNO;
                        pers.AktifMi = true;
                        pers.OlusturulmaTarihi = DateTime.Now;
                        pers.OlusturanPersonelId = (int)yeniNesne.OlusturanPersonelID;
                        _pm.PersonelGuncelle(pers);
                        

                        cariUye.ID = (int)eskiNesne.CariUyeID;
                        cariUye.CariAdi = yeniNesne.Adi + " " + yeniNesne.Soyadi;
                        cariUye.Aciklama = yeniNesne.GorevAciklamasi;
                        cariUye.OlusuturulmaTarihi = DateTime.Now;
                        cariUye.AktifMi = true;
                        cariUye.PersonelID = yeniNesne.PersonelID;
                        _cm.CariGuncelle(cariUye);
                        mesaj += "Personel özel bilgileri güncellendi. ";
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        mesaj += "Personel özel bilgiler güncellenemedi. ";
                    }

                }
                else
                {
                    mesaj += "Personel özel bilgiler güncellenemedi. ";
                }
            }

            if (eskiNesne.EMail != yeniNesne.EMail || eskiNesne.Telefon != yeniNesne.Telefon || eskiNesne.Adres != yeniNesne.Adres)
            {
                try
                {
                    cariUyeBilgileri.CariUyeID = (int)eskiNesne.CariUyeID;
                    cariUyeBilgileri.Email = yeniNesne.EMail;
                    cariUyeBilgileri.Telefon = yeniNesne.Telefon;
                    cariUyeBilgileri.Adres = yeniNesne.Adres;
                    cariUyeBilgileri.AktifMi = true;
                    cariUyeBilgileri.OlusuturulmaTarihi = DateTime.Now;
                    cariUyeBilgileri.OlusturanPersonelID = (int)yeniNesne.OlusturanPersonelID;
                    _cubm.BilgileriGuncelle(cariUyeBilgileri);
                    mesaj += "Şirket iletişim bilgileri güncellendi. ";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    mesaj += "Şirket iletişim bilgileri güncellenemedi. ";
                }

            }

            if ((eskiNesne.UnvanID != yeniNesne.UnvanID || eskiNesne.YoneticiID != yeniNesne.YoneticiID || eskiNesne.DepartmanID != yeniNesne.DepartmanID) && (yeniNesne.UnvanID != null && yeniNesne.DepartmanID != null && yeniNesne.YoneticiID != null))
            {
                try
                {
                    personelIsTanim.PersonelId = eskiNesne.PersonelID;
                    personelIsTanim.UnvanId = (int)yeniNesne.UnvanID;
                    personelIsTanim.YoneticiId = yeniNesne.YoneticiID;
                    personelIsTanim.DepartmanId = (int)yeniNesne.DepartmanID;
                    personelIsTanim.MaasMiktar = yeniNesne.Maas;
                    personelIsTanim.Aciklama = yeniNesne.GorevAciklamasi;
                    personelIsTanim.OlusturanPersonelId = (int)yeniNesne.OlusturanPersonelID;
                    personelIsTanim.OlusturulmaTarihi = DateTime.Now;
                    personelIsTanim.AktifMi = true;
                    _pitm.PersonelIsTanimGuncelle(personelIsTanim);
                    mesaj += "Personel iş bilgileri güncellendi.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    mesaj += "Personel iş bilgileri güncellenemedi.";
                }


            }
            else
            {
                mesaj += "İş bilgileri güncellenemedi.";
            }

            return mesaj;
        }
    }
}
