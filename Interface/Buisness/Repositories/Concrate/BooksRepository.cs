using Abstraction.Buisness.Data;
using Abstraction.Model.Concrete;
using Interface.Buisness.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Buisness.Repositories.Concrate
{
    public class BooksRepository : BaseRepository<Books> , BookInterface  //It gave an error the first time I wrote it. I assigned the namespace to my usings by doing "ctrl + . ".
    {                                                                     //Later, since it is a rule maker, it required the method in this class even if it has no sign. Again, I added my                                                                        method to my class by doing "ctrl + . ".


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

        public List<Books> UnıtStock(Books entity)  //Here I created the body of my method.
        {

            return DataBooks.books.Where(x => x.Stock == 10 && x.Stock == 50).ToList();


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
