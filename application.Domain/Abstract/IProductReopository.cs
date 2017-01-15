﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using application.Domain.Enitites;

namespace application.Domain.Abstract
{
    public interface IProductReopository
    {
        IQueryable<Product> Products { get; }
        IQueryable<rolcategory> rolCategories { get; }
        IQueryable<Rolcollection_colors> Rolcollections { get; }
        IQueryable<Rolcolors> rolColors { get; }
        IQueryable<Rolsize> rolSize { get; }
        IQueryable<RolTypes> rolTypes { get;}

        void SaveProduct(Product rolshtory);
    }
}
