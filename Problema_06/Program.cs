using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dire = new DirectoryInfo("D:\\Log");

            DirectoryInfo [] director = dire.GetDirectories();

            foreach (DirectoryInfo directori in director) 
            { 
            
                Console.WriteLine(directori.FullName);
                FileInfo[] archivos = directori.GetFiles();
                foreach(FileInfo archivo in archivos) 
                {
                Console.WriteLine("Nombre Archivo : " + archivo.Name);
                Console.WriteLine("Nombre Extension : " + archivo.Extension);
                }

            
            }

            Console.ReadKey();
        }
    }
}
