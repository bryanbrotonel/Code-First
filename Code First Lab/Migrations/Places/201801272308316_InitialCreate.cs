namespace Code_First_Lab.Migrations.Places
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        cityID = c.Int(nullable: false, identity: true),
                        cityName = c.String(),
                        population = c.Int(nullable: false),
                        Province_provinceCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.cityID)
                .ForeignKey("dbo.Provinces", t => t.Province_provinceCode)
                .Index(t => t.Province_provinceCode);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        provinceCode = c.String(nullable: false, maxLength: 128),
                        provinceName = c.String(),
                    })
                .PrimaryKey(t => t.provinceCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Province_provinceCode", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "Province_provinceCode" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}
