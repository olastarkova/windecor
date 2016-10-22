using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using application.Domain.Enitites;

namespace application.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<rolshtory> rolshtorys { get; set; }
    }
}
