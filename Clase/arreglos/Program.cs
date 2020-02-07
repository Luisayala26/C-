using System;

namespace arreglos
{
    class Program
    {
        static void MostrarArreglo(int [] arreglo)
        {
            foreach (int num in arreglo)
            {
                Console.WriteLine("{0} ",num);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tamaño del arreglo");
            int tam = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[tam];

            for (int i = 0; i < numeros.Length; i++) {
                Console.WriteLine("Indice {0}:", i);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Los Datos son: ");
            MostrarArreglo(numeros);
            Console.ReadKey();
        }
    }
}
