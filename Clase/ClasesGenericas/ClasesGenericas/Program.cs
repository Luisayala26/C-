using System;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> stack = new Stack<double>(10);
            stack.Push(5.5);
            stack.Push(10.5);

            double x = stack.pop();
            double y = stack.pop();

            Stack<Tortilla> pila = new Stack<Tortilla>();
            pila.Push(new Tortilla());
            pila.Push(new Tortilla());
            Console.WriteLine("{0} {1}",x,y);
            Console.WriteLine(pila.pop().color);

        }
    }
}
