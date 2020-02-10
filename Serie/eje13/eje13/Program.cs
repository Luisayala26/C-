using System;
/*
 13. Se tendrá una clase llamada Carro que tendrá de atributos peso y altura junto con un atributo
llamado " encendido" de tipo booleano inicilizado en false. En el constructor deberás indicarle
los valores peso y altura.La misma clase contará con los métodos encender y apagar, que cambiarán el estado del atributo " encendido" y desplegarás un mensaje indicando si se encendió
o se apagó.
Crear métodos get para poder obtener su peso y altura.
Se contará con un método llamado " Estado"para vericar si el auto se encuentra encendido o no.
El último método de la clase, es toString() el cual nos servirá para imprimir un mensaje,
este mensaje deberá indicar el peso y altura del Carro.
Crear dos clases más que hereden de Carro, con nombres como CarroBWM, CarroVW, etc. Esta
clase tendrá un atributo llamado modelo. Implementa su constructor y también implementa
su método toString() para que pueda imprimir todos sus atributos. En una clase de prueba(en
el método Main), crea objetos de las dos clases hijas y manda a llamar todos sus métodos. Al
nal deberá verse una impresión como la siguiente, para los dos objetos que hayas creado:
>El carro está apagado
>El carro está encendido
>Está encendido
>Tengo turbo
>El peso es: 100,000.
>La altura es: 1.90.

     */
namespace eje13
{
    class Program
    {
        static void Main(string[] args)
        {
            //objetos y metodos
            Carro c = new Carro(100000,2);
            Carro c1 = new Carro(5000, 1.5);

            CarroBMW cb = new CarroBMW(100,1);
            CarroVW cv = new CarroVW(300,1.21);

            c.Encender();
            c1.Apagar();
            Console.WriteLine(cb.ToString());
            cv.Estado();
            Console.WriteLine(c.ToString());
            Console.WriteLine("Peso: {0} Altura: {1}",c.peso,c.altura);


        }
    }
}
