using System;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("armando",22);
            p.Saludar();
            Console.WriteLine(p.ToString());

            Empleado e = new Empleado("Antonio",25,"Mercenario",3000);
            e.Saludar();
            e.Trabajar();
            Console.WriteLine(e.ToString());

            Persona p1 = new Persona("Xotla",22);
            Persona p2 = new Persona("Rodolfo",22);

            Persona[] gente = new Persona[4];

            gente[0] = p;
            gente[1] = p1;
            gente[2] = p2;
            gente[3] = e;

            Console.WriteLine();
            Console.WriteLine("lista de empleados");

            foreach(var per in gente)
            {
                if(per is Empleado)
                {
                    Console.WriteLine(per.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
