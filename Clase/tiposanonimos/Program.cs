using System;

namespace tiposanonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonimo = new
            {
                Modelo = "Bocho",
                Precio = 8000,
                Placas = "hola123"
            };

            Console.WriteLine(anonimo.Modelo);
            Console.WriteLine(anonimo.Precio);
            Console.WriteLine(anonimo.Placas);



        }
    }
}
