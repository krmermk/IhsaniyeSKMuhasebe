using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.KasaMap
{
    public class KasaIslemMap : EntityTypeConfiguration<KasaIslem>
    {
        public KasaIslemMap()
        {
            HasKey(t => t.ID);
            ToTable("KasaIslem");
            Property(t => t.ID).HasColumnName("ID").IsRequired();
            Property(t => t.HesapIslemID).HasColumnName("HesapIslemID").IsRequired();
            Property(t => t.CariUyeID).HasColumnName("CariUyeID").IsRequired();
            Property(t => t.OdemeID).HasColumnName("OdemeID").IsRequired();
            Property(t => t.Miktar).HasColumnName("Miktar").IsRequired();
            Property(t => t.IslemTarihi).HasColumnName("IslemTarihi").IsRequired();
            Property(t => t.ReferansBelgeNo).HasColumnName("ReferansBelgeNo").IsOptional().HasColumnType("varchar").HasMaxLength(20);
            Property(t => t.Aciklama).HasColumnName("Aciklama").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(t => t.OlusturanPersonelID).HasColumnName("OlusturanPersonelID").IsRequired();
            Property(t => t.AktifMi).HasColumnName("AktifMi").IsRequired().HasColumnType("bit");
            Property(t => t.OlusturlmaTarihi).HasColumnName("OlusturlmaTarihi").IsRequired();

            HasRequired(t => t.NVGCariUye).WithMany(t => t.NVGKasaIslem).HasForeignKey(d => d.CariUyeID);
            HasRequired(t => t.NVGOdemeTuru).WithMany(t => t.NVGKasaIslem).HasForeignKey(t => t.OdemeID);
            HasRequired(t => t.NVGHesapIslemTur).WithMany(t => t.NVGKasaIslem).HasForeignKey(t => t.HesapIslemID);

        }
    }
}
