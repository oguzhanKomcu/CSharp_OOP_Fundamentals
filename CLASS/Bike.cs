using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    class Bike
    {
        //If we want our members in the class to be accessed from outside, we should make it public. If we don't want it to be accessed and we put private at the beginning, it will be inaccessible. If we don't put anything at the beginning of another field, it will already be private by default.

        //If I have both public and private fields in the class, this class is now internal and it defines it directly by default. It can also be added to the access modifier of the class if desired.

        string a; //This field is no longer accessible from the outside.

        public string Brand;
        public int RimSize;
        public string Material;
        public string Type;
        public string Gender;
        public int Gear;
        public int Price;
        public string Color;


    }
}
