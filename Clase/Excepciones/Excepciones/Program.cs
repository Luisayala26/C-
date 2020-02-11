using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // convert.TOint32 genera Format Exception
                Console.WriteLine("numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());

                //la division gener DivideByZeroException
                double resultado = numerador / denominador;
                Console.WriteLine("{0}/{1}={2}",numerador,denominador,resultado);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n"+formatException.Message);

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("\n"+e.Message);
            }

            finally
            {
                Console.WriteLine("fin programa");
            }


            Console.ReadKey();
        }
    }
}
