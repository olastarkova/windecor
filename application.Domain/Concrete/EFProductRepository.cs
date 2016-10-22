using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Domain.Abstract;
using application.Domain.Enitites;

namespace application.Domain.Concrete
{
    public class EFProductRepository : IroshtoryReopository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<rolshtory> rolshtorys
        {
            get { return context.rolshtorys; }
        }


    }
}
