using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class CariUyeBilgileriController
    {
        CariUyeBilgileriManagement _cub;
        public CariUyeBilgileriController()
        {
            _cub = new CariUyeBilgileriManagement();
        }
        public void CariUyeBilgileriEkle(CariUyeBilgileri nesne)
        {
            try
            {
                _cub.AddEntitiy(nesne);
                _cub.SaveEntity();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        public void DeleteIletisim(int ID)
        {
            try
            {
                _cub.DeleteEntity(ID);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }
    }
}
