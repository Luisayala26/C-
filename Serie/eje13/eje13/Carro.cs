using System;
using System.Collections.Generic;
using System.Text;

namespace eje13
{
    //clase carro con atributos Peso, Altura y encendido
    class Carro
    {
        double Peso;
        double Altura;
        bool encendido;
        public double peso { get { return Peso; } }
        public double altura { get { return Altura; } }
        //constructor
        public Carro(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
            encendido = false;
        }
        //enciende el carro
        public void Encender() 
        {
            encendido = true;
            Console.WriteLine("Se encendio el auto");
        }
        //apaga el carro
        public void Apagar() 
        {
            encendido = false;
            Console.WriteLine("Se apago el auto");
        }
        //revisa el estado del carro
        public void Estado()
        {
            if (encendido)
                Console.WriteLine("El carro se encuentra encendido"); 
            
            else
                Console.WriteLine("El carro se encuentra apagado");
        }
        //muestra la informacion del objeto
        public override string ToString()
        { 
            return "Peso: "+Peso+" Altura: "+Altura+" Encendido: "+encendido;
        }
    }
}
