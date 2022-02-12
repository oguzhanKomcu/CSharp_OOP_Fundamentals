using Abstraction.Buisness.Data;
using Abstraction.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Buisness.Repositories.Concrate
{
    public class CategoryRepository : BaseRepository<Categories>
    {
        public override void Create(Categories entity)
        {
           DataCategories.categories.Add(entity);   
        }

        public override void Delete(Categories entity)
        {
            entity.Status = Model.Status.Passive;
        }

        public override List<Categories> GetAll()
        {
            var categorieslist = DataCategories.categories.ToList();
            return categorieslist;
        }

        public override Categories GetById(int id)
        {
            Categories categoriesfied = new Categories();
            
            foreach(Categories categories in DataCategories.categories)
            {
                if (categories.Id == id   )
                {
                    categoriesfied = categories;

                }
            }

            return categoriesfied;

        }

        public override void Update(Categories entity)
        {
            
            Categories categories = GetById(entity.Id);

            categories.Name = entity.Name;


        }
    }
}
