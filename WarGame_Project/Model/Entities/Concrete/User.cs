using Abstraction.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame_Project.Model.Entities.Concrete
{
    public  class User : BaseEntity<int>
    {

        public override int Id { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }

        public int Point { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {

                if (value > 18)
                {
                    age = value;
                }
                else
                {
                    MessageBox.Show("Children under 18 cannot register for this game!!");
                    TextBox textBox = new TextBox();
                    if (textBox.Name == "textBirtyear")
                    {
                        textBox.Text = "";
                    }
                }



            }
        }

    }
}
