using System;
/*
 12. Una persona se dirige al BecarioMart a realizar sus compras semanales. Dicha persona no sabe
cuántos productos va a comprar y tampoco sabe su valor. Para poder ayudarlo deberás de
implementar dos Listas. Una contiene los nombres de los productos y otro contiene los precios
de los productos. Tanto el nombre como el precio, deberán ser ingresados por el usuario y en
seguida, deberán de ser agregados a las listas. Al momento de pagar le aparece una lista de
todos los productos que ha llevado con su respectivo precio, sin embargo, se da cuenta de
que sólo tiene $500.00, por lo que, si ha excedido su cuenta, deberá elegir unos productos y
dejar otros. Para lograr eso, debe poder acceder al índice del producto y así poder elegirlo para
eliminarlo de su lista, hasta que nalmente la cuenta sea menor o igual a los $500.00.
El programa debe preguntar al usuario si desea agregar un producto a su lista, si es así deberá
ingresar tanto el nombre como el precio a las Listas. En caso de que ya no quiera agregar más
productos, le aparecerá en pantalla la lista de todos los productos que ha llevado (nombre y
precio) así como la suma de los precios. Cuando aparezca la lista, deberá tener dos opciones:
Comprar.
Dejar productos.
Para la primera opción deberás de tener validaciones para ver si el dinero que tiene es suciente. Si el dinero es suciente, deberá imprimir un mensaje que diga "Gracias por su compra!",
en caso contrario debe mandarlo a la opción "Dejar productos". Si el usuario elige la opción 2
deberá poder ver los índices de los productos en las listas para así poder decidir cuál eliminar.
Una vez eliminados los productos, debes imprimir de nuevo la lista de productos a comprar
con su precio y darle a elegir de nuevo entre las dos opciones
     */
namespace eje12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Compras");
            double precio;
            string opcion;
            BecarioMart com = new BecarioMart();
            //agrega los elementos a la lista
            do
            {
                Console.WriteLine("Nombre producto");
                string producto = Console.ReadLine();
                Console.WriteLine("Precio del producto");
                try
                {
                    precio = Convert.ToDouble(Console.ReadLine());
                    if (precio < 0)
                    {
                        Console.WriteLine("Precio incorrecto\n");
                    }
                    else
                    {
                        com.Agregar(producto, precio);
                    }

                }
                catch (SystemException e) { Console.WriteLine("Precio incorrecto\n{0}",e); }

                Console.WriteLine("Quieres agregar otro producto s/n");
                opcion = Console.ReadLine();
            } while (opcion == "s");

            com.Mostrar();
            //Compra lo de la lista o deja productos si no le alcanza
            do
            {

                Console.WriteLine("a)Comprar");
                Console.WriteLine("b)Dejar productos");
                opcion = Console.ReadLine();
                com.Mostrar();
                if (opcion == "a")
                {
                    if (com.Total <= 500) { Console.WriteLine("Gracias Por tu compra");}
                    else { Console.WriteLine("\nSaldo insuficiente\n"); opcion = "b"; }
                }
                if (opcion=="b") 
                {
                    try
                    {
                        
                        Console.WriteLine("Elige una opcion para quitar el producto de la lista");
                        int op = Convert.ToInt32(Console.ReadLine());
                        com.Quitar(op);
                        com.Mostrar();
                    }
                    catch (SystemException e) { Console.WriteLine(e); }
                }   
                
            } while (opcion != "a");

        }
    }
}
