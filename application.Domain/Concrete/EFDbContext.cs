using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using application.Domain.Enitites;
using application.Domain.Concrete;

namespace application.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
        {
            Database.SetInitializer<EFDbContext>(new ApplicationDbIntializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rolcategory> rolCategories { get; set; }
        public DbSet<Rolcollection_colors> rolcollection { get; set; }
        public DbSet<Rolcolors> rolColors { get; set; }
        public DbSet<Rolsize> rolSize { get; set; }
        public DbSet<RolTypes> rolTypes { get; set; }
    }
}
