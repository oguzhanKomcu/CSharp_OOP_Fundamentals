﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Model.Abstract
{
    public abstract class BaseEntity<T>
    {

        public abstract T Id { get; set; }  
        public string Name { get; set; }

        private DateTime _createdDate = DateTime.Now;
        public DateTime CreateDate
        {
            get => _createdDate;
            set => _createdDate = value;

        }


        private Status _status = Status.Modified;
        public Status Status
        {
            get => _status;
            set => _status = value;

        }



    }
}
