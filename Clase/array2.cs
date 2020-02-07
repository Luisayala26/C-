using System;
namespace arreglos
{
    class Program
    {
        static void MostrarArreglo(int [] arreglo)
        {
            foreach (int num in arreglo)
            {
                Console.Write("{0} ",num);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int [] list={34,74,13,44,25,30,10};
            int [] temp = new int[list.Length];

            Array.Copy(list,temp,list.Length);
            Console.WriteLine("Arreglo original ");
            MostrarArreglo(list);
            Array.Reverse(temp);
            MostrarArreglo(temp);
            Array.Sort(list);
            MostrarArreglo(list);
            Console.WriteLine("Indice del numero 44: "+Array.IndexOf(temp,44));
            Console.ReadKey();
        }
    }
}
