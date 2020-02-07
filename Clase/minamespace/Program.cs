using System;

namespace minamespace
{
    class clase1
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro de MiNamespace");

        }
    }
}

class uno
{
    public void metodo()
    {
        Console.WriteLine("holacomo estas");
    }
}

namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            minamespace.clase1 obj1 = new minamespace.clase1();
            uno obj2 = new uno();
            obj1.Metodo();
            obj2.metodo();
            Console.ReadKey();
        }
    }
}
