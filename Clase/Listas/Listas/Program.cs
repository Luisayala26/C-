using System;
using System.Collections.Generic;
namespace Listas
{
    class Program
    {
        private static readonly string[] colors = {"Magenta" , "azul", "blanco" };
        private static readonly string[] removeColors = { "rojo","verde", "negro"};
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            foreach(var color in colors)
            {
                list.Add(color);
            }
            
            List<string> removeList = new List<string>(removeColors);

            MostrarLista(list);
            MostrarLista(removeList);

        }

        private static void MostrarLista(List<string> list)
        {
            foreach(var elemento in list)
            {
                Console.WriteLine("{0}",elemento);
            }
        }

    }
}
