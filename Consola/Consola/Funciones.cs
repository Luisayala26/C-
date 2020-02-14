using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;


namespace Consola
{
    class Funciones
    {
        public static List<string> his = new List<string>();
        public static void historial(string valor) 
        {
            his.Add(valor);
            foreach (var i in his) { Console.WriteLine(i); }
        }
        public static void Borrar(string valor)
        {
            his.Add(valor);
            Console.Clear();
        }
        public static void Directorio(string path,string valor)
        {
            his.Add(valor);
            string[] Archivos = Directory.GetFiles(path);
            foreach (string file in Archivos)
                Console.WriteLine(file.Split(@"\")[file.Split(@"\").Length-1]);
            string[] carpetas = Directory.GetDirectories(path +@"\");
            foreach (string carpeta in carpetas)
                Console.WriteLine(carpeta.Split(@"\")[carpeta.Split(@"\").Length - 1]);      
        }

        public static string Cambio(string path, String Ncarpeta,string valor)
        {
            
            if (Ncarpeta == "..")
            {
                his.Add(valor);
                string[] arrpath = path.Split(@"\");
                string bash=arrpath[0];
                
                for (int i=1; i<arrpath.Length-1;i++) 
                {
                    bash += @"\"+arrpath[i];
                }
                return bash;
            }
            else 
            {
                string opcion = path + @"\" + Ncarpeta;
                if (Directory.Exists(opcion))
                {
                    his.Add(valor);
                    return opcion;
                }
                else
                {
                    Console.WriteLine("No existe el directorio {0}", opcion);
                    return path;
                }
            }
            
        }

        public static void archivo(string path, String Nombre, string valor) 
        {
            if (Nombre.Contains(@":\")) 
            {
                try
                {
                    if (File.Exists(Nombre))
                    {
                        his.Add(valor);
                        Console.WriteLine("Archivo Existe");
                    }
                    else
                    {
                        his.Add(valor);
                        Console.WriteLine("Archivo creado en "+Nombre);
                        StreamWriter writer = File.CreateText(Nombre);
                        writer.WriteLine(" ");
                        writer.Close();
                    }
                }
                catch (SystemException e) { Console.WriteLine(e); }
            }
            else
            {
                try
                {
                    if (File.Exists(path+ @"\" + Nombre))
                    {
                        his.Add(valor);
                        Console.WriteLine("Archivo Existe");

                    }
                    else
                    {
                        his.Add(valor);
                        Console.WriteLine("Archivo creado en " + path + @"\" + Nombre);
                        StreamWriter writer = File.CreateText(path+ @"\" + Nombre);
                        writer.WriteLine(" ");
                        writer.Close();
                    }
                }
                catch (SystemException e) { Console.WriteLine(e); }
            }

            
        }

        public static void Mover(string origen,String destino, string valor)
        {
            //Console.WriteLine(origen);
            if (File.Exists(origen))
            {
                try
                {
                    Directory.Move(origen, destino);
                }
                catch (SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else 
            {
                Console.WriteLine("El archivo de origen no existe");
            }
        }
    }
}
