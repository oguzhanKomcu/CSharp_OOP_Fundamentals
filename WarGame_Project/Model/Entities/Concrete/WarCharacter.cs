using Abstraction.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame_Project.Model.Entities.Concrete
{
    public class WarCharacter : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Rank { get; set; }
        public string Weapon { get; set; }
        public string Physic { get; set; }
        public string Talent { get; set; }

       
        public string Diffucality_Level { get; set; }
        public DateTime? UpdateDate { get; internal set; }
        public DateTime? DeleteDate { get; internal set; }

    }
}
