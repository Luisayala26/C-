using System;

namespace eje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persona p1 = new Persona("hola", 23);
            Persona p2 = new Persona("adios", 23);
            Persona p3 = new Persona("hola123", 23);
            Persona p4 = new Persona("hola", 23);

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 == p3);
            Console.WriteLine(p1 == p4);
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p1.Equals(p4));
        }
    }
}
