using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Domain.Enitites
{
   public class Rolsize
   {
        public int Id { get; set; }
        public string Size { get; set; }
        public int TypyId { get; set; }
        public bool IsDayNight { get; set;}

        public virtual RolTypes typesCollection { get; set; }
   }
}
