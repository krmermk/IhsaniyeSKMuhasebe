using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.DTO.DTO;
using IhsaniyeSKMuhasebe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class PersonelUnvanDepartmanDtoController
    {
       PersonelUnvanDepartmanDtoManagement _puddm;
        public PersonelUnvanDepartmanDtoController ()
	{
            _puddm=new PersonelUnvanDepartmanDtoManagement();
	}

public PersonelUnvanDepartmanDTO PersonelUnvanDepartmanGetir(int PersonelID)
        {
 
     return _puddm.GetPersonelUnvanDepartman(PersonelID);
        }
    }
}
