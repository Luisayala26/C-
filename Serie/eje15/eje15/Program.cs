using System;
/*
 15. Crea una calculadora que haga operaciones entre dos números. Las operaciones que deberá
soportar serán suma, resta, multiplicación y división. El programa debe de contener un menú
que me permita elegir cualquier opción y la última de ellas debe ser para salir. Si se termina
una operación debo de volver al menú de inicio. No debe haber forma de salirse del programa a
menos que sea con la opción salir. Considerar todas las excepciones posibles e implementarlas
para evitar errores en tiempo de ejecución. Considera: División entre cero, números demasiado
grandes, cadenas en vez de números, entre otras que a ti se te puedan ocurrir
     */
namespace eje15
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion="";
            Console.WriteLine("Calculadora");
            /*Se crea una calculadora con las Excepciones necesarias para que no truene el programa*/
            do
            {
                
                decimal num1 = 0, num2 = 0;
                char s = 'n';
                do { 
                    try
                    {
                        Console.WriteLine("Introducce el numero");
                        num1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Introducce el numero");
                        num2 = Convert.ToDecimal(Console.ReadLine());
                        s = 's';
                    }
                    catch (SystemException e) { Console.WriteLine("Error al introduccir valores\n Escriba de nuevo los valores\n {0}",e); }
                } while (s != 's');

                Console.WriteLine("a) Suma");
                Console.WriteLine("b) Resta");
                Console.WriteLine("c) Multiplicacion");
                Console.WriteLine("d) Division");
                Console.WriteLine("s)Salir");
                Console.WriteLine("Elije una opcion: ");
                opcion = Console.ReadLine();

                if (opcion == "a")
                {
                    Console.WriteLine("{0}+{1}={2}",num1,num2,num1+num2);
                    
                }
                else if (opcion == "b")
                {
                    Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
                }
                else if (opcion == "c")
                {
                    Console.WriteLine("{0}x{1}={2}", num1, num2, num1 * num2);

                }
                else if (opcion == "d")
                {
                    try 
                    {
                        Console.WriteLine("{0}/{1}={2}", num1, num2, num1 / num2);
                    }
                    catch (SystemException e ) {    Console.WriteLine("Error en la division\n{0}",e);    }
                }
                else if (opcion == "s") { Console.WriteLine("\nHasta luego "); }
                else { Console.WriteLine("\nOpcion incorrecta elija otra opcion\n"); }
            } while (opcion != "s");
        }
    }
}
