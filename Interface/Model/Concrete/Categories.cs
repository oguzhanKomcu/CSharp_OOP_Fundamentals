using Abstraction.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Model.Concrete
{
    public class Categories : BaseEntity<int>
    {
        public override int Id { get; set; }
        
    }

}
