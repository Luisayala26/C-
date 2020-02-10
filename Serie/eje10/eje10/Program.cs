using System;
/*
 10. Realiza una clase llamada "Persona"que tenga los atributos: nombre edad, estatura(metros)
y peso(Kg). El usuario ingresará los datos dichos datos. Crea algunos métodos (mínimo 3) y
mandalos llamar en una clase principal.
     */
namespace eje10
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crean los objeto con valores verificados y se llaman a los metodos
            Console.WriteLine("Nombre:");
            string nom = Console.ReadLine();
            try
            {
                Console.WriteLine("Edad:");
                int aux = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Estatura:");
                double aux1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Peso:");
                double aux2 = Convert.ToDouble(Console.ReadLine());
                if (aux < 0 || aux > 100) { Console.WriteLine("Edad invalida"); }
                else if (aux1 < 0 || aux1 > 2.5) { Console.WriteLine("Estatura invalida"); }
                else if (aux2 < 0 || aux2 > 250) { Console.WriteLine("Peso invalida"); }
                else
                {
                    Persona p = new Persona(nom, aux, aux1, aux2);
                    p.Info();
                    p.HacerEjercicio(2);
                    p.Caminar(1);
                    p.Comer("Tacos");
                }
            }
            catch (SystemException e)
            {
                Console.WriteLine("Datos incorrectos error\n\n {0}", e);
                return;
            }
            finally { Console.WriteLine("\n\nSe termino el programa\n\n"); }
            
            

            
        }
    }
}
