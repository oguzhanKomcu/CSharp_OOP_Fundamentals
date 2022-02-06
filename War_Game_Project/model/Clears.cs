using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Game_Project.model
{
    static  class Clears
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


    }
}
