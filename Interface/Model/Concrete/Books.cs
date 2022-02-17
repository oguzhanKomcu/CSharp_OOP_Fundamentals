using Abstraction.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Model.Concrete
{
    public class Books : BaseEntity<int>
    {

        public override int Id { get; set; }

        public string Release_Date { get; set; } 
        public string Number_Of_Pages { get; set; }
        public int Stock { get; set; }      
        public decimal Price { get; set; }  

    }
}
