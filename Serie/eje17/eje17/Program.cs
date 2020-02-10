/*
 17. Realiza un programa de temática libre en donde puedas utilizar los 4 pilares de la Programación
Orientada a Objetos.
 */
using System;

namespace eje17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se cre un objeto de la clase Charmander
            Charmander c = new Charmander();
            //Se cre un objeto de la clase Squartle
            Squartle s = new Squartle();
            //Se cre un objeto de la clase Bulbasaur
            Bulbasaur b = new Bulbasaur();
            
            //Se llama al metodo ToString y tipo que tienen los objetos
            Console.WriteLine(c.ToString()+"\tTipo: "+c.Tipo());
            Console.WriteLine(s.ToString() + "\tTipo: " + s.Tipo());
            Console.WriteLine(b.ToString() + "\tTipo: " + b.Tipo());
        }
    }
}
