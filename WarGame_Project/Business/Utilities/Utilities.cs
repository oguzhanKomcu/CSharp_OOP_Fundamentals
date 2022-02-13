using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame_Project.Business.Data;

namespace WarGame_Project.Business.Utilities
{
    public static class Utilities
    {


        public static void Eraser(GroupBox groupBox)
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


        public static  bool TextControl (GroupBox groupbox)
        {
            bool result = false;
            foreach (Control control in groupbox.Controls)
            {
                if (control is MaskedTextBox  )
                {

                    if (String.IsNullOrWhiteSpace(control.Text) || String.IsNullOrWhiteSpace(control.Text) || String.IsNullOrWhiteSpace(control.Text) || String.IsNullOrWhiteSpace(control.Text))
                    {
                        MessageBox.Show("Please enter information..!");
                        result = true;  
                    }

                }
                else if (control is TextBox)
                {
                    if (String.IsNullOrWhiteSpace(control.Text) || String.IsNullOrWhiteSpace(control.Text) || String.IsNullOrWhiteSpace(control.Text) || String.IsNullOrWhiteSpace(control.Text))
                    {
                        MessageBox.Show("Please enter information..!");
                        result = true;
                    }
                }
            }

            return result;
        }


        public static bool Nicknamecontrol(TextBox nickname )
        {

            
            bool resault = false;   
            

            foreach (var item in FakeDatas.users)
            {
                if(nickname.Text == item.NickName )
                {
                    MessageBox.Show("This username is a compliment.");
                    nickname.Text =String.Empty;    
                    resault = true;
                }
               
            }
            return  resault;    
        }




    }
}
