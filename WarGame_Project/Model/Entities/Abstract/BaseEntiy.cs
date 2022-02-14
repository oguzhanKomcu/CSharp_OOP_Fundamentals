using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame_Project.Model.Entities.Enum;

namespace WarGame_Project.Model.Entities.Abstract
{
    public abstract class BaseEntiy<T>
    {

        public abstract T Id { get; set; }


        DateTime _createDate = DateTime.Now;

        public DateTime CreateDate
        {

            get => _createDate;

            set => _createDate = value;
        }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status
        {
            get => _status;
            set => _status = value;

        }

      

    }

}
