using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Domain.Enitites
{
    public class Rolcollection_colors
    {
        public int ID { get; set; }
        public String number { get; set; }

        public virtual Product collectionEntity { get; set; }
        public virtual Rolcolors colorsEntity { get; set; }

    }
}
