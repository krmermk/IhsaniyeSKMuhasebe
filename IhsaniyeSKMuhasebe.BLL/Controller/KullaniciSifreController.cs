using IhsaniyeSKMuhasebe.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class KullaniciSifreController
    {
        KullaniciSifreManagement _ksm;
        public KullaniciSifreController()
        {
            _ksm = new KullaniciSifreManagement();
        }
        public void DeleteSifre(int ID)
        {
            try
            {
                _ksm.DeleteEntity(ID);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }
    }
}
