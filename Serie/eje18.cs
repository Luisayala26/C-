using System;
using System.IO;
/*
Realizar una investigación del manejo de archivos en C# y hacer un programa libre que implique el manejo de archivos
En esta clase se muetra el manejo de archivos  en la cual se lee el contenido de un archivo y se muestra en pantalla
Tambien Se crea un archivo y se le agrega al una linea de texto al archivo que se crea
*/
namespace eje18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lectura de un archivo 
            string file = "eje18.cs";
            try 
            {
                FileStream stream = new FileStream(file, FileMode.Open,FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1) Console.WriteLine(reader.ReadLine());
                reader.Close();
            }
            catch (SystemException e) { Console.WriteLine(e); }

            //Creacion de un archivo
            file = "ArchivoNuevo.txt";
            StreamWriter writer = File.CreateText(file);
            writer.WriteLine("Este es el archivo que se acaba de crear");
            writer.Close();

            //Escritura en un archivo
            try
             {
             writer = File.AppendText(file);
             writer.WriteLine("Linea agregada al archivo");
             writer.Close();
             }
            catch(SystemException e){    Console.WriteLine(e);    }
        }
    }
}
