using Abstraction.Buisness.Repositories;
using Abstraction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WarGame_Project.Business.Data;
using WarGame_Project.Business.Repositories.Interface;
using WarGame_Project.Model.Entities.Concrete;


namespace WarGame_Project.Business.Repositories.Concrete
{
    public class UserRepository : BaseRepository<User> , IUser
    {
        public override void Create(User entity)
        {
            FakeDatas.users.Add(entity);
            this.GetIp(entity);
        }

        public override void Delete(User entity)
        {
            entity.Status = Status.Passive;
            this.GetIp(entity);
        }

        public override List<User> GetAll()

        {

            List<User> users = FakeDatas.users.ToList();
            return users;
        }

        public override User GetById(int id)
        {

            User usersfinded = new User();
            foreach (User user in FakeDatas.users)
                if (user.Id == id)
                {
                    usersfinded = user;
                }


            return usersfinded;
        }

        public override void Update(User entity)
        {


            User user = GetById(entity.Id);


            user.NickName = entity.NickName;
            user.UpdateDate = DateTime.Now;
            user.Status = Status.Modified;
            this.GetIp(entity);

        }
       

        public string GetIp(User entity)
        {
            foreach (IPAddress ıPAddress in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                entity.Ip = ıPAddress.ToString();
            }
            return entity.Ip;

        }

        
    }
}
