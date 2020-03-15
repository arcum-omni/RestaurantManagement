namespace RestaurantManagement
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Linq;

    public class RestaurantContext : DbContext
    {
        #region Auto-Generated Comments
        // Your context has been configured to use a 'RestaurantContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'RestaurantManagement.RestaurantContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RestaurantContext' 
        // connection string in the application configuration file.
        #endregion

        public RestaurantContext()
            : base("name=RestaurantContext")
        {
        }

        #region Auto-Generated Comments
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        #endregion

        public virtual DbSet<FinancialAccount> FinancialAccounts { get; set; }

        public virtual DbSet<RawMaterial> RawMaterials { get; set; }

        public virtual DbSet<FoodItem> FoodItems { get; set; }

        public virtual DbSet<ItemMatl> ItemMatls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemMatl>()
                .HasKey(x => new { x.ItemId, x.RawMatlId });
        }
    }
}