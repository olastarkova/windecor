using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Domain.Enitites
{
    public class EavesCollectionType
    {
        public int Id { get; set; }
        
        public virtual EavesCatogory eavesCategoriesEntity { get; set; }
        public virtual EavesType eavesTypesEntity { get; set; }
    }
}
