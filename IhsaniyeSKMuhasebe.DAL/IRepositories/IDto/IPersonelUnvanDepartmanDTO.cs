using IhsaniyeSKMuhasebe.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories.IDto
{
    interface IPersonelUnvanDepartmanDTO
    {
        PersonelUnvanDepartmanDTO GetPersonelUnvanDepartman(int PersonelId);
    }
}
