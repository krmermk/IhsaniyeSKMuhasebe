using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.PersonelMap
{
    public class DepartmanMap:EntityTypeConfiguration<Departman>
    {
        public DepartmanMap()
        {
            HasKey(t => t.Id);

            ToTable("Departman");

            Property(t => t.Id).HasColumnName("ID");
            Property(t => t.DepartmanAdi).HasColumnName("DepartmanAdi").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            Property(t => t.OlusturanPersonelId).HasColumnName("OlusturanPersonelID");
            Property(t => t.OlusturulmaTarihi).HasColumnName("OlusturulmaTarihi").HasColumnType("datetime").IsRequired();
            Property(t => t.AktifMi).HasColumnName("AktifMi").HasColumnType("bit").IsRequired() ;


        }
    }
}
