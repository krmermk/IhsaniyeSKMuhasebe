using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface ICariUye : IAdd<CariUye>, IDelete<CariUye>, ISave
    {
        void CariGuncelle(CariUye nesne);
        ICollection<CariUye> GetEntities();
        ICollection<CariUye> GetUyeOlanlar();
        ICollection<CariUyeDTO> GetCariDTO();
        ICollection<CariUyeDTO> GetCariDTO(string isim);
        ICollection<CariUyeDTO> GetUyeOlanlarDTO(string isim);
        ICollection<CariUyeDTO> GetUyeOlanlarDTO();
        ICollection<CariUye> GetUyeOlmayanlar();
        void UyelikIslemi(CariUye _cari, bool _islem);
    }
}
