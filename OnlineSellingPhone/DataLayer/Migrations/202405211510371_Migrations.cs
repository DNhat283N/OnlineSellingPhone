namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Configuration",
                c => new
                    {
                        Configuration_ID = c.Int(nullable: false, identity: true),
                        Configuration_RAM = c.Int(nullable: false),
                        Configuration_ROM = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Configuration_ID);
            
            CreateTable(
                "dbo.PhoneConfiguration",
                c => new
                    {
                        PhoneConfiguration_ID = c.Int(nullable: false, identity: true),
                        Phone_ID = c.Int(nullable: false),
                        Configuration_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneConfiguration_ID)
                .ForeignKey("dbo.Configuration", t => t.Configuration_ID, cascadeDelete: true)
                .ForeignKey("dbo.Phone", t => t.Phone_ID, cascadeDelete: true)
                .Index(t => t.Phone_ID)
                .Index(t => t.Configuration_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhoneConfiguration", "Phone_ID", "dbo.Phone");
            DropForeignKey("dbo.PhoneConfiguration", "Configuration_ID", "dbo.Configuration");
            DropIndex("dbo.PhoneConfiguration", new[] { "Configuration_ID" });
            DropIndex("dbo.PhoneConfiguration", new[] { "Phone_ID" });
            DropTable("dbo.PhoneConfiguration");
            DropTable("dbo.Configuration");
        }
    }
}
