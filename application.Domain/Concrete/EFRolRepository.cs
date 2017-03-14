using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Domain.Abstract;
using application.Domain.Enitites;

namespace application.Domain.Concrete
{
    public class EFRolRepository : IRolReopository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }
        public IQueryable<Rolcategory> rolCategories
        {
            get { return context.rolCategories; }
        }
        public IQueryable<Rolcollection_colors> Rolcollections
        {
            get { return context.rolcollection; }
        }
        public IQueryable<Rolcolors> rolColors
        {
            get { return context.rolColors; }
        }
        public IQueryable<Rolsize> rolSize
        {
            get { return context.rolSize; }
        }
        public IQueryable<RolTypes> rolTypes
        {
            get { return context.rolTypes; }
        }

        public void SaveProduct(Product rolshtory)
        {
            if (rolshtory.Id == 0)
            {
                context.Products.Add(rolshtory);
            }  
            context.SaveChanges();
        }

    }
}
