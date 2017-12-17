using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.CariMap
{
    public class CariUyeBilgileriMap : EntityTypeConfiguration<CariUyeBilgileri>
    {
        public CariUyeBilgileriMap()
        {
            HasKey(t => t.ID);
            ToTable("CariUyeBilgileri");
            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.CariUyeID).HasColumnName("CariUyeID").IsRequired();
            Property(t => t.Email).HasColumnName("Email").HasColumnType("nvarchar").HasMaxLength(150).IsOptional();
            Property(t => t.Telefon).HasColumnName("Telefon").HasColumnType("varchar").HasMaxLength(20).IsOptional();
            Property(t => t.Adres).HasColumnName("Adres").IsOptional();
            Property(t => t.OlusturanPersonelID).HasColumnName("OlusturanPersonelID").IsRequired();
            Property(t => t.AktifMi).HasColumnName("AktifMi").HasColumnType("bit").IsRequired();
            Property(t => t.OlusuturulmaTarihi).HasColumnName("OlusuturulmaTarihi").HasColumnType("datetime").IsRequired();

            HasRequired(t => t.NVGCariUye)
                .WithMany(t => t.NVGCariUyeBilgileri)
                .HasForeignKey(t => t.CariUyeID);
        }
    }
}
