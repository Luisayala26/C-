using System;
/*
 11. Elabora un programa que simule una calculadora de matrices (utilizando arreglos bidimensionales). El tamaño de la matriz (arreglo) deberá ser ingresado por el usuario, así como los valores
contenidos en ella. En este caso sólo se soportarán matrices cuadradas (nxn). Las operaciones
que deberá contender la calculadora son:
suma
resta
multiplicación
Se puede utilizar cualquier tipo de dato (int, double, oat). El programa debe contener un
menú que me permita elegir entre las operaciones de la calculadora y cuando se hagan las
operaciones, me debe mostrar las matrices que operan, así como el resultado. Estas matrices
deben mostrarse en su respectivo formato, es decir, cuadradas. Sin importar lo que el usuario
ingrese el programa no debe "morir", usen excepciones para controlar el ingreso de datos del
usuario
     */
namespace eje11
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            int aux;
            //tamaño de las matrices
            Console.WriteLine("Tamaño de las matrices");
            try { aux = Convert.ToInt32(Console.ReadLine()); }
            catch (SystemException e) { Console.Write("Error \n\n{0}", e); return; }
            int tam;
            if (aux<2)
            {
                Console.WriteLine("Tamaño incorrecto");
                return;
            }
            else { tam = aux; }
            //lectura de matrices y verifica los valores
            double[,] a1 = new double[tam,tam];
            double[,] a2 = new double[tam, tam];
            Console.WriteLine("Matriz 1");
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    try {
                        Console.Write("Elemento [{0}][{1}]: ", i,j);
                        a1[i, j] =Convert.ToDouble(Console.ReadLine()); }
                    catch (SystemException e) { Console.Write("Error \n\n{0}", e); return; }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matriz 2");
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    try
                    {
                        Console.Write("Elemento [{0}][{1}]: ", i, j);
                        a2[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (SystemException e) { Console.Write("Error \n\n{0}", e); return; }
                }
                Console.WriteLine();
            }
            //menu para las matrices
            do
            {
                Console.WriteLine();
                Console.WriteLine("Calculadora de Matrices");
                Console.WriteLine("a) Suma");
                Console.WriteLine("b) Resta");
                Console.WriteLine("c) Multiplicaion");
                Console.WriteLine("d) Mostrar Matrices");
                Console.WriteLine("s)Salir");
                Console.WriteLine("Elije una opcion: ");
                opcion = Console.ReadLine();

                if (opcion == "a")
                {
                    //creacion de los objetos y metodos
                    CalculadoraMatriz.ImpMatriz(a1,tam);
                    Console.WriteLine();
                    CalculadoraMatriz.ImpMatriz(a2, tam);
                    Console.WriteLine();
                    CalculadoraMatriz.ImpMatriz(CalculadoraMatriz.Suma(a1, a2, tam), tam) ;
                }
                else if (opcion == "b")
                {
                    //creacion de los objetos y metodos
                    CalculadoraMatriz.ImpMatriz(a1, tam);
                    Console.WriteLine();
                    CalculadoraMatriz.ImpMatriz(a2, tam);
                    Console.WriteLine();
                    CalculadoraMatriz.ImpMatriz(CalculadoraMatriz.Resta(a1, a2, tam), tam);
                }
                else if (opcion == "c")
                {
                    //creacion de los objetos y metodos
                    CalculadoraMatriz.ImpMatriz(a1, tam);
                    Console.WriteLine();
                    CalculadoraMatriz.ImpMatriz(a2, tam);
                    Console.WriteLine();
                    CalculadoraMatriz.ImpMatriz(CalculadoraMatriz.Multiplicacion(a1, a2, tam), tam);
                }
                else if (opcion == "d")
                {
                    //creacion de los objetos y metodos
                    CalculadoraMatriz.ImpMatriz(a1, tam);
                    Console.WriteLine();
                    CalculadoraMatriz.ImpMatriz(a2, tam);
                }
                else if (opcion == "s") { Console.WriteLine("\nHasta luego "); }
                else { Console.WriteLine("\nOpcion incorrecta elija otra opcion\n"); }
            } while (opcion != "s");//ciclo para salir

        }
    }
}
