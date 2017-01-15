using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace application.Domain.Enitites
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //public string Category { get; set; }
        //public int RolcategoryID { get; set; }

        public virtual rolcategory CategoryEntity { get; set; }
        //public virtual Rolcollection_colors Rolcollection_colorEntity { get; set; }
    }
}
