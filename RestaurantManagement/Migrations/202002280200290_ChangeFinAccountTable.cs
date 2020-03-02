namespace RestaurantManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFinAccountTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BankAccounts", newName: "FinancialAccounts");
            AlterColumn("dbo.FinancialAccounts", "AccountName", c => c.String(nullable: false));
            AlterColumn("dbo.FoodItems", "ItemPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.RawMaterials", "RawMatlCost", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RawMaterials", "RawMatlCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodItems", "ItemPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FinancialAccounts", "AccountName", c => c.String());
            RenameTable(name: "dbo.FinancialAccounts", newName: "BankAccounts");
        }
    }
}
