namespace Cashbox.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cashbox.Models.DataContext>
    {
       


        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";

            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(Cashbox.Models.DataContext context)
        {


            if (context.StoreProducts.Count() == 0 && context.Products.Count() == 0)
            {
                var storedProducts = new List<StoredProduct>()
                {
                    new StoredProduct() {
                        Product = new Product() { Code = "123" , Name="test 1", Price = 11 }, Count = 100 
                    }
                    , new StoredProduct() {
                        Product = new Product() { Code = "234" , Name="test 2", Price = 22 }, Count = 200 
                    }
                    , new StoredProduct() {
                        Product = new Product() { Code = "345" , Name="test 3", Price = 333 }, Count = 300 
                    }
                };

                context.StoreProducts.AddRange(storedProducts);
                context.SaveChanges();
            }


        
        }
    }
}
