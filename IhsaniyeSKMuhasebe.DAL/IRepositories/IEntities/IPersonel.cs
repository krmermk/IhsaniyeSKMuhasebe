using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IEntities
{
    interface IPersonel : IAdd<Personel>, IDelete<Personel>, ISave
    {
        ICollection<Personel> GetPersonel(bool aktifMi);
        void PersonelGuncelle(Personel nesne);
        ICollection<PersonelGoruntuleDTO> GetPersonelGoruntuleDTO();
        ICollection<PersonelGoruntuleDTO> GetPersonelGoruntuleDTO(string isim);
    }
}
