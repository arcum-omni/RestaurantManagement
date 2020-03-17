namespace RestaurantManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixManyToMany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RawMaterials", "FoodItem_ItemId", "dbo.FoodItems");
            DropIndex("dbo.RawMaterials", new[] { "FoodItem_ItemId" });
            CreateTable(
                "dbo.ItemMatls",
                c => new
                    {
                        ItemId = c.Int(nullable: false),
                        RawMatlId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ItemId, t.RawMatlId })
                .ForeignKey("dbo.FoodItems", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.RawMaterials", t => t.RawMatlId, cascadeDelete: true)
                .Index(t => t.ItemId)
                .Index(t => t.RawMatlId);
            
            DropColumn("dbo.RawMaterials", "FoodItem_ItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RawMaterials", "FoodItem_ItemId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ItemMatls", "RawMatlId", "dbo.RawMaterials");
            DropForeignKey("dbo.ItemMatls", "ItemId", "dbo.FoodItems");
            DropIndex("dbo.ItemMatls", new[] { "RawMatlId" });
            DropIndex("dbo.ItemMatls", new[] { "ItemId" });
            DropTable("dbo.ItemMatls");
            CreateIndex("dbo.RawMaterials", "FoodItem_ItemId");
            AddForeignKey("dbo.RawMaterials", "FoodItem_ItemId", "dbo.FoodItems", "ItemId");
        }
    }
}
