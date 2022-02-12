using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame_Project.Business.Repositories.Abstract
{
    public abstract class BaseRepository<T>
    {

        public abstract T Create(T entity);
        public abstract T Update(T entity);
        public abstract T Delete(T entity);


        public abstract List<T> GetAll(T entity);

        public abstract List<T> GetById(T entity);

       



        










    }
}
