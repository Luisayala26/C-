using System;
using System.Collections.Generic;
/*
5. Se debe simular una agenda telefónica. Cuando inicie el programa se debe desplegar un menú
con las opciones:
Agregar contacto
Eliminar contacto
Mostrar contacto
Salir
Los contactos van a ser almacenados en un diccionario (investiguen la colección Dictionary)
en donde las llaves son los nombres de los contactos y sus valores van a ser los teléfonos.
Hacer pruebas en en el método Main.

*/
namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            Dictionary<string, double> dic = new Dictionary<string, double>();//creacion de diccionario
            do{
                 Console.WriteLine("Agenda Telefonica");
                 Console.WriteLine("a) Agregar contacto");
                 Console.WriteLine("b) Eliminar contacto");
                 Console.WriteLine("c) Mostrar Contacto");
                 Console.WriteLine("s)Salir");
                 Console.WriteLine("Elije una opcion: ");
                 opcion=Console.ReadLine();

                 if(opcion=="a"){
                    /*Se agregan los elementos verificados al diccionario*/
                    Console.WriteLine("Nombre");
                    string nom=Console.ReadLine();
                    Console.WriteLine("Telefono 10 digitos");
                    try{
                        double num=Convert.ToDouble(Console.ReadLine());
                        if(num<1000000000 || num>10000000000){
                            Console.WriteLine("telefono invalido\n");
                        }
                        else{   
                            dic.Add(nom,num);
                            Console.WriteLine("Usuario Agregado\n");
                        }
                    }
                    catch (SystemException e) { Console.WriteLine("{0}",e); }
                 }
                 else if(opcion=="b"){
                    /*Se borra el usuario con el nombre que se indique */
                    Console.WriteLine("Nombre");
                    string nom=Console.ReadLine();
                    if(dic.ContainsKey(nom)){
                        dic.Remove(nom);
                        Console.WriteLine("Usuario borrado\n");    
                    }
                    else{
                        Console.WriteLine("Usuario no encontrado\n");
                    }
                 }
                 else if(opcion=="c"){
                    /*SE muestra el contacto que el usuario indique*/
                    Console.WriteLine("Nombre");
                    string nom=Console.ReadLine();
                    if(dic.ContainsKey(nom)){
                        Console.WriteLine("\n{0} {1}\n",nom,dic[nom]);
                    }
                    else{
                        Console.WriteLine("No existe el usuario");
                    }
                 }
                 else if(opcion=="s"){Console.WriteLine("\nHasta luego ");}
                 else{Console.WriteLine("\nOpcion incorrecta elija otra opcion\n");}
            }while(opcion!="s");//ciclo para mantenerte dentro de  la agenda

        }
    }
}