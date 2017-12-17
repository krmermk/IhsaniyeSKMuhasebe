using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.PersonelMap
{
    public class PersonelMap:EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            HasKey(t => t.Id);

            ToTable("Personel");

            Property(t => t.Id).HasColumnName("ID");
            Property(t => t.TcNo).HasColumnName("TCNo").HasColumnType("char").HasMaxLength(11).IsOptional();
            Property(t => t.PersonelAdi).HasColumnName("PersonelAdi").HasMaxLength(50).IsRequired();
            Property(t => t.PersonelSoyadi).HasColumnName("PersonelSoyadi").HasMaxLength(50).IsRequired();
            Property(t => t.DogumTarihi).HasColumnName("DogumTarihi").IsRequired();
            Property(t => t.OlusturanPersonelId).HasColumnName("OlusturanPersonelID");
            Property(t => t.OlusturulmaTarihi).HasColumnName("OlusturulmaTarihi").IsRequired();
            Property(t => t.AktifMi).HasColumnName("AktifMi").HasColumnType("bit").IsRequired();


        }
    }
}
