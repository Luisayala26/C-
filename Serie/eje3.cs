using System;
/*
Escribir un programa que pida al usuario una cadena de texto e imprima la misma cadena de
texto, pero antes de cada vocal, agregue una f.
Ejemplo:
"Mi nombre es Ana"
"M nfombrfe fes fAnfa"

Se sustituyen todas las vocales de la cadena ingresada por el usuario
*/
namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cadena");
            string cad =Console.ReadLine();
            Console.WriteLine("cadena: "+cad);
            cad=cad.Replace("a","fa");
            cad=cad.Replace("e","fe");
            cad=cad.Replace("i","fi");
            cad=cad.Replace("o","fo");
            cad=cad.Replace("u","fu");
            Console.WriteLine("Cadena Modificada: "+cad);
            Console.ReadKey();

        }
    }
}
