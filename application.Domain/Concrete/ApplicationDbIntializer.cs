using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using application.Domain.Enitites;

namespace application.Domain.Concrete
{
    class ApplicationDbIntializer :DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            var category = new rolcategory
            {
                Category = "День-ночь",
                Id = 1  
            };

            var category2 = new rolcategory
            {
                Category = "Класические",
                Id = 2
            };

            context.Products.Add(new Product
            {
                Id = 1,
                Description= "Description",
                Name = "Product1",
                Price = 10,
                CategoryEntity = category
                
            });
            context.Products.Add(new Product
            {
                Id = 2,
                Description = "Description",
                Name = "Product2",
                Price = 20,
                CategoryEntity = category2
                
            });
            context.rolCategories.Add(category);
            context.SaveChanges();
        }
    }
}
