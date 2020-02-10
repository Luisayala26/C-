using System;

namespace eje8
{
    class Program
    {
        static void Main(string[] args)
        {
            //objetos y metos de Auto
            Auto a1 = new Auto();
            a1.marca = "BMW";
            a1.puertas = 4;
            a1.estandar = true;
            Auto a2 = new Auto("Nissan",4,true);
            Auto a3 = new Auto("Ferrari",2,true);

            a1.Arrancar();
            a3.Des();
            a2.Tipo(false);
            Console.WriteLine("{0} {1} {2}",a1.marca,a1.puertas,a1.estandar);
            a2.Info();
            a3.Info();

        }
    }
}
