using System;
/*
 16. Realiza un programa que haga un claro ejemplo de Polimorsmo, estas clases pueden ser de
tu elección. Recuerda que polimorsmo no necesariamente es hacer una interfaz o hacer una
clase abstracta.
     */
namespace eje16
{
    class Program
    {
        static void Main(string[] args)
        {
            //objetos y metodo
            Circulo c = new Circulo();
            Cuadrado c1 = new Cuadrado();
            Triangulo t = new Triangulo();

            c.Perimetro();
            c1.Perimetro();
            t.Perimetro();

        }
    }
}
