using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de ALumnos a calificar");
            int tam =Convert.ToInt32( Console.ReadLine());
            Alumno  [] alu = new Alumno[tam];

            for (int i =0; i<alu.Length; i++) {
                alu[i] = new Alumno();
            }

            for (int i = 0; i < alu.Length; i++)
            {
                Console.WriteLine("La calificación final de {0} {1} {2} es {3}/100 ",alu[i].nombre, alu[i].appat, alu[i].apmat, Calculadora.Calcular(alu[i].proyecto, alu[i].tareas, alu[i].parti));
            }
        }
    }
}
