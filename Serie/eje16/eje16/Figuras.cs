using System;
using System.Collections.Generic;
using System.Text;

namespace eje16
{
    /*Sobre escribe el metodo heredado de IPoli*/
    class Circulo:IPoli
    {
        public void Perimetro() { Console.WriteLine("2*PI*Radio"); }
    }
    class Cuadrado : IPoli
    {
        public void Perimetro() { Console.WriteLine("Lado+Lado+Lado+Lado"); }
    }
    class Triangulo : IPoli
    {
        public void Perimetro() { Console.WriteLine("Lado A + Lado B + Lado C"); }
    }
}
