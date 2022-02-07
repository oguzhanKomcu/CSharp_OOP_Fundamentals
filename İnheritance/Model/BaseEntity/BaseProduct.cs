using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance.Model.ProductBase
{
    public class BaseProduct
    {
        //We have defined the properties, which are the common properties of the products, in this class.
        //In this way, other classes inheriting from this class will be able to access these props directly.

        public string Brand { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public int UnitsStock { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }

      
    }
}
