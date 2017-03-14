using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Domain.Enitites
{
    public class PipesColor
    {
        public int Id { get; set; }
        
        public virtual Pipe pipesEntity { get; set; }
        public virtual EavesCollection eavesCollectionEntity { get; set; }
        public virtual EavesColor eavesColorsEntity { get; set; } 
    }
}
