using IhsaniyeSKMuhasebe.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class PersonelIsTanimController
    {
        PersonelIsTanimManagement _pitm;
        public PersonelIsTanimController()
        {
            _pitm = new PersonelIsTanimManagement();
        }
        public void DeleteIstanim(int ID)
        {
            _pitm.DeleteEntity(ID);
        }
    }
}
