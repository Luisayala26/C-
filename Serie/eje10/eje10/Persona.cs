using System;
using System.Collections.Generic;
using System.Text;

namespace eje10
{
    class Persona
    {
        string Nombre;
        int Edad;
        double Estatura;
        double Peso;
        //set y Get
        public string nombre { get { return Nombre; } set { Nombre = value; } }
        public int edad { get { return Edad; } set { Edad = value; } }
        public double estatura { get { return Estatura; } set { Estatura = value; } }
        public double peso { get { return Peso; } set { Peso = value; } }

        //constructor
        public Persona(string nombre,int edad,double estatura,double peso) 
        {
            this.nombre = nombre;
            this.edad = edad;
            this.estatura = estatura;
            this.peso = peso;
        }
        //funcion HacerEjercicio resta el peso si se hace mas de dos horas
        public void HacerEjercicio(double horas) 
        {
            if (horas >= 2) 
            {
                peso -= 0.5;
                Console.WriteLine("Has perdido peso: {0}",Peso);
            }
            else 
            {
                Console.WriteLine("Has mas ejercicio");
            }
        }
        //muestra cuantas hosa camino
        public void Caminar(int horas) 
        {
            Console.WriteLine("{0} a caminado {1} horas",nombre,horas);
        }
        //muestra que comio
        public void Comer(string comida) 
        {
            Console.WriteLine("{0} esta comiendo {1}",nombre,comida);
        }
        //Muestra la informacion de un objeto
        public void Info()
        {
            Console.WriteLine("{0} {1} años {2}m {3}Kg",nombre,edad,estatura,peso);
        }


    }
}
