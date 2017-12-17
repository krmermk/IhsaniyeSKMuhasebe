using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.CariMap
{
    public class CariUyeBankaMap : EntityTypeConfiguration<CariUyeBanka>
    {
        public CariUyeBankaMap()
        {
            HasKey(t => t.ID);
            ToTable("CariUyeBanka");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.CariUyeID).HasColumnName("CariUyeID").IsRequired();
            Property(t => t.BankaID).HasColumnName("BankaID").IsRequired();
            Property(t => t.HesapNo).HasColumnName("HesapNo").HasColumnType("char").HasMaxLength(19).IsRequired();
            Property(t => t.IBAN).HasColumnName("IBAN").HasColumnType("Nchar").HasMaxLength(30).IsOptional();
            Property(t => t.OlusturanPersonelID).HasColumnName("OlusturanPersonelID").IsRequired();
            Property(t => t.AktifMi).HasColumnName("AktifMi").IsRequired().HasColumnType("bit");
            Property(t => t.OlusuturulmaTarihi).HasColumnName("OlusuturulmaTarihi").IsRequired().HasColumnType("datetime");

            HasRequired(t => t.NVGCariUye)
                .WithMany(t => t.NVGCariUyeBanka)
                .HasForeignKey(t => t.CariUyeID);

            HasRequired(t => t.NVGBankaTanim)
             .WithMany(t => t.NVGCariUyeBanka)
             .HasForeignKey(t => t.BankaID);
            
        }
    }
}
