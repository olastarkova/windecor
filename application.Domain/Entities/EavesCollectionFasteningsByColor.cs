using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Domain.Enitites
{
   public class EavesCollectionFasteningsByColor
    {
        public int Id { get; set; }

        public virtual EavesCollectionFastenings eavesCollectionFasteningsEntity { get; set; }
        public virtual EavesColor eavesColors { get; set; }
    }
}
