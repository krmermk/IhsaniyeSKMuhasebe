using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class CariUyeBankaController
    {
        CariUyeBankaManagement _cubm;
        public CariUyeBankaController()
        {
            _cubm = new CariUyeBankaManagement();
        }
        public void CariUyeBankaBilgileriEkle(CariUyeBanka nesne)
        {
            try
            {
                _cubm.AddEntitiy(nesne);
                _cubm.SaveEntity();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }
        public void DeleteBankaBilgisi(int ID)
        {
            try
            {
                _cubm.DeleteEntity(ID);
                _cubm.SaveEntity();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }
    }
}
