using System;
using System.Collections.Generic;
using System.Text;

namespace eje17
{
    /*Se Crearon las clases Charmander, Squartle y Bulbasour las cuales tienen Atributo de tamaño, Nombre, Evolucion y Ataque 
     * junto con un meto que muestra esta informacion*/
    class Charmander:Fuego
    {
        double tamaño;
        String Nombre;
        int Evolucion;
        String Ataque;
        public Charmander() 
        {
            tamaño = 1.2;
            Nombre = "Charmander";
            Evolucion = 0;
            Ataque = "Lanza llamas";
        }
        public override string ToString()
        {
            return "Nombre: "+Nombre+ "\tTamaño: " + tamaño+ "\tEvolucion: " + Evolucion+ "\tAtaque: " + Ataque;
        }
    }
    class Squartle:Agua
    {
        double tamaño;
        String Nombre;
        int Evolucion;
        String Ataque;
        public Squartle()
        {
            tamaño = 1;
            Nombre = "Squartle";
            Evolucion = 0;
            Ataque = "Choro de agua";
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + "\tTamaño: " + tamaño + "\tEvolucion: " + Evolucion + "\tAtaque: " + Ataque;
        }
    }
    class Bulbasaur:Hierba
    {
        double tamaño;
        String Nombre;
        int Evolucion;
        String Ataque;
        public Bulbasaur()
        {
            tamaño = 0.8;
            Nombre = "Bulbasaur";
            Evolucion = 0;
            Ataque = "Hojas nava";
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + "\tTamaño: " + tamaño + "\tEvolucion: " + Evolucion + "\tAtaque: " + Ataque;
        }
    }
}
