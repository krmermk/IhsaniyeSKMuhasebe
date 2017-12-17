using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.KullaniciMap
{
    public class KullaniciMap:EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            HasKey(t => t.KullaniciID);

            ToTable("Kullanici");
            Property(t => t.KullaniciID).HasColumnName("ID");
            Property(t => t.PersonelID).HasColumnName("PersonelID").IsOptional();
            Property(t => t.KullaniciAdi).HasColumnName("KullaniciAdi").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            Property(t => t.OlusturanPersonelID).HasColumnName("OlusturanPersonelID").IsOptional();
            Property(t => t.AktifMi).HasColumnName("AktifMi").HasColumnType("bit").IsRequired();
            Property(t => t.OlusturulmaTarihi).HasColumnName("OlusturulmaTarihi").IsRequired();

            HasOptional(t => t.NVGPersonel).WithMany(t => t.NVGKullanici).HasForeignKey(t=>t.PersonelID);
    
        }

    }
}
