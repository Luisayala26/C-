using System;
using System.Collections.Generic;
using System.Text;

namespace eje12
{
    class BecarioMart
    {
        List<string> Compras = new List<string>();
        List<double> Precio = new List<double>();
        public double Total;
        //agrega producto a la lista
        public void Agregar(string producto,double precio) 
        {
            Compras.Add(producto);
            Precio.Add(precio);
        }
        //quita elementos de la lista
        public void Quitar(int i) 
        {
            try 
            {
                Compras.Remove(Compras[i]);
                Precio.Remove(Precio[i]);
            }
            catch (Exception) { Console.WriteLine("No existe el elemento en la lista"); }
            
        }
        //muestra la lista
        public void Mostrar() 
        {
            double aux = 0;
            for(int i=0; i < Compras.Count; i++)
            {
                Console.WriteLine("{0}: {1} {2}",Compras.IndexOf(Compras[i]),Compras[i],Precio[i]);
                aux += Precio[i];
            }
            Total = aux;
            Console.WriteLine("Precio total: {0}",Total);
        }
    }
}
