using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.PersonelMap
{
    public class PersonelIseGirisCikisMap:EntityTypeConfiguration<PersonelIseGirisCikis>
    {

        public PersonelIseGirisCikisMap()
        {
            HasKey(t => t.Id);

            ToTable("PersonelIseGirisCikis");

            Property(t => t.Id).HasColumnName("ID");
            Property(t => t.PersonelId).HasColumnName("PersonelID");
            Property(t => t.IseBaslamaTarihi).HasColumnName("IseBaslamaTarihi").IsOptional();
            Property(t => t.IstenCikmaTarihi).HasColumnName("IstenCikmaTarihi").IsOptional();
            Property(t => t.OlusturanPersonelId).HasColumnName("OlusturanPersonelID");
            Property(t => t.OlusturulmaTarihi).HasColumnName("OlusturulmaTarihi").IsRequired();
            Property(t => t.AktifMi).HasColumnName("AktifMi").HasColumnType("bit").IsRequired();

            HasRequired(p => p.NVGPersonel).WithMany(p => p.NVGPersonelIseGirisCikis).HasForeignKey(p => p.PersonelId);    
        }
    }
}
