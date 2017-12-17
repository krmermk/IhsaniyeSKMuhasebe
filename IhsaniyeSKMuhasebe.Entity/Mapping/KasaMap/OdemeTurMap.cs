using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.KasaMap
{
    public class OdemeTurMap : EntityTypeConfiguration<OdemeTuru>
   {
       public OdemeTurMap()
       {

           HasKey(t => t.ID);
           ToTable("OdemeTur");
           Property(t => t.ID).HasColumnName("ID").IsRequired();
           Property(t => t.OdemeTuruAdi).HasColumnName("OdemeTuruAdi").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
           Property(t => t.OlusturanPersonelID).HasColumnName("OlusturanPersonelID").IsRequired();
           Property(t => t.AktifMi).HasColumnName("AktifMi").IsRequired().HasColumnType("bit");
           Property(t => t.OlusturlmaTarihi).HasColumnName("OlusturlmaTarihi").IsRequired();
       }
    }
}
