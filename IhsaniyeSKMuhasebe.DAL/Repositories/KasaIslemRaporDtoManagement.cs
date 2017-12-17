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
    public class KasaIslemRaporDtoManagement:IKasaIslemRaporDto
    {
        IhsaniyeSKContext _db;
       
        public KasaIslemRaporDtoManagement()
        {
            _db = new IhsaniyeSKContext();
        }

        public ICollection<KasaIslemRaporDTO> GetKasaIslemRapor(int hesapIslemTurId,int yil)
        {
            return (from cu in _db.DbCariUye
                    join ki in _db.DbKasaIslem on cu.ID equals ki.CariUyeID   into temp1
                    from t1 in temp1.DefaultIfEmpty()
                    join ht in _db.DbHesapIslemTur on t1.HesapIslemID equals ht.ID
                    join p in _db.DbPersonel on cu.PersonelID equals p.Id into temp2
                    from t2 in temp2.DefaultIfEmpty()
                    where cu.AktifMi == true && t1.AktifMi != false && (ht.ID==hesapIslemTurId||ht==null) && t1.IslemTarihi.Year==yil
                    select new KasaIslemRaporDTO
                    {
                        KasaIslemId = t1.ID,
                        CariUyeId = cu.ID,
                        CariUyeAdi = cu.CariAdi,
                        PersonelId = t2.Id,
                        PersonelAdi = t2.PersonelAdi+" "+t2.PersonelSoyadi,
                        HesapIslemTurId = ht.ID,
                        Miktar = t1.Miktar,
                        IslemTarihi =t1.IslemTarihi

                    }).ToList();  
        }


        public ICollection<int> IslemYapilanYillar(int hesapIslemTurId)
        {
            return (from ki in _db.DbKasaIslem
                    where ki.AktifMi ==true && ki.HesapIslemID==hesapIslemTurId
                    select ki.IslemTarihi.Year).Distinct().ToList();  
        }
    }
}
