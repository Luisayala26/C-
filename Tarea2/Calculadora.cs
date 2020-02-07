using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    public static class Calculadora
    {
        public static int Calcular(int proyecto, int tareas, int par)
        {
            int calp = proyecto * 6;
            int calt = tareas * 4*2;
            int calpa= 0;
            if (par > 4){ calpa = 0;    }
            else { calpa = 0; }
            int final = calp + calt + calpa;

            if (final > 100) { return 100; }
            else if (final < 50) { return 50; }
            else { return final; }
        }
    }
}
