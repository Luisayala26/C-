using System;

namespace Excepciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa un valo para la raiz cuadrada");
                double dato = Convert.ToDouble(Console.ReadLine());
                double resultado = Raizcuadrada(dato);
                Console.WriteLine("la raiz es {0}", resultado);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (NegativeNumberException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
        public static double Raizcuadrada(double dato)
        {
            if (dato < 0)
            {
                //throw new NegativeNumberException("no pongas numeros negativos");
                throw new NegativeNumberException();
            }
            return Math.Sqrt(dato);
        }
    }
}
