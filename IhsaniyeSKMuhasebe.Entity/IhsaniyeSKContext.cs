using IhsaniyeSKMuhasebe.Entity.Entities.KullaniciEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.PersonelEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.KasaEntity;
using IhsaniyeSKMuhasebe.Entity.Entities.CariEntity;
using IhsaniyeSKMuhasebe.Entity.Mapping.CariMap;
using IhsaniyeSKMuhasebe.Entity.Mapping.KasaMap;
using IhsaniyeSKMuhasebe.Entity.Mapping.KullaniciMap;
using IhsaniyeSKMuhasebe.Entity.Mapping.PersonelMap;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhsaniyeSKMuhasebe.Entity
{
    public class IhsaniyeSKContext : DbContext
    {
        public IhsaniyeSKContext()
            : base("MyConnection")
        {

        }

        public DbSet<Kullanici> DbKullanici { get; set; }
        public DbSet<KullaniciSifre> DbKullaniciSifre { get; set; }
        public  DbSet<CariUye> DbCariUye { get; set; }
        public DbSet<CariUyeBanka> DbCariUyeBanka { get; set; }
        public DbSet<CariUyeBilgileri> DbCariUyeBilgileri { get; set; }
        public DbSet<HesapIslemTur> DbHesapIslemTur { get; set; }
        public DbSet<KasaIslem> DbKasaIslem { get; set; }
        public DbSet<OdemeTuru> DbOdemeTuru { get; set; }
        public DbSet<Departman> DbDepartman { get; set; }
        public DbSet<Personel> DbPersonel { get; set; }
        public DbSet<PersonelIsTanim> DbPersonelIsTanim { get; set; }
        public DbSet<Unvan> DbUnvan { get; set; }
        public DbSet<BankaTanim> DbBankaTanim { get; set; }
        public DbSet<PersonelIseGirisCikis> DbPersonelIseGirisCikis { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciSifreMap());
            modelBuilder.Configurations.Add(new CariUyeMap());
            modelBuilder.Configurations.Add(new CariUyeBankaMap());
            modelBuilder.Configurations.Add(new CariUyeBilgileriMap());
            modelBuilder.Configurations.Add(new HesapIslemTurMap());
            modelBuilder.Configurations.Add(new KasaIslemMap());
            modelBuilder.Configurations.Add(new OdemeTurMap());
            modelBuilder.Configurations.Add(new DepartmanMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new PersonelIsTanimMap());
            modelBuilder.Configurations.Add(new UnvanMap());
            modelBuilder.Configurations.Add(new BankaTanimMap());
            modelBuilder.Configurations.Add(new PersonelIseGirisCikisMap());
        }
    }
}
