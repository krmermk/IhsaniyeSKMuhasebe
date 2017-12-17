using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.CariMap
{
    public class CariUyeMap : EntityTypeConfiguration<CariUye>
    {
        public CariUyeMap()
        {
            HasKey(t => t.ID);
            ToTable("CariUye");

            Property(t => t.ID).HasColumnName("ID").IsRequired();
            Property(t => t.CariAdi).HasColumnName("CariAdi").IsRequired().HasMaxLength(50);
            Property(t => t.PersonelID).HasColumnName("PersonelID").IsOptional();
            Property(t => t.UyeMi).HasColumnName("UyeMi").HasColumnType("bit").IsRequired();
            Property(t => t.Aciklama).HasColumnName("Aciklama").HasMaxLength(250).IsOptional();
            Property(t => t.KurulusTarihi).HasColumnName("KurulusTarihi").HasColumnType("datetime").IsOptional();
            Property(t => t.OlusturanPersonelID).HasColumnName("OlusturanPersonelID").IsRequired();
            Property(t => t.AktifMi).HasColumnName("AktifMi").HasColumnType("bit").IsRequired();
            Property(t => t.OlusuturulmaTarihi).HasColumnName("OlusuturulmaTarihi").HasColumnType("datetime").IsRequired();

            HasOptional(t => t.NVGPersonel)
                .WithMany(t => t.NVGCariUye)
                .HasForeignKey(t => t.PersonelID);
        }
    }
}
