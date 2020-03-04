namespace RestaurantManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinDataTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FoodItems", "ItemPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.RawMaterials", "RawMatlCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RawMaterials", "RawMatlCost", c => c.Double(nullable: false));
            AlterColumn("dbo.FoodItems", "ItemPrice", c => c.Double(nullable: false));
        }
    }
}
