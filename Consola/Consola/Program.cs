using System;
using System.IO;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0}", path);
            var Npath = path.Split(@"\");
            string busqueda = Npath[0] + @"\" + Npath[1] + @"\" + Npath[2];
            string opcion = "";
            string bash = "";
            try { String[] dirs = Directory.GetDirectories(busqueda, @"Docu*");
                bash = dirs[0];
            }
            catch (SystemException e) { Console.WriteLine(e); }
            do
            {
                try
                {
                    Console.Write(bash + ">");
                    opcion = Console.ReadLine();
                    if (opcion.Contains("Dir")|| opcion.Contains("dir")) 
                    {
                        if (opcion == "dir" || opcion == "Dir")
                        {
                            Funciones.Directorio(bash, opcion);
                        }
                        else
                        {
                            if (opcion.Split(" ").Length <= 2)
                                if (Directory.Exists(opcion.Split(" ")[1]))
                                {
                                    Funciones.Directorio(opcion.Split(" ")[1], opcion);
                                }
                                else
                                {
                                    Console.WriteLine("No existe el directorio {0}", opcion.Split(" ")[1]);
                                }
                            else { Console.WriteLine("Comando incorrecto"); }
                        }
                    }
                    else if (opcion.Contains("Cd")|| opcion.Contains("cd")) 
                    { 
                        if (opcion == "cd" || opcion == "CD")
                        {
                            Console.WriteLine(bash);
                        }
                        else 
                        {
                            if (opcion.Split(" ").Length <= 2)
                                bash=Funciones.Cambio(bash,opcion.Split(" ")[1], opcion);
                            else { Console.WriteLine("Comando incorrecto"); }
                        }
                    }
                    else if (opcion.Contains("Touch")|| opcion.Contains("touch")) 
                    {
                        if (opcion == "Touch" || opcion == "touch")
                        {
                            Console.WriteLine("Falta el nombre del archivo");
                        }
                        else
                        {
                            if (opcion.Split(" ").Length <= 2)
                                Funciones.archivo(bash,opcion.Split(" ")[1],opcion);

                            else { Console.WriteLine("Comando incorrecto"); }
                        }
                    }
                    else if (opcion.Contains("Move")|| opcion.Contains("move")) 
                    { 
                        if (opcion == "Move" || opcion == "move")
                        {
                            Console.WriteLine("Falta el origen y destino ");
                        }
                        else if (opcion.Split(" ").Length <= 2) 
                        {
                            Console.WriteLine("Falta el origen o el destino ");
                        }
                        else
                        {
                            if (opcion.Split(" ").Length <= 3)
                                Funciones.Mover(opcion.Split(" ")[1], opcion.Split(" ")[2],opcion);

                            else { Console.WriteLine("Comando incorrecto"); }
                        }
                    }
                    else if (opcion=="History"||opcion=="history") { Funciones.historial(opcion); }
                    else if (opcion=="Cls"|| opcion=="cls") { Console.WriteLine("Cls"); Funciones.Borrar(opcion);  }
                    else if (opcion == "Exit" || opcion == "exit") { opcion = "salir"; }
                    else { Console.WriteLine("Opcion no encontrada"); }

                }
                catch (SystemException e){    Console.WriteLine(e);    }
            } while (opcion!="salir");
        }
    }
}
