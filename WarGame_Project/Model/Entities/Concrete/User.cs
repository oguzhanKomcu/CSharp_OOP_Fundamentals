using Abstraction.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame_Project.Business.Data;
using WarGame_Project.Business.Utilities;

namespace WarGame_Project.Model.Entities.Concrete
{
    public class User : BaseEntity<int>
    {


        public override int Id { get; set; }     // property
        
        public string FirstName { get; set; }    // property
        public string LastName { get; set; }    // property


        public string NickName { get; set; }        // property



        public int Point { get; set; }

       

        private int age;     //I apply encapculation to check the entered age. Thus, I can directly check the entered data from the user.

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

        public DateTime? UpdateDate { get; internal set; }
        public DateTime? DeleteDate { get; internal set; }

      
    }
}
