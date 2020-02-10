using System;
/*
4. Realizar un programa que imprima la serie de fibonacci hasta el elemento n que especifique el
usuario.

El usuario ingresara un numero entero y se calculara la serie de fibonachi hasta ese elemento 
*/
namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elemtos de la serie de fibonacci");
            try{
	            int cad =Convert.ToInt32(Console.ReadLine());
	            int j=0,k=1,aux;
	            
	            if(cad==1){
	            	Console.Write("0");
	            }
	            else if (cad==2){
	            	Console.Write("0 1 ");
	            }
	            else if(cad<1){
	            	Console.Write("No se puede ingrasar numeros menores a 1");
	            }
	            else{
	            	//Calculo de la serie de fibonachi
		            for(int i =2; i<cad ;i++){
		            	aux=j+k;
		            	Console.Write("{0} ",aux);
		            	j=k;
		            	k=aux;
		            }
	            }
        	}
        	catch (SystemException e) { Console.WriteLine("{0}",e); }

        }
    }
}