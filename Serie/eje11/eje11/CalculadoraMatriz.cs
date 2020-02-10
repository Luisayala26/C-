using System;
using System.Collections.Generic;
using System.Text;

namespace eje11
{
    class CalculadoraMatriz
    {
        //suma de dos matrices
        public static double[,] Suma(double[,] Arreglo, double[,] Arreglo1,int tam) 
        {
            double [,] resultado = new double[Arreglo.Length, Arreglo.Length];
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    resultado[i, j] = Arreglo[i, j]+ Arreglo1[i, j];
                }

            }
            return resultado; 
        }
        //resta de dos matrices
        public static double[,] Resta(double[,] Arreglo, double[,] Arreglo1,int tam) 
        {
            double[,] resultado = new double[Arreglo.Length, Arreglo.Length];
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    resultado[i, j] = Arreglo[i, j] - Arreglo1[i, j];
                }

            }
            return resultado;
        }
        //Multiplicaion de dos matrices
        public static double[,] Multiplicacion(double [,] Arreglo,double [,] Arreglo1,int tam) 
        {
            double[,] resultado = new double[tam, tam];

            for (int i = 0; i < tam; i++)
                for (int j = 0; j < tam; j++)
                {
                    resultado[i, j] = 0;
                    for (int k = 0; k < tam; k++)
                        resultado[i, j] += Arreglo[i, k] * Arreglo1[k, j];
                }
            return resultado;
        }
        //Imprecion de matriz
        public static void ImpMatriz(double [,] Arreglo,int tam) 
        {
            for(int i=0; i<tam;i++)
            {
                for(int j=0; j<tam;j++)
                {
                    Console.Write("{0} ",Arreglo[i,j]);
                }
                Console.WriteLine();
                
            }
        }
    }
}
