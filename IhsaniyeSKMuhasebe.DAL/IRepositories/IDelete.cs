using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories
{
    interface IDelete<T> where T:class
    {
        void DeleteEntity(int Id);
    }
}
