using System;

namespace eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente c1 = new cliente("hola");
            Console.WriteLine(c1.Nombre);
            Console.WriteLine(c1.Edad);
            Console.WriteLine(c1.Cuenta);
            Console.WriteLine(cliente.mensaje());
            c1.Depositar(5000);
            Console.WriteLine(c1.Dinero);
            Console.ReadKey();
        }
    }
}
