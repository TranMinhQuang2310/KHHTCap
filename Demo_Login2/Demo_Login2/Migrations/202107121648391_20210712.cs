namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20210712 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ma = c.String(maxLength: 10),
                        IDKhoaDaoTao = c.Int(),
                        HoVaTen = c.String(),
                        MailVL = c.String(),
                        PhanLoai = c.Boolean(nullable: false),
                        DaXem = c.Boolean(nullable: false),
                        GhiChu = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.KhoaDaoTaos", t => t.IDKhoaDaoTao)
                .Index(t => t.IDKhoaDaoTao);
            
            CreateTable(
                "dbo.AccountLopHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDLopHoc = c.Int(),
                        IDAccount = c.Int(),
                        IsDisabled = c.Boolean(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.IDAccount)
                .ForeignKey("dbo.LopHocs", t => t.IDLopHoc)
                .Index(t => t.IDLopHoc)
                .Index(t => t.IDAccount);
            
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDKhoaDaoTao = c.Int(),
                        TenLop = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KhoaDaoTaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenKhoaDaoTao = c.String(),
                        NienKhoa = c.String(),
                        LoaiHinhDaoTao = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DaoTaoHocKis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDKeHoachDaoTao = c.Int(nullable: false),
                        IDHocKi = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GiangVienMonHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDMonHoc = c.Int(nullable: false),
                        IDGiangVien = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HocKis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenHocKi = c.String(),
                        LoaiHocKi = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HocPhanTienQuyets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDMonHoc = c.Int(),
                        IDMonHocTienQuyet = c.Int(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KeHoachDaoTaos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDKhoaDaoTao = c.Int(nullable: false),
                        TenKeHoachDaoTao = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KeHoachHocTaps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDKeHoachDaoTao = c.Int(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                        HocLai = c.Boolean(nullable: false),
                        HocVuot = c.Boolean(nullable: false),
                        CaiThien = c.Boolean(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KhoaBoMons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenKhoaBoMon = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MonHocHocKis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDMonHoc = c.Int(nullable: false),
                        IDHocKi = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDKhoaBoMon = c.Int(nullable: false),
                        MaMonHoc = c.String(),
                        TenMonHoc = c.String(),
                        HocPhanTienQuyet = c.Boolean(nullable: false),
                        HocPhanHocTruoc = c.Boolean(nullable: false),
                        SoTiet = c.Int(nullable: false),
                        SoTietLyThuyet = c.Int(nullable: false),
                        SoTietThucHanh = c.Int(nullable: false),
                        LoaiMonHoc = c.Int(nullable: false),
                        SoTinChi = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SinhVienKeHoachHocTaps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDSinhVien = c.Int(nullable: false),
                        IDKeHoachHocTap = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "IDKhoaDaoTao", "dbo.KhoaDaoTaos");
            DropForeignKey("dbo.AccountLopHocs", "IDLopHoc", "dbo.LopHocs");
            DropForeignKey("dbo.AccountLopHocs", "IDAccount", "dbo.Accounts");
            DropIndex("dbo.AccountLopHocs", new[] { "IDAccount" });
            DropIndex("dbo.AccountLopHocs", new[] { "IDLopHoc" });
            DropIndex("dbo.Accounts", new[] { "IDKhoaDaoTao" });
            DropTable("dbo.SinhVienKeHoachHocTaps");
            DropTable("dbo.MonHocs");
            DropTable("dbo.MonHocHocKis");
            DropTable("dbo.KhoaBoMons");
            DropTable("dbo.KeHoachHocTaps");
            DropTable("dbo.KeHoachDaoTaos");
            DropTable("dbo.HocPhanTienQuyets");
            DropTable("dbo.HocKis");
            DropTable("dbo.GiangVienMonHocs");
            DropTable("dbo.DaoTaoHocKis");
            DropTable("dbo.KhoaDaoTaos");
            DropTable("dbo.LopHocs");
            DropTable("dbo.AccountLopHocs");
            DropTable("dbo.Accounts");
        }
    }
}
