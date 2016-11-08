using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Domain.Enitites;

namespace application.Domain.Abstract
{
    public interface IRoshtoryReopository
    {
        IQueryable<Rolshtory> rolshtorys { get; }
    }
}
