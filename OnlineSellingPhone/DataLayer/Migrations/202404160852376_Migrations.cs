namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Account_ID = c.Int(nullable: false, identity: true),
                        Account_Username = c.String(nullable: false),
                        Account_Password = c.String(nullable: false),
                        Customer_ID = c.Int(nullable: false),
                        Account_UserRoleEnum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Account_ID)
                .ForeignKey("dbo.Staffs", t => t.Customer_ID, cascadeDelete: true)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Customer_ID = c.Int(nullable: false, identity: true),
                        Customer_FName = c.String(nullable: false, maxLength: 35),
                        Customer_BirthDay = c.DateTime(nullable: false, storeType: "date"),
                        Customer_Gender = c.Boolean(nullable: false),
                        Staff_FirsDayOfWork = c.DateTime(),
                        Staff_Posistion = c.String(maxLength: 20),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Customer_ID);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Address_ID = c.Int(nullable: false, identity: true),
                        Address_String = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Address_ID);
            
            CreateTable(
                "dbo.AddressOfCustomers",
                c => new
                    {
                        Address_ID = c.Int(nullable: false),
                        Customer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Address_ID, t.Customer_ID })
                .ForeignKey("dbo.Addresses", t => t.Address_ID, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.Customer_ID, cascadeDelete: true)
                .Index(t => t.Address_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Image_ID = c.Int(nullable: false, identity: true),
                        Image_URL = c.String(nullable: false),
                        Phone_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Image_ID)
                .ForeignKey("dbo.Phone", t => t.Phone_ID, cascadeDelete: true)
                .Index(t => t.Phone_ID);
            
            CreateTable(
                "dbo.Phone",
                c => new
                    {
                        Phone_ID = c.Int(nullable: false, identity: true),
                        Phone_Name = c.String(nullable: false, maxLength: 50),
                        Phone_Color = c.String(nullable: false, maxLength: 7),
                        Phone_Price = c.Double(nullable: false),
                        Phone_ReadyInStock = c.Int(nullable: false),
                        Manufacturer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Phone_ID)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer_ID, cascadeDelete: true)
                .Index(t => t.Manufacturer_ID);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Manufacturer_ID = c.Int(nullable: false, identity: true),
                        Manufacturer_Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Manufacturer_ID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetail_ID = c.Int(nullable: false, identity: true),
                        OrderDetail_Quantity = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Phone_ID = c.Int(nullable: false),
                        Order_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetail_ID)
                .ForeignKey("dbo.Orders", t => t.Order_ID, cascadeDelete: true)
                .ForeignKey("dbo.Phone", t => t.Phone_ID, cascadeDelete: true)
                .Index(t => t.Phone_ID)
                .Index(t => t.Order_ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Order_ID = c.Int(nullable: false, identity: true),
                        Order_TotalAmount = c.Double(nullable: false),
                        Customer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Order_ID)
                .ForeignKey("dbo.Staffs", t => t.Customer_ID, cascadeDelete: true)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.PhoneNumber",
                c => new
                    {
                        PhoneNumber_ID = c.Int(nullable: false, identity: true),
                        PhoneNumber_Number = c.String(nullable: false, maxLength: 10),
                        Customer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneNumber_ID)
                .ForeignKey("dbo.Staffs", t => t.Customer_ID, cascadeDelete: true)
                .Index(t => t.Customer_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhoneNumber", "Customer_ID", "dbo.Staffs");
            DropForeignKey("dbo.OrderDetails", "Phone_ID", "dbo.Phone");
            DropForeignKey("dbo.OrderDetails", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Customer_ID", "dbo.Staffs");
            DropForeignKey("dbo.Images", "Phone_ID", "dbo.Phone");
            DropForeignKey("dbo.Phone", "Manufacturer_ID", "dbo.Manufacturers");
            DropForeignKey("dbo.AddressOfCustomers", "Customer_ID", "dbo.Staffs");
            DropForeignKey("dbo.AddressOfCustomers", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.Accounts", "Customer_ID", "dbo.Staffs");
            DropIndex("dbo.PhoneNumber", new[] { "Customer_ID" });
            DropIndex("dbo.Orders", new[] { "Customer_ID" });
            DropIndex("dbo.OrderDetails", new[] { "Order_ID" });
            DropIndex("dbo.OrderDetails", new[] { "Phone_ID" });
            DropIndex("dbo.Phone", new[] { "Manufacturer_ID" });
            DropIndex("dbo.Images", new[] { "Phone_ID" });
            DropIndex("dbo.AddressOfCustomers", new[] { "Customer_ID" });
            DropIndex("dbo.AddressOfCustomers", new[] { "Address_ID" });
            DropIndex("dbo.Accounts", new[] { "Customer_ID" });
            DropTable("dbo.PhoneNumber");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Phone");
            DropTable("dbo.Images");
            DropTable("dbo.AddressOfCustomers");
            DropTable("dbo.Addresses");
            DropTable("dbo.Staffs");
            DropTable("dbo.Accounts");
        }
    }
}
