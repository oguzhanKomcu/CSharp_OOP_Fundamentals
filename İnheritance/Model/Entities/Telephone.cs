using İnheritance.Model.ProductBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance.Model.Entities
{
    public class Telephone : BaseProduct
    {
        public int battery_power { get; set; }
        public int Internal_Memory { get; set; }
        public int Camera_Resolution { get; set; }
        public string Screen_size { get; set; }

    }
}
