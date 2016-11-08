using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Domain.Abstract;
using application.Domain.Enitites;

namespace application.Domain.Concrete
{
    public class EFProductRepository : IRoshtoryReopository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Rolshtory> rolshtorys
        {
            get { return context.rolshtorys; }
        }


    }
}
