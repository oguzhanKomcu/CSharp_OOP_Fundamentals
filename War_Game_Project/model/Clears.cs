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

            foreach (Control control in groupBox.Controls) // elemanları siliyoruz..
            {
                if (control is MaskedTextBox) //tc ve phone maskedtxtbox oldugu için onları silicek..
                {
                    control.Text = String.Empty;
                }
                else if (control is TextBox)  //textboxları silicek
                {
                    control.Text = String.Empty;
                }
            }
        }


    }
}
