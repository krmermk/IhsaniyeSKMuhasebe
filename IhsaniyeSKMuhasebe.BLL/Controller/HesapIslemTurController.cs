using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using IhsaniyeSKMuhasebe.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IhsaniyeSKMuhasebe.Extension;

namespace IhsaniyeSKMuhasebe.BLL.Controller
{
    public class HesapIslemTurController
    {
        HesapIslemTurManagement _hitm;
        public HesapIslemTurController()
        {
            _hitm = new HesapIslemTurManagement();
        }
        public string AddEntity(HesapIslemTur item)
        {
            string mesaj;
            if (Helper.NullableControl(item.HesapIslemTurAdi)&&(!(string.IsNullOrWhiteSpace(item.HesapIslemTurAdi))))
            {
                try
                {
                    _hitm.AddEntitiy(item);
                    _hitm.SaveEntity();
                    mesaj = "İşlem Başarılı";
                }
                catch (Exception ex)
                {
                    mesaj = ex.Message;
                }                
            }
            else
            {
                mesaj = "Lütfen Hesap İşlem Tür Adı kısmını doldurunuz!";
            }
            return mesaj;
        }

        public ICollection<HesapIslemTur> GetEntities()
        {
            ICollection<HesapIslemTur> lst = new List<HesapIslemTur>();
            lst = _hitm.GetEntities();
            return lst;
        }

        public void DeleteEntity(int ID)
        {
            try
            {
                _hitm.DeleteEntity(ID);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        public bool UpdateEntity(HesapIslemTur nesne)
        {
            if (nesne != null)
            {
                try
                {
                    _hitm.SaveEntity();
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
