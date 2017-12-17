namespace IhsaniyeSKMuhasebe.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CariUye",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CariAdi = c.String(nullable: false, maxLength: 50),
                        PersonelID = c.Int(nullable: false),
                        UyeMi = c.Boolean(nullable: false),
                        Aciklama = c.String(maxLength: 250),
                        KurulusTarihi = c.DateTime(),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusuturulmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Personel", t => t.PersonelID, cascadeDelete: true)
                .Index(t => t.PersonelID);
            
            CreateTable(
                "dbo.CariUyeBanka",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CariUyeID = c.Int(nullable: false),
                        BankaID = c.Int(nullable: false),
                        HesapNo = c.String(nullable: false, maxLength: 9, fixedLength: true, unicode: false),
                        IBAN = c.String(maxLength: 30, fixedLength: true),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusuturulmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BankaTanims", t => t.BankaID, cascadeDelete: true)
                .ForeignKey("dbo.CariUye", t => t.CariUyeID, cascadeDelete: true)
                .Index(t => t.CariUyeID)
                .Index(t => t.BankaID);
            
            CreateTable(
                "dbo.BankaTanims",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BankaAdi = c.String(),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusuturulmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CariUyeBilgileri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CariUyeID = c.Int(nullable: false),
                        Email = c.String(maxLength: 150),
                        Telefon = c.String(maxLength: 20, unicode: false),
                        Adres = c.String(),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusuturulmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CariUye", t => t.CariUyeID, cascadeDelete: true)
                .Index(t => t.CariUyeID);
            
            CreateTable(
                "dbo.KasaIslem",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HesapIslemID = c.Int(nullable: false),
                        CariUyeID = c.Int(nullable: false),
                        OdemeID = c.Int(nullable: false),
                        Miktar = c.Double(nullable: false),
                        IslemTarihi = c.DateTime(nullable: false),
                        ReferansBelgeNo = c.String(maxLength: 20, unicode: false),
                        Aciklama = c.String(maxLength: 50),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusturlmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CariUye", t => t.CariUyeID, cascadeDelete: true)
                .ForeignKey("dbo.HesapIslemTur", t => t.HesapIslemID, cascadeDelete: true)
                .ForeignKey("dbo.OdemeTur", t => t.OdemeID, cascadeDelete: true)
                .Index(t => t.HesapIslemID)
                .Index(t => t.CariUyeID)
                .Index(t => t.OdemeID);
            
            CreateTable(
                "dbo.HesapIslemTur",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HesapIslemTurAdi = c.String(nullable: false, maxLength: 50),
                        Aciklama = c.String(maxLength: 50),
                        HesapIslemYonu = c.Boolean(nullable: false),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusturlmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OdemeTur",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OdemeTuruAdi = c.String(nullable: false, maxLength: 50),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusturlmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TCNo = c.String(maxLength: 11, fixedLength: true, unicode: false),
                        PersonelAdi = c.String(nullable: false, maxLength: 50),
                        PersonelSoyadi = c.String(nullable: false, maxLength: 50),
                        DogumTarihi = c.DateTime(nullable: false),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        PersonelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kullanici", t => t.PersonelID)
                .Index(t => t.PersonelID);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonelID = c.Int(),
                        KullaniciAdi = c.String(nullable: false, maxLength: 50),
                        OlusturanPersonelID = c.Int(),
                        AktifMi = c.Boolean(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KullaniciSifre",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciID = c.Int(nullable: false),
                        Sifre = c.String(nullable: false, maxLength: 150),
                        OlusturanPersonelID = c.Int(),
                        AktifMi = c.Boolean(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kullanici", t => t.KullaniciID, cascadeDelete: true)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.PersonelIseGirisCikis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        IseBaslamaTarihi = c.DateTime(nullable: false),
                        IstenCikmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personel", t => t.PersonelId, cascadeDelete: true)
                .Index(t => t.PersonelId);
            
            CreateTable(
                "dbo.PersonelIsTanim",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        UnvanId = c.Int(nullable: false),
                        DepartmanId = c.Int(nullable: false),
                        MaasMiktar = c.Decimal(precision: 18, scale: 2),
                        YoneticiId = c.Int(nullable: false),
                        Aciklama = c.String(maxLength: 50),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departman", t => t.DepartmanId, cascadeDelete: true)
                .ForeignKey("dbo.Personel", t => t.YoneticiId, cascadeDelete: true)
                .ForeignKey("dbo.Unvan", t => t.UnvanId, cascadeDelete: true)
                .Index(t => t.UnvanId)
                .Index(t => t.DepartmanId)
                .Index(t => t.YoneticiId);
            
            CreateTable(
                "dbo.Departman",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DepartmanAdi = c.String(nullable: false, maxLength: 50),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Unvan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GorevAdi = c.String(nullable: false, maxLength: 50),
                        OlusturanPersonelID = c.Int(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CariUye", "PersonelID", "dbo.Personel");
            DropForeignKey("dbo.PersonelIsTanim", "UnvanId", "dbo.Unvan");
            DropForeignKey("dbo.PersonelIsTanim", "YoneticiId", "dbo.Personel");
            DropForeignKey("dbo.PersonelIsTanim", "DepartmanId", "dbo.Departman");
            DropForeignKey("dbo.PersonelIseGirisCikis", "PersonelId", "dbo.Personel");
            DropForeignKey("dbo.Personel", "PersonelID", "dbo.Kullanici");
            DropForeignKey("dbo.KullaniciSifre", "KullaniciID", "dbo.Kullanici");
            DropForeignKey("dbo.KasaIslem", "OdemeID", "dbo.OdemeTur");
            DropForeignKey("dbo.KasaIslem", "HesapIslemID", "dbo.HesapIslemTur");
            DropForeignKey("dbo.KasaIslem", "CariUyeID", "dbo.CariUye");
            DropForeignKey("dbo.CariUyeBilgileri", "CariUyeID", "dbo.CariUye");
            DropForeignKey("dbo.CariUyeBanka", "CariUyeID", "dbo.CariUye");
            DropForeignKey("dbo.CariUyeBanka", "BankaID", "dbo.BankaTanims");
            DropIndex("dbo.PersonelIsTanim", new[] { "YoneticiId" });
            DropIndex("dbo.PersonelIsTanim", new[] { "DepartmanId" });
            DropIndex("dbo.PersonelIsTanim", new[] { "UnvanId" });
            DropIndex("dbo.PersonelIseGirisCikis", new[] { "PersonelId" });
            DropIndex("dbo.KullaniciSifre", new[] { "KullaniciID" });
            DropIndex("dbo.Personel", new[] { "PersonelID" });
            DropIndex("dbo.KasaIslem", new[] { "OdemeID" });
            DropIndex("dbo.KasaIslem", new[] { "CariUyeID" });
            DropIndex("dbo.KasaIslem", new[] { "HesapIslemID" });
            DropIndex("dbo.CariUyeBilgileri", new[] { "CariUyeID" });
            DropIndex("dbo.CariUyeBanka", new[] { "BankaID" });
            DropIndex("dbo.CariUyeBanka", new[] { "CariUyeID" });
            DropIndex("dbo.CariUye", new[] { "PersonelID" });
            DropTable("dbo.Unvan");
            DropTable("dbo.Departman");
            DropTable("dbo.PersonelIsTanim");
            DropTable("dbo.PersonelIseGirisCikis");
            DropTable("dbo.KullaniciSifre");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Personel");
            DropTable("dbo.OdemeTur");
            DropTable("dbo.HesapIslemTur");
            DropTable("dbo.KasaIslem");
            DropTable("dbo.CariUyeBilgileri");
            DropTable("dbo.BankaTanims");
            DropTable("dbo.CariUyeBanka");
            DropTable("dbo.CariUye");
        }
    }
}
