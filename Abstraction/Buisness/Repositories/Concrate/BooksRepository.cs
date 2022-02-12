using Abstraction.Buisness.Data;
using Abstraction.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Buisness.Repositories.Concrate
{
    public class BooksRepository : BaseRepository<Books>
    {
        public override void Create(Books entity)
        {
           DataBooks.books.Add(entity); 
        }

        public override void Delete(Books entity)
        {
            entity.Status = Model.Status.Passive;
        }

        public override List<Books> GetAll()
        {
            var bookslist = DataBooks.books.ToList();
            return bookslist; 
        }

        public override Books GetById(int id)
        {
            Books findedbooks = new Books();

            foreach (Books books in DataBooks.books )
            {
                if(books.Id == id)
                {
                    findedbooks = books;
                }
            }
            return findedbooks;

        }



        public override void Update(Books entity)
        {
            Books books = GetById(entity.Id);


            books.Name = entity.Name;
            books.Stock = entity.Stock;
            books.Price = entity.Price;

        }
    }
}
