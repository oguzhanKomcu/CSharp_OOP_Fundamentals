using İnheritance.Model.ProductBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance.Model.Entities
{
   public class Dishwasher : BaseProduct
    {
        public string EnergyClass { get; set; } 
        public string Volume_L { get; set; }

       public int sound_level_db { get; set; }  
        
       public int width { get; set; }
        public int depth { get; set; }
        public int height { get; set; }



    }
}
