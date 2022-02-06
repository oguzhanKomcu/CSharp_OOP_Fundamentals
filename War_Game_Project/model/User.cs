using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Game_Project.model
{
    class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }

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
                    textBox.Text = "";
                }



            }
        }

        public void Eraser(GroupBox groupBox)
        {

            foreach (Control control in groupBox.Controls) 
            {
                if (control is MaskedTextBox) 
                {
                    control.Text = String.Empty;
                }
                else if (control is TextBox)  
                {
                    control.Text = String.Empty;
                }
            }
        }
    }
}
