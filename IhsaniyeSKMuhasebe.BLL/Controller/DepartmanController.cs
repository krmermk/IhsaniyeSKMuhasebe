using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.DAL.Repositories;


namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class DepartmanController
    {
        DepartmanManagement _dm;

        public DepartmanController()
        {
            _dm = new DepartmanManagement();
        }
        public bool DepartmanEkle(string DepartmanAdi, int personelID)
        {
            bool isAdd = false;
            try
            {                
                Departman departman = new Departman();
                departman.DepartmanAdi = DepartmanAdi;
                departman.OlusturanPersonelId = personelID;
                departman.OlusturulmaTarihi = DateTime.Now;
                departman.AktifMi = true;
                if (_dm.AddEntitiy(departman) > 0)
                {
                    isAdd = true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return isAdd;
        }
        public bool DepartmanSil(int ID)
        {
            bool isDelete = false;
            try
            {
                _dm.DeleteEntity(ID);
                isDelete = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                isDelete = false;
            }

            return isDelete;
        }

        public ICollection<Departman> AktifDepartmanlariGetir()
        {
            return _dm.GetDepartman();
        }
        public bool UpdateDepartman(Departman nesne)
        {
            if (nesne != null)
            {
                try
                {
                    _dm.SaveEntity();
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
