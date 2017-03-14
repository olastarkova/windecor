using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Domain.Enitites
{
    public class EavesCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

        public virtual EavesCatogory eavesCategoriesEntity { get; set; }
        public virtual EavesVendor eavesVendorsEntity { get; set; }
    }
}
