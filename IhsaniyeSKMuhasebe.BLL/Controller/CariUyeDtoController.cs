using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.Extension;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class CariUyeDtoController
    {
        CariUyeManagement _cm = new CariUyeManagement();
        CariUyeBilgileriManagement _cubm = new CariUyeBilgileriManagement();
        CariUyeBankaManagement _cbanka = new CariUyeBankaManagement();
        public string[] KayitEkle(CariUyeDTO cuDto)
        {
            CariUye cariUye = new CariUye();
            CariUyeBilgileri cariUyeBilgileri = new CariUyeBilgileri();
            CariUyeBanka cariUyeBanka = new CariUyeBanka();
            DateTime olusturulmaTarihi = DateTime.Now;
            string[] mesaj = new string[0];
            string mesaj1 = "";
            if (Helper.NullableControl(cuDto.CariUyeAdi))
            {
                try
                {
                    cariUye.CariAdi = cuDto.CariUyeAdi;
                    cariUye.PersonelID = null;
                    cariUye.UyeMi = false;
                    cariUye.KurulusTarihi = cuDto.KurulusTarihi;
                    cariUye.Aciklama = cuDto.Aciklama;
                    cariUye.OlusturanPersonelID = (int)cuDto.OlusturdanPersonelID;
                    cariUye.OlusuturulmaTarihi = olusturulmaTarihi;
                    cariUye.AktifMi = true;
                    cuDto.CariUyeID = _cm.AddEntitiy(cariUye);

                    cariUyeBilgileri.CariUyeID = (int)cuDto.CariUyeID;
                    cariUyeBilgileri.Email = cuDto.Email;
                    cariUyeBilgileri.Telefon = cuDto.Telefon;
                    cariUyeBilgileri.Adres = cuDto.Adres;
                    cariUyeBilgileri.OlusturanPersonelID = (int)cuDto.OlusturdanPersonelID;
                    cariUyeBilgileri.OlusuturulmaTarihi = olusturulmaTarihi;
                    cariUyeBilgileri.AktifMi = true;
                    _cubm.AddEntitiy(cariUyeBilgileri);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                

                if (!(cuDto.BankaID == null) && !(cuDto.HesapNo == null))
                {
                    try
                    {
                        cariUyeBanka.CariUyeID = (int)cuDto.CariUyeID;
                        cariUyeBanka.BankaID = (int)cuDto.BankaID;
                        cariUyeBanka.HesapNo = cuDto.HesapNo;
                        if (!string.IsNullOrEmpty(cuDto.IBAN))
                        {
                            cariUyeBanka.IBAN = cuDto.IBAN;
                        }
                        else
                        {
                            cariUyeBanka.IBAN = null;
                        }
                        cariUyeBanka.OlusturanPersonelID = (int)cuDto.OlusturdanPersonelID;
                        cariUyeBanka.OlusuturulmaTarihi = olusturulmaTarihi;
                        cariUyeBanka.AktifMi = true;
                        _cbanka.AddEntitiy(cariUyeBanka);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    mesaj1 += "Eksik bilgi nedeniyle Cari üye banka bilgileri kaydedilmeden";
                }

                Array.Resize(ref mesaj, mesaj.Length + 1);
                mesaj[mesaj.Length - 1] = mesaj1 +" "+"Cari Üye Kaydı Yapılmıştır.";

            }
            else
            {
                Array.Resize(ref mesaj, mesaj.Length + 1);
                mesaj[mesaj.Length - 1] = "Cari üye genel bilgilerinde eksik olduğundan kayıt yapılamamıştır.";
            }


            return mesaj;

        }

        public string Guncelle(CariUyeDTO eskiNesne, CariUyeDTO yeniNesne)
        {
            CariUye cariUye = new CariUye();
            CariUyeBilgileri cariUyeBilgileri = new CariUyeBilgileri();
            CariUyeBanka cariUyeBanka = new CariUyeBanka();
            string mesaj = "";
            if (eskiNesne.CariUyeAdi != yeniNesne.CariUyeAdi.Trim() || eskiNesne.Aciklama != yeniNesne.Aciklama.Trim() || eskiNesne.KurulusTarihi != yeniNesne.KurulusTarihi)
            {
                if (Helper.NullableControl(yeniNesne.CariUyeAdi))
                {
                    try
                    {
                        cariUye.ID = yeniNesne.CariUyeID;
                        cariUye.CariAdi = yeniNesne.CariUyeAdi;
                        cariUye.AktifMi = true;
                        cariUye.Aciklama = yeniNesne.Aciklama;
                        cariUye.OlusuturulmaTarihi = DateTime.Now;
                        cariUye.OlusturanPersonelID = (int)yeniNesne.OlusturdanPersonelID;
                        _cm.CariGuncelle(cariUye);
                        mesaj += "Şirket özel bilgileri güncellendi. ";
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    mesaj += "Şirket adı girilmediğinden özel bilgiler güncellenemedi. ";
                }
            }

            if (eskiNesne.Email != yeniNesne.Email.Trim() || eskiNesne.Telefon != yeniNesne.Telefon.Trim() || eskiNesne.Adres != yeniNesne.Adres.Trim())
            {
                try
                {
                    cariUyeBilgileri.CariUyeID = eskiNesne.CariUyeID;
                    cariUyeBilgileri.Email = yeniNesne.Email;
                    cariUyeBilgileri.Telefon = yeniNesne.Telefon;
                    cariUyeBilgileri.Adres = yeniNesne.Adres;
                    cariUyeBilgileri.AktifMi = true;
                    cariUyeBilgileri.OlusuturulmaTarihi = DateTime.Now;
                    cariUyeBilgileri.OlusturanPersonelID = (int)yeniNesne.OlusturdanPersonelID;
                    _cubm.BilgileriGuncelle(cariUyeBilgileri);
                    mesaj += "Şirket iletişim bilgileri güncellendi. ";
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }                
            }

            if ((eskiNesne.BankaID != yeniNesne.BankaID || eskiNesne.HesapNo != yeniNesne.HesapNo || eskiNesne.IBAN != yeniNesne.IBAN) && yeniNesne.BankaID != null && Helper.NullableControl(yeniNesne.HesapNo))
            {
                try
                {
                    cariUyeBanka.BankaID = (int)yeniNesne.BankaID;
                    cariUyeBanka.CariUyeID = yeniNesne.CariUyeID;
                    cariUyeBanka.IBAN = yeniNesne.IBAN.Trim();
                    cariUyeBanka.OlusturanPersonelID = (int)yeniNesne.OlusturdanPersonelID;
                    cariUyeBanka.OlusuturulmaTarihi = DateTime.Now;
                    cariUyeBanka.AktifMi = true;
                    if (Helper.NullableControl(yeniNesne.HesapNo))
                    {
                        cariUyeBanka.HesapNo = yeniNesne.HesapNo.Trim();
                        _cbanka.BankaBilgileriGuncelle(cariUyeBanka);
                        mesaj += "Şirket banka bilgileri güncellendi.";
                    }
                    else
                    {
                        mesaj += "Hesap numarası girilmediğinden banka bilgileri güncellenemedi.";
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                
            }
            if(mesaj=="")
            {
                mesaj = "Herhangi değişiklik yapılmamıştır.";
            }
            return mesaj;
        }
    }
}
