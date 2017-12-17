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
    public class PersonelUnvanDepartmanDtoManagement : IPersonelUnvanDepartmanDTO
    {
        IhsaniyeSKContext _db;

        public PersonelUnvanDepartmanDtoManagement()
        {
            _db = new IhsaniyeSKContext();
        }
        public PersonelUnvanDepartmanDTO GetPersonelUnvanDepartman(int PersonelId)
        {
            return (from personel in _db.DbPersonel
                    join personelIsTanim in _db.DbPersonelIsTanim on personel.Id equals personelIsTanim.PersonelId
                    join unvan in _db.DbUnvan on personelIsTanim.UnvanId equals unvan.Id
                    join departman in _db.DbDepartman on personelIsTanim.DepartmanId equals departman.Id
                    where personel.Id == PersonelId && unvan.AktifMi==true && departman.AktifMi==true
                    select new PersonelUnvanDepartmanDTO
                    {
                        UnvanAdi = unvan.GorevAdi,
                        DepartmanAdi = departman.DepartmanAdi
                        
                    }).FirstOrDefault();
        }
    }
}
