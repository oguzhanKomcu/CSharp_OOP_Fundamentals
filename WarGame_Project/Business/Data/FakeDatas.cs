using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame_Project.Model.Entities.Concrete;

namespace WarGame_Project.Business.Data
{
    public static class  FakeDatas
    {



        public static List<User> users = new List<User>()
        {

            new User { Id = 1, FirstName = "Hakan" , LastName = "SÖNMEZ" , NickName = "Nemesis" , Age = 26 , Point = 700 }


        };

        public static  List<WarCharacter> warCharacters = new List<WarCharacter>()
        {
            new WarCharacter { Id =1 , Rank = "Second Lieutenant (2LT)", Physic = "RICKETY" , Weapon = "AK-47", Talent = "INTELLIGENT" }

        };



    }
}
