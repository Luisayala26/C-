using System;
/*
 7. Se debe diseñar una clase NumeroComplejo, que va a tener como atributos parteReal y parteImaginaria, se debe denir un método imprimir que va a imprimir el número complejo con
formato. Se debe denir un método para la suma de dos objetos de la clase NumeroComplejo
que retorne un nuevo número complejo que sea la suma de los otros dos. A continuación se
debe crear dos números complejos y probar sus métodos.
     */
namespace eje7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean los objetos y se llaman los metos de la clase NumeroComplejo
            NumeroComplejo n1 = new NumeroComplejo(12,-5);
            NumeroComplejo n2 = new NumeroComplejo(-1,2);
            n1.Imprimir();
            n2.Imprimir();
            NumeroComplejo n3 = NumeroComplejo.Suma(n1,n2);
            Console.WriteLine("\nResultado de la suma\n");
            n3.Imprimir();
            Console.ReadKey();
        }
    }
}
