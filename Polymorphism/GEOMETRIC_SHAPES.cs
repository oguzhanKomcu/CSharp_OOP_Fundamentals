using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    interface IGEOMETRIC_SHAPES  
    {
        //I have a method with a common function that I can use in classes.This method may vary in inherited subclasses according to their own properties.This is how we apply polymorphism.
        double AREA_ACCOUNT(double lenght1, double lenght2);


    }

    public class Rectangle : IGEOMETRIC_SHAPES
    {
        public double AREA_ACCOUNT(double lenght1, double lenght2)
        {
          

            return lenght1 * lenght2;   
        }

      
         


    }
    public class Triangle: IGEOMETRIC_SHAPES
    {
        public double AREA_ACCOUNT(double lenght1, double lenght2)
        {
            return lenght1 * lenght2 /2;
        }
    }
    public class Square : IGEOMETRIC_SHAPES
    {
        public double AREA_ACCOUNT(double lenght1 , double lenght2)
        {
            lenght2 = 0 ;
            return lenght1 * lenght1;
        }
    }
}
