using Abstraction.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Buisness.Repositories.Interface
{
    interface IBookInterface //
    {

        //Here I performed a special Crud operation on my "book " entity. If I had implemented it in an abstract class. I would have to use it in other classes that would not use it because it would be abstract, but now I would not have to use it in other classes since I implemented this method in the interface.
        List<Books> UnıtStock(Books entity);  





    }
}
