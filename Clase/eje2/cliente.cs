using System;
using System.Collections.Generic;
using System.Text;

namespace eje2
{
    class cliente
    {
        //por defecto se toma el valor private
        string nombre;
        int edad;
        int cuenta;
        double dinero;
        Random rm = new Random();
        public static int contador = 0;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }

        public int Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 0)
                    edad = 18;
                else
                    edad = value;
            }
        }
        /*
         c1.Nombre="hola";
         */
         public void Retirar(double cantidad)
        {
            if (cantidad > dinero)
            {
                Console.WriteLine("saldo insuficiente");
                return;
            }
            dinero -= cantidad;
        }

        public void Depositar(double cantidad)
        {
            dinero += cantidad;
        }

        public cliente(string nombre)
        {
            this.nombre = nombre;
            dinero = 500;
            cuenta = rm.Next(0, 100);
            contador = contador + 1;
        }
        public static string mensaje()
        {
            return "bienvenidos a c#";
        }

        public override string ToString()
        {
            return String.Format("nombre: {0}, edad: {1}",nombre,edad);
        }
    }
}
