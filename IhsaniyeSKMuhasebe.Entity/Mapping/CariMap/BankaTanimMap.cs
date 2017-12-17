using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.CariMap
{
    public class BankaTanimMap : EntityTypeConfiguration<BankaTanim>
    {
       public BankaTanimMap()
       {
           HasKey(t => t.ID);
           ToTable("BankaTanim");
           Property(t => t.ID).HasColumnName("ID");
           Property(t => t.BankaAdi).HasColumnName("BankaAdi").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
           Property(t => t.OlusturanPersonelID).HasColumnName("OlusturanPersonelID").IsRequired();
           Property(t => t.AktifMi).HasColumnName("AktifMi").IsRequired().HasColumnType("bit");
           Property(t => t.OlusuturulmaTarihi).HasColumnName("OlusuturulmaTarihi").IsRequired().HasColumnType("datetime");
       }
    }
}
