using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
    class Persona
    {
        protected string Nombre { get; set; }
        public int edad { get; set; }
        public Persona() { }
        public Persona(String nombre, int edad)
        {
            Nombre = nombre;
            this.edad = edad;
        }
        public virtual void Saludar()
        {
            Console.WriteLine("Hola mi nombre es: {0} ",Nombre);
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} años", Nombre,edad);
        }
    }
}
