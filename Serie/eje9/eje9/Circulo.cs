using System;
using System.Collections.Generic;
using System.Text;
/*Se implementan las funciones math para las funciones Area 
 Math.Pow elevar el numero 
 Math.PI valor de PI
 Math.Abs valor absoluto

     */
namespace eje9
{
    class Circulo
    {
        public double r;
        public double Area() 
        {
            return Math.PI * Math.Pow(Math.Abs(r),2);
        }
    }
    class Cuadrado 
    {
        public double l;
        public double Area()
        {
            return Math.Pow(Math.Abs(l), 2);
        }
    }

}
