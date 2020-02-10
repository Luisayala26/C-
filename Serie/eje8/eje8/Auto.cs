using System;
using System.Collections.Generic;
using System.Text;

namespace eje8
{
    class Auto
    {
        string Marca;
        int Puertas;
        bool Estandar;
        //Metos get y set
        public string marca { get{ return Marca; } set { Marca = value; } }
        public int puertas { get { return Puertas; } set { Puertas = value; } }
        public bool estandar { get { return Estandar; } set { Estandar = value; } }
        //constructores
        public Auto() { }
        public Auto(string marca, int puertas, bool estandar) {
            Marca = marca;
            Puertas = puertas;
            Estandar = estandar;
        }
        //funcion para cambiar el tipo de marcha
        public void Tipo(bool a) {
            Estandar = a;
            if (Estandar)
            {
                Console.WriteLine("El Carro es estandar");
            }
            else
            {
                Console.WriteLine("El Carro es automatico");
            }
                
        }
        //Funcion para encender el carro
        public void Arrancar() {
            Console.WriteLine("El carro encendio sin problemas");
        }
        //Funcion que descompone el carro
        public void Des() {
            Console.WriteLine("El carro se descompuso llevalo al macanico");
        }
        //Funcion para mostrar la informacion del objeto
        public void Info()
        {
            if (Estandar)
            {
                Console.WriteLine("La marca del carro es {0}, tiene {1} puertas y es estandar",Marca,Puertas);
            }
            else
            {
                Console.WriteLine("La marca del carro es {0}, tiene {1} puertas y es automatico",Marca,Puertas);
            }
        }

    }
}
