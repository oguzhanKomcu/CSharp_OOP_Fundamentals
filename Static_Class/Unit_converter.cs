using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{

    //When creating a static class, we must write "static" in the class identifier to indicate that it is a static class.
    public static class Unit_converter
    {
        //Its members must be strictly static..
        //public  static double+function_name+(type parametre)
        //You can create our own functions in the number of parameters we want within the framework of these rules.
        public static double KmToCmConverter(double km)
        {


            double total = km * _1cm;

            return total;

        }

        public static double DekarToM2Converter(double dekar)
        {
            return dekar * _1m2;
        }

        public static double FitToM(double feet)
        {
            return feet * _1m;
        }



        public const double _1cm = 100000;
        public const double _1m2 = 1000;
        public const double _1m = 0.3048;
    }
}
