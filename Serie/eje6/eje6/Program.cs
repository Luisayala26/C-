using System;
/*
 6. Se debe diseñar una clase CuentaBancaria que va a tener los métodos mostrarInformación,
depósito y retiro, como atributos, cada objeto va a tener un saldo y un nombre. El método
mostrar información va a imprimir el nombre de la cuenta y el saldo, el método depósito va
a agregar una cantidad al saldo de la cuenta y va a mostrar información. El método retiro va
a retirar dinero de la cuenta, pero antes tendrá que comprobar que se cuente con el dinero
suciente, terminando el retiro va a mostrar información. Cada vez que se cree un objeto,
va a mostrar información de la cuenta. Se debe crear dos objetos y llamar sus métodos para
probarlos.

     */
namespace eje6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Se crean los objetos y se llaman los metos de la clase
             */
            CuentaBancaria c1 = new CuentaBancaria("Cuenta1",5000);
            CuentaBancaria c2 = new CuentaBancaria("Cuenta2",1000);

            c1.MostrarInformacion();
            c1.Deposito(1000);
            c1.Retiro(1500);

            c2.MostrarInformacion();
            c2.Retiro(2000);
            Console.ReadKey();
        }
    }
}
