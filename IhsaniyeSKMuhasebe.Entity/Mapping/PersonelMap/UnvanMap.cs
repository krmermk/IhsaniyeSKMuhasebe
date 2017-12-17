using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.PersonelMap
{
    public class UnvanMap:EntityTypeConfiguration<Unvan>
    {

        public UnvanMap()
        {
            HasKey(t => t.Id);

            ToTable("Unvan");

            Property(t => t.Id).HasColumnName("ID");
            Property(t => t.GorevAdi).HasColumnName("GorevAdi").HasMaxLength(50).IsRequired();
            Property(t => t.OlusturanPersonelId).HasColumnName("OlusturanPersonelID");
            Property(t => t.OlusturulmaTarihi).HasColumnName("OlusturulmaTarihi").IsRequired();
            Property(t => t.AktifMi).HasColumnName("AktifMi").HasColumnType("bit").IsRequired();
        }
    }
}
