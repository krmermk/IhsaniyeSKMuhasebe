using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class CariUyeController
    {
        CariUyeManagement cariUye;
        CariUyeBilgileriController _bilgiC;
        CariUyeBankaController _bankaC;
        public CariUyeController()
        {
            cariUye = new CariUyeManagement();
            _bilgiC = new CariUyeBilgileriController();
            _bankaC = new CariUyeBankaController();
        }
        public ICollection<CariUye> GetEntities()
        {
            return cariUye.GetEntities().ToList();
        }
        public void CariUyeEkle(CariUye nesne)
        {
            try
            {
                cariUye.AddEntitiy(nesne);
                cariUye.SaveEntity();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        public void DeleteCari(int ID)
        {
            if (ID != null)
            {
                try
                {
                    cariUye.DeleteEntity(ID);
                    _bilgiC.DeleteIletisim(ID);
                    _bankaC.DeleteBankaBilgisi(ID);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                
            }
        }

        public ICollection<CariUye> GetUyeOlanlar()
        {
            return cariUye.GetUyeOlanlar();
        }

        public ICollection<CariUye> GetUyeOlmayanlar()
        {
            return cariUye.GetUyeOlmayanlar();
        }

        public string UyelikIslemi(CariUye _cari, bool _islem, int olusturanPersonel)
        {
            if (_cari != null)
            {
                try
                {
                    _cari.OlusturanPersonelID = olusturanPersonel;
                    _cari.OlusuturulmaTarihi = DateTime.Now;
                    cariUye.UyelikIslemi(_cari, _islem);
                    return "İşlem Başarılı.";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }                
            }
            return "Lütfen Bir Şirket/Birey seçiniz!";
        }

        public ICollection<CariUyeDTO> GetUyeOlanlarDTO()
        {
            return cariUye.GetUyeOlanlarDTO();
        }

        public ICollection<CariUyeDTO> GetUyeOlanlarDTO(string ad)
        {
            return cariUye.GetUyeOlanlarDTO(ad);
        }

        public ICollection<CariUyeDTO> GetCariDTO()
        {
            return cariUye.GetCariDTO();
        }
        public ICollection<CariUyeDTO> GetCariDTO(string isim)
        {
            return cariUye.GetCariDTO(isim);
        }
    }
}
