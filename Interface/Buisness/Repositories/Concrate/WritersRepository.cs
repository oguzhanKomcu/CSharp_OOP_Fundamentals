using Abstraction.Buisness.Data;
using Abstraction.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Buisness.Repositories.Concrate
{
    public class WritersRepository : BaseRepository<Writers>
    {
        public override void Create(Writers entity)
        {
           DataWriters.writers.Add(entity); 
        }

        public override void Delete(Writers entity)
        {
            entity.Status = Model.Status.Passive;
        }

        public override List<Writers> GetAll()
        {
            return DataWriters.writers.ToList(); 
        }

        public override Writers GetById(int id)
        {
           Writers writersfind = new Writers();
            foreach (Writers writer in DataWriters.writers)
            {
                if(writer.Id == id )
                {
                    writersfind = writer;    

                }
            }

            return writersfind; 

        }

        public override void Update(Writers entity)
        {
           Writers writer = GetById(entity.Id); 

            writer.Name = entity.Name;
            writer.LastName = entity.Name;


        }
    }
}
