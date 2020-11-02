using ProductApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Infrastructure.SQLLite.Data
{
    public class DBInitializer: IDBInitializer
    {
        public void SeedDB(ProductAppLiteContext ctx) 
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            ctx.Products.Add(new Product()
            {
                Name = "James Bond",
                Price = 007,
                Color = "Red",
                Type = "Spy",
            });
            ctx.SaveChanges();
        }
    }
}
