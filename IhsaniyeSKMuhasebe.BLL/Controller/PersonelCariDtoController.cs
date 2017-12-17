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

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class PersonelCariDtoController
    {
        PersonelManagement _pm;
        PersonelIsTanimManagement _pitm;
        CariUyeManagement _cm;
        CariUyeBilgileriManagement _cubm;
        CariUyeBankaManagement _cbanka;
        PersonelIseGirisCikisController _personelIseGirisCikisC;
        public PersonelCariDtoController()
        {
            _pm = new PersonelManagement();
            _pitm = new PersonelIsTanimManagement();
            _cm = new CariUyeManagement();
            _cubm = new CariUyeBilgileriManagement();
            _cbanka = new CariUyeBankaManagement();
            _personelIseGirisCikisC = new PersonelIseGirisCikisController();
        }
        public string KayitEkle(PersonelCariDTO pcDto)
        {
            Personel personel = new Personel();
            CariUye cariUye = new CariUye();
            PersonelIsTanim personelIsTanim = new PersonelIsTanim();
            CariUyeBilgileri cariUyeBilgileri = new CariUyeBilgileri();
            CariUyeBanka cariUyeBanka = new CariUyeBanka();
            PersonelIseGirisCikis personelIseGirisCikis = new PersonelIseGirisCikis();
            DateTime olusturulmaTarihi = DateTime.Now;
            string mesaj = "Personel bilgileri kaydedilmiştir.Personelin sistemde aktif olabilmesi için Personel Giriş Çıkış ekranında personelin işe giriş tarihi girilmelidir. \n";
            string bosHane = "Alttaki alanlarda boş girilmiş haneler bulunmaktadır. Bu haneleri Personel Görüntüleme ekranından güncelleyebilirsiniz.\n\n";
            bool bosHaneVar = false;

            if (Helper.NullableControl(pcDto.PersonelAdi, pcDto.PersonelSoyadi, pcDto.DogumTarihi.ToString()))
            {
                try
                {
                    personel.PersonelAdi = pcDto.PersonelAdi;
                    personel.PersonelSoyadi = pcDto.PersonelSoyadi;
                    personel.DogumTarihi = pcDto.DogumTarihi;
                    personel.TcNo = pcDto.TCNo;
                    personel.OlusturanPersonelId = pcDto.OlusturanPersonelID;
                    personel.AktifMi = true;
                    personel.OlusturulmaTarihi = olusturulmaTarihi;
                    pcDto.PersonelID = _pm.AddEntitiy(personel);


                    personelIseGirisCikis.IseBaslamaTarihi = olusturulmaTarihi;
                    personelIseGirisCikis.PersonelId = personel.Id;
                    personelIseGirisCikis.OlusturulmaTarihi = DateTime.Now;
                    personelIseGirisCikis.OlusturanPersonelId = pcDto.OlusturanPersonelID;
                    personelIseGirisCikis.AktifMi = true;
                    _personelIseGirisCikisC.IseGirisCikisEkle(personelIseGirisCikis);

                    cariUye.CariAdi = pcDto.PersonelAdi + " " + pcDto.PersonelSoyadi;
                    cariUye.PersonelID = (int)pcDto.PersonelID;
                    cariUye.UyeMi = false;
                    cariUye.Aciklama = null;
                    cariUye.KurulusTarihi = null;
                    cariUye.OlusturanPersonelID = pcDto.OlusturanPersonelID;
                    cariUye.AktifMi = true;
                    cariUye.OlusuturulmaTarihi = olusturulmaTarihi;
                    int cariUyeId = _cm.AddEntitiy(cariUye);

                    if (!(pcDto.Unvani == null || pcDto.Departmani == null))
                    {
                        personelIsTanim.PersonelId = (int)pcDto.PersonelID;
                        personelIsTanim.UnvanId = pcDto.Unvani.Id;
                        if (pcDto.Yoneticisi == null)
                        {
                            personelIsTanim.YoneticiId = null;
                        }
                        else
                        {
                            personelIsTanim.YoneticiId = pcDto.Yoneticisi.Id;
                        }
                        personelIsTanim.DepartmanId = pcDto.Departmani.Id;
                        if (!string.IsNullOrEmpty(pcDto.MaasMiktar))
                        {
                            personelIsTanim.MaasMiktar = Convert.ToDecimal(pcDto.MaasMiktar);
                        }
                        else
                        {
                            personelIsTanim.MaasMiktar = null;
                        }
                        personelIsTanim.Aciklama = pcDto.Aciklama;
                        personelIsTanim.OlusturanPersonelId = pcDto.OlusturanPersonelID;
                        personelIsTanim.OlusturulmaTarihi = olusturulmaTarihi;
                        personelIsTanim.AktifMi = true;
                        _pitm.AddEntitiy(personelIsTanim);
                    }
                    else
                    {
                        if (bosHaneVar == false)
                        {
                            mesaj = mesaj + bosHane;
                        }
                        bosHaneVar = true;
                        mesaj = mesaj + "-Personel İş Tanım Bilgileri\n";
                    }


                    if (Helper.NullableControl(pcDto.Email + pcDto.Adres))
                    {
                        cariUyeBilgileri.CariUyeID = cariUyeId;
                        cariUyeBilgileri.Email = pcDto.Email;
                        cariUyeBilgileri.Adres = pcDto.Adres;
                        cariUyeBilgileri.Telefon = pcDto.Telefon.ToString();
                        cariUyeBilgileri.OlusturanPersonelID = pcDto.OlusturanPersonelID;
                        cariUyeBilgileri.AktifMi = true;
                        cariUyeBilgileri.OlusuturulmaTarihi = olusturulmaTarihi;
                        _cubm.AddEntitiy(cariUyeBilgileri);
                    }
                    else
                    {
                        if (bosHaneVar == false)
                        {
                            mesaj = mesaj + bosHane;
                        }
                        bosHaneVar = true;
                        mesaj = mesaj + "-Personel İletişim Bilgileri\n";
                    }


                    if (!(pcDto.Bankasi == null || pcDto.HesapNo == null))
                    {
                        cariUyeBanka.CariUyeID = cariUyeId;
                        cariUyeBanka.BankaID = pcDto.Bankasi.ID;
                        cariUyeBanka.HesapNo = pcDto.HesapNo.ToString();
                        cariUyeBanka.IBAN = pcDto.IBAN.ToString();
                        cariUyeBanka.OlusturanPersonelID = pcDto.OlusturanPersonelID;
                        cariUyeBanka.OlusuturulmaTarihi = olusturulmaTarihi;
                        _cbanka.AddEntitiy(cariUyeBanka);
                    }


                    else
                    {
                        if (bosHaneVar == false)
                        {
                            mesaj = mesaj + bosHane;
                        }
                        bosHaneVar = true;
                        mesaj = mesaj + "-Banka Bilgileri\n";
                    }


                }
                catch (Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    mesaj = "Bir hata nedeniyle kayıt yapılamamıştır.";
                }


            }
            else
            {

                mesaj = "Personel bilgilerinde eksik olduğundan kayıt yapılmamıştır.";
            }


            return mesaj;
        }
    }
}
