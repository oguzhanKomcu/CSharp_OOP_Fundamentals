using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame_Project.Model.Entities.Concrete;

namespace WarGame_Project.Business.Repositories.Interface
{
     interface IWarCharacter
    {

        int DL(WarCharacter entity);
        int TS(WarCharacter entity);
        int PS(WarCharacter entity);
        int WS(WarCharacter entity);

        int RS(WarCharacter entity);
        int Totalstrentgh(int id);




    }
}
