namespace Cashbox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        Check_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Checks", t => t.Check_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Check_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Checks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateCreate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 10, unicode: false, storeType: "nvarchar"),
                        Name = c.String(maxLength: 256, unicode: false, storeType: "nvarchar"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StoredProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.StoredProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.CheckProducts", "Check_Id", "dbo.Checks");
            DropIndex("dbo.CheckProducts", new[] { "Product_Id" });
            DropIndex("dbo.StoredProducts", new[] { "Product_Id" });
            DropIndex("dbo.CheckProducts", new[] { "Check_Id" });
            DropTable("dbo.StoredProducts");
            DropTable("dbo.Products");
            DropTable("dbo.Checks");
            DropTable("dbo.CheckProducts");
        }
    }
}
