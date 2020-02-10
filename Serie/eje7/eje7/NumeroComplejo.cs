using System;
using System.Collections.Generic;
using System.Text;

namespace eje7
{
    class NumeroComplejo
    {
        double parteReal { get; set; }
        double parteImaginaria { get; set; }
        //constructor
        public NumeroComplejo(double real , double img) {
            parteReal = real;
            parteImaginaria = img;
        }
        //Imprime el numero complejo con formato
        public void Imprimir() { 
            if(parteImaginaria>=0)
                Console.WriteLine("{0}+{1}i",parteReal,parteImaginaria); 
            else
                Console.WriteLine("{0}{1}i", parteReal, parteImaginaria);
        }
        //Suma de numeros complejos
        public static NumeroComplejo Suma(NumeroComplejo obj ,NumeroComplejo obj1) {
            NumeroComplejo resultado = new NumeroComplejo(obj.parteReal + obj1.parteReal, obj.parteImaginaria + obj1.parteImaginaria);
            return resultado;
           }
    }
}
