using IhsaniyeSKMuhasebe.DAL.IRepositories.IDto;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.Repositories
{

    public class KasaIslemDTOManagment:IKasaIslemDto
    {
        IhsaniyeSKContext _db;

        public KasaIslemDTOManagment()
        {
            _db = new IhsaniyeSKContext();
        }
        public ICollection<KasaIslemDTO> IslemGetir()
        {
            List<KasaIslemDTO> listem = new List<KasaIslemDTO>();

            listem = (from kasaislem in _db.DbKasaIslem
                      join cariuye in _db.DbCariUye on kasaislem.CariUyeID equals cariuye.ID
                      join hesapislemtur in _db.DbHesapIslemTur on kasaislem.HesapIslemID equals hesapislemtur.ID
                      join odemetur in _db.DbOdemeTuru on kasaislem.OdemeID equals odemetur.ID
                      where kasaislem.AktifMi == true
                      select new KasaIslemDTO()
                      {


                          ID = kasaislem.ID,
                          HesapIslemTurAdi = hesapislemtur.HesapIslemTurAdi,
                          CariUyeAdi = cariuye.CariAdi,
                          OdemeTurAdi = odemetur.OdemeTuruAdi,
                          Miktar = kasaislem.Miktar,
                          IslemTarihi = kasaislem.IslemTarihi,
                          BelgeNo = kasaislem.ReferansBelgeNo,
                          Aciklama = kasaislem.Aciklama
                      }).ToList();
            return listem;
        }
    }
}
