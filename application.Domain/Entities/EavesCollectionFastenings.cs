using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Domain.Enitites
{
    public class EavesCollectionFastenings
    {
        public int Id { get; set; }
        
        public virtual EavesCollection eavesCollectionEntity { get; set; }
        public virtual EavesType eavesTypesEntity { get; set; }
        public virtual EavesFastening eavesFasteningsEntity { get; set; }
    }
}
