namespace SupplierManagemenet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        InventoryId = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                        SupItemId = c.Int(nullable: false),
                        Item = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InventoryId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        SupplierItemId = c.Int(nullable: false),
                        StaffType = c.String(),
                        OrderStatus = c.String(),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        ItemName = c.String(),
                        SupplierName = c.String(),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.SupplierItems",
                c => new
                    {
                        SupplierItemId = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        ItemName = c.String(),
                    })
                .PrimaryKey(t => t.SupplierItemId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                        SupplierContact = c.String(),
                        SupplierEmail = c.String(),
                        SupplierPassword = c.String(),
                    })
                .PrimaryKey(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suppliers");
            DropTable("dbo.SupplierItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Inventories");
        }
    }
}
