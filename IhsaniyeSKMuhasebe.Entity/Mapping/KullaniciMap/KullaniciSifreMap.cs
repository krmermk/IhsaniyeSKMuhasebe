using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.KullaniciMap
{
    public class KullaniciSifreMap:EntityTypeConfiguration<KullaniciSifre>
    {
        public KullaniciSifreMap()
        {
            HasKey(t => t.ID);

            ToTable("KullaniciSifre");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.KullaniciID).HasColumnName("KullaniciID");
            Property(t => t.Sifre).HasColumnName("Sifre").HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
            Property(t => t.OlusturanPersonelID).HasColumnName("OlusturanPersonelID").IsOptional();
            Property(t => t.AktifMi).HasColumnName("AktifMi").HasColumnType("bit").IsRequired();
            Property(t => t.OlusturulmaTarihi).HasColumnName("OlusturulmaTarihi").IsRequired();

            HasRequired(t => t.NVGKullanici)
                .WithMany(t => t.NVGKullaniciSifre)
                .HasForeignKey(t => t.KullaniciID);
        }
    }
}
