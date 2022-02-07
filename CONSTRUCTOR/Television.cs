using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR
{
    class Television
    {

        //Property = Property combines fields and methods.It consists of two code blocks.
        //These are the get and set methods.By controlling the get and set methods, we can control the received data under the conditions we want.


        //Shortcut = prop+tab+tab
        public string Brand { get; set; }
        public string SmartTv { get; set; }
        public string DisplayTechnology { get; set; }
        public string Resolution { get; set; }
        public string ScreenSize { get; set; }
        public decimal Price { get; set; }



        //We did it without adding parameters to the constructor here.
        //This is actually a constructor that is assigned by default.
        //If we didn't do this, we made it with parameters and implemented it like this, "new class();" We would get an error.
        //It asks us to enter the parameter.
        public Television()
        {

        }


        //The constructor runs directly when the class is instantiated.
        //It adds value to its parameters and returns the property value.
        //It must be the same as the class name.

        public Television(string Brand, string screensize ,decimal price)
        {

            //With the "this." keyword, we have specified the property that we want to assign a value to in the class.
            this.Brand = Brand;
            this.ScreenSize = screensize;

            //The "this" keyword is here by default.
            Price = price;


        }

        //I can create more than one constructor with the same name as in the same methods.
        //However, the same rule applies here. Order, type, variable of the given parameters must be different.
        public Television(string Resolution, string SmartTV,string DisplayTechnology)
        {

            this.Resolution = Resolution;   
            this.SmartTv = SmartTV;  
            this.DisplayTechnology = DisplayTechnology;

            //I wanted MessageBox.Show() to run directly when the class is started.

            MessageBox.Show($"Resolution : {this.Resolution}\nSmart Tv : {this.SmartTv}\nDisplay Technology : {this.DisplayTechnology} ");
                
        }

        




    }
}
