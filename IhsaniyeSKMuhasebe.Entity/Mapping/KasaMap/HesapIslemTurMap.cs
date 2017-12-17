using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity
{
    public class HesapIslemTurMap : EntityTypeConfiguration<HesapIslemTur>
    {
        public HesapIslemTurMap()
        {
            HasKey(t => t.ID);
            ToTable("HesapIslemTur");
            Property(t => t.ID).HasColumnName("ID").IsRequired();
            Property(t => t.HesapIslemTurAdi).HasColumnName("HesapIslemTurAdi").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            Property(t => t.Aciklama).HasColumnName("Aciklama").HasColumnType("nvarchar").HasMaxLength(50).IsOptional();
            Property(t => t.HesapIslemYonu).HasColumnName("HesapIslemYonu").HasColumnType("bit").IsRequired();
            Property(t => t.OlusturanPersonelID).HasColumnName("OlusturanPersonelID").IsRequired();
            Property(t => t.AktifMi).HasColumnName("AktifMi").IsRequired().HasColumnType("bit");
            Property(t => t.OlusturlmaTarihi).HasColumnName("OlusturlmaTarihi").IsRequired();

        }
    }
}
