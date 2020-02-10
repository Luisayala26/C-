using System;
/*
2. Realizar un programa en el que se le pida al usuario dos números del 1 al 9, num1 y num2.
Después va a imprimir todos los números naturales del 1 al 100, sin embargo, cuando un
número sea múltiplo de num1 o num2 o contenga alguno de estos números, va a imprimir
‘clap’
EL usuario ingresara dos numeros y se imprimira los numeros del 1 al 100 y donde alguno de los numeros sea multiplo o incluya los numeros igresados por el 
usuario  se imprimira en pantalla la palabra "clap". 
*/
namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Introduce el primero numero");
                int num1 =Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Introduce el segundo numero");
                int num2 =Convert.ToInt32( Console.ReadLine());
                
                
                for (int i =0; i<=100; i++) {
                    string aux1=i.ToString();
                    if(((i%num1)==0)||((i%num2)==0)){
                        Console.WriteLine("clap");
                    }
                    else if(aux1.Contains(num1.ToString())||aux1.Contains(num2.ToString())) {
                        Console.WriteLine("clap");

                    }
                    else {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (SystemException e) { Console.WriteLine("{0}",e); }
            
            Console.ReadKey();
        }
    }
}
