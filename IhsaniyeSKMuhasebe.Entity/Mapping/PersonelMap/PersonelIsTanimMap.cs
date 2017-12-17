using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity.Mapping.PersonelMap
{
    public class PersonelIsTanimMap:EntityTypeConfiguration<PersonelIsTanim>
    {
        public PersonelIsTanimMap ()
	{
        HasKey(t => t.Id);

        ToTable("PersonelIsTanim");

        Property(t => t.Id).HasColumnName("ID");
        Property(t => t.PersonelId).HasColumnName("PersonelID");
        Property(t => t.UnvanId).HasColumnName("UnvanId");
        Property(t => t.DepartmanId).HasColumnName("DepartmanId");
        Property(t => t.MaasMiktar).HasColumnName("MaasMiktar").IsOptional();
        Property(t => t.YoneticiId).HasColumnName("YoneticiId").IsOptional();
        Property(t => t.Aciklama).HasColumnName("Aciklama").HasMaxLength(50);
        Property(t => t.OlusturanPersonelId).HasColumnName("OlusturanPersonelID");
        Property(t => t.OlusturulmaTarihi).HasColumnName("OlusturulmaTarihi").IsRequired();
        Property(t => t.AktifMi).HasColumnName("AktifMi").HasColumnType("bit").IsRequired();

        HasRequired(p => p.NVGPersonel).WithMany(p => p.NVGPersonelIsTanim).HasForeignKey(p => p.PersonelId);
        HasRequired(p => p.NVGUnvan).WithMany(d => d.NVGPersonelIsTanim).HasForeignKey(p => p.UnvanId);
        HasRequired(p => p.NVGDepartman).WithMany(d => d.NVGPersonelIsTanim).HasForeignKey(p => p.DepartmanId);
        HasOptional(p => p.NVGPersonel2).WithMany(d => d.NVGPersonelIsTanim2).HasForeignKey(p => p.YoneticiId);

	}

    }
}
