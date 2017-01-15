using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using application.Domain.Enitites;

namespace application.WebUI.Models
{
    public class ProductsListViewModel 
    {
        public IQueryable<Product> Products { get; set;}
        public IQueryable<rolcategory> rolCategories { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }

    }
}