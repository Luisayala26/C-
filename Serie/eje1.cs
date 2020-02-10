using System;
/*
1. Programa que permite calcular la suma de los primeros n números naturales, siendo n un
número natural ingresado por el usuario.
Recibe un numero del usuario y calcula la suma de los n numeros naturales
*/
namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el valor para sumar los primeros n numeros");
            try{
                int n =Convert.ToInt32( Console.ReadLine());
                int valor=0;
                for (int i =0; i<=n; i++) {
                    valor=valor+i;
                }

                Console.WriteLine("Suma de {0} numeros naturales es {1}",n,valor);
            }
            catch (SystemException e) { Console.WriteLine("{0}",e); }
            Console.ReadKey();
        }
    }
}