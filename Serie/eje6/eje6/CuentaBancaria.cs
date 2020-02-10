using System;
using System.Collections.Generic;
using System.Text;

namespace eje6
{
    class CuentaBancaria
    {
        double Saldo  { get; set; }
        string Nombre { get; set; }
        //contructor
        public CuentaBancaria(string nombre,double saldo) {
            Nombre = nombre;
            Saldo = saldo;
            MostrarInformacion();
        }
        //muestra la informacion del objeto
        public void MostrarInformacion() {
            Console.WriteLine("\nNombre: {0} Saldo: {1} \n",Nombre,Saldo);
        }
        //suma el saldo a la cuenta
        public void Deposito(double can) {
            Saldo += can;
            MostrarInformacion();
        }
        //resta el saldo a la cuenta y si no hay saldo suficiente mando un mensaje
        public void Retiro(double can) {
            if (Saldo >= can)
            {
                Saldo -= can;
                MostrarInformacion();
            }
            else { Console.WriteLine("Saldo insuficioente"); }
        }

    }
}
