using IhsaniyeSKMuhasebe.DAL.Repositories;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class BankaTanimController
    {
        BankaTanimManagement _btm;
        public BankaTanimController()
        {
            _btm = new BankaTanimManagement();
        }
        public ICollection<BankaTanim> AktifBankaGetir()
        {
            return _btm.GetBanka();
        }
        public void BankaEkle(BankaTanim nesne)
        {
            try
            {
                _btm.AddEntitiy(nesne);
                _btm.SaveEntity();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }
        public void DeleteBanka(int ID)
        {
            if (ID != null)
            {
                try
                {
                    _btm.DeleteEntity(ID);
                    _btm.SaveEntity();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                
            }
       }
        public bool UpdateBanka(BankaTanim nesne)
        {
            if (nesne!=null)
            {
                try
                {
                    _btm.SaveEntity();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }
    }

}
