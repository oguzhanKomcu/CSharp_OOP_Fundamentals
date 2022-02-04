using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{

    //When creating a static class, we must write "static" in the class identifier to indicate that it is a static class.
    static class Unit_converter
    {
        //Its members must be strictly static.
        //public  static double+function_name+(type parametre)
        //You can create our own functions in the number of parameters we want within the framework of these rules.
        public static double KmToCmConverter(double km)
        {


            double total = km * 100000;

            return total;

        }

        public static double DekarToM2Converter(double dekar)
        {
            return dekar * 1000;
        }

        public static double FitToM(double feet)
        {
            return feet * 0.3048;
        }




    }
}
