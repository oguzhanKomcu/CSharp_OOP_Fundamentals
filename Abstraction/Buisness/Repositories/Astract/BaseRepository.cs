using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Buisness.Repositories
{
    public abstract class BaseRepository<T> //By passing "T" type, I ensure that my methods and properties are used in other classes according to the desired type.
    {

        public abstract void Create(T entity); 
        public abstract void Update(T entity);
        public abstract void Delete(T entity);



        public abstract T GetById(int id);


        public abstract List<T> GetAll();



    }
}
