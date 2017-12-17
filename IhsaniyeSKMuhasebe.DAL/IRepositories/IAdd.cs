using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.DAL.IRepositories
{
    interface IAdd<T> where T:class
    {
        int AddEntitiy(T nesne);
    }
}
