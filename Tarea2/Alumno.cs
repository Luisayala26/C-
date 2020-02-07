using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    class Alumno
    {
        string Nombre;
        string ApeidoPat;
        string ApeidoMat;
        int Proyecto;
        int Tareas;
        int Participaciones;

        public string nombre { get { return Nombre; } set { } }
        public string appat { get { return ApeidoPat; } set { } }
        public string apmat { get { return ApeidoMat; } set { } }
        public int proyecto { get { return Proyecto; } set { } }
        public int tareas { get { return Tareas; } set { } }
        public int parti { get { return Participaciones; } set { } }

        public Alumno(string nombre, string apeidopat, string apeidomat, int proyecto, int tareas, int par)
        {
            Nombre = nombre;
            ApeidoPat = apeidopat;
            ApeidoMat = apeidomat;
            Proyecto = proyecto;
            Tareas = tareas;
            Participaciones = par;
        }

        public Alumno()
        {
            Console.WriteLine("Nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno");
            ApeidoPat = Console.ReadLine();
            Console.WriteLine("Apellido Materno");
            ApeidoMat = Console.ReadLine();
            Console.WriteLine("Calificación del proyecto");
            int aux= Convert.ToInt32(Console.ReadLine());
            if (aux > 10) { Proyecto = 10; }
            else if (aux < 0){ Proyecto = 0; }
            else { Proyecto = aux; }
            Console.WriteLine("Cantidad de tareas");
            aux = Convert.ToInt32(Console.ReadLine());
            if (aux > 5) { Tareas = 5; }
            else if (aux < 0) { Tareas = 0; }
            else { Tareas = aux; }
            Console.WriteLine("Cantidad de participaciones");
            Participaciones = Convert.ToInt32(Console.ReadLine());
            
        }

    }

}
