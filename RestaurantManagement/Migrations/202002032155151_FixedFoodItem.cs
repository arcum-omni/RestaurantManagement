namespace RestaurantManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedFoodItem : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.RawMaterials", new[] { "FoodItem_ItemId" });
            AlterColumn("dbo.RawMaterials", "FoodItem_ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.RawMaterials", "FoodItem_ItemId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.RawMaterials", new[] { "FoodItem_ItemId" });
            AlterColumn("dbo.RawMaterials", "FoodItem_ItemId", c => c.Int());
            CreateIndex("dbo.RawMaterials", "FoodItem_ItemId");
        }
    }
}
