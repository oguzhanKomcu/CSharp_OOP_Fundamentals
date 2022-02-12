using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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





    }
}
