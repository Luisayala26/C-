using System;

namespace cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //concatenacion de cadenas
            Console.WriteLine("Hola"+"mundo");
            Console.WriteLine(string.Concat("HOLA","MUNDO"));

            string cadena = "Esta es una cadena de prueba";
            Console.WriteLine(cadena);
            Console.WriteLine(cadena.Length);
            Console.WriteLine(cadena.ToUpper()+" "+cadena.ToLower());
            Console.WriteLine(cadena.Replace("es","XDXDXD"));
            Console.WriteLine(cadena[0]);
            Console.WriteLine(cadena.Substring(1,8));
            foreach(var x in cadena.Split(" "))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("cadena contiene \"es\" " + cadena.Contains("es"));


            int naranjas = 8;
            int platanos = 2;
            int manzanas = 6;

            string ejemplo = string.Format("hay {0} platanos, {1} naranjas y {2} manzanas",platanos,naranjas,manzanas);
            Console.WriteLine(ejemplo);
            Console.WriteLine("Pi: {0:0.00}",Math.PI);
            Console.WriteLine("Numeros: {0:N}", 126);
            Console.WriteLine("Potencia: {0:E}", 126);
            Console.WriteLine("Moneda: {0:C}", 126);
            Console.WriteLine("Porcentaje: {0:P}", 126);
            Console.WriteLine("Hexa: {0:X}", 126);
        }
    }
}
