using System;

namespace MetodoGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1,2,3,4,5,6};
            double[] doubleArray = { 1.1,2.2,3.3,4.4};
            char[] chararray = { 'H', 'o', 'l', 'a' };

            Console.WriteLine("int");
            MuestraArreglo(intArray);
            Console.WriteLine("double");
            MuestraArreglo(doubleArray);
            Console.WriteLine("char");
            MuestraArreglo(chararray);
            Console.ReadKey();
        }
        public static void MuestraArreglo<T>(T[] inputArray)
        {
            foreach(T elemento in inputArray)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
