using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Domain.Enitites
{
    public class EavesItemsColor
    {
        public int Id { get; set; }
        
        public virtual EavesCollectionItem eavesCollectionItemsEntity { get; set; }
        public virtual EavesColor eavesColorsEntity { get; set; }
    }
}
