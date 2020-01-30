namespace RestaurantManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        AccountName = c.String(),
                        AccountDescription = c.String(),
                        AccountBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.FoodItems",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        ItemDescription = c.String(),
                        ItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ItemId);
            
            CreateTable(
                "dbo.RawMaterials",
                c => new
                    {
                        RawMatlId = c.Int(nullable: false, identity: true),
                        RawMatlName = c.String(),
                        RawMatlDescription = c.String(),
                        RawMatlQuantity = c.Int(nullable: false),
                        RawMatlCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FoodItem_ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.RawMatlId)
                .ForeignKey("dbo.FoodItems", t => t.FoodItem_ItemId)
                .Index(t => t.FoodItem_ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RawMaterials", "FoodItem_ItemId", "dbo.FoodItems");
            DropIndex("dbo.RawMaterials", new[] { "FoodItem_ItemId" });
            DropTable("dbo.RawMaterials");
            DropTable("dbo.FoodItems");
            DropTable("dbo.BankAccounts");
        }
    }
}
