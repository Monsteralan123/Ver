using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problema_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "D:\\Log\\hola.txt";
            
           /* StreamReader reader = null; */

            try
            {
                /*Validar existencia de la ruta*/

               if (File.Exists("D:\\Log\\holaa.txt"))
                {
                    Console.WriteLine("Existe");
                }
                else
                {
                    File.Create("D:\\Log\\holaa.txt");
                    Console.WriteLine("No Existe");
                    Console.WriteLine("Se Crea archivo");
                }
                /*
                 Thread.Sleep(5000);
                 File.Delete("D:\\Log\\holaa.txt");*/

                DateTime fecha = DateTime.Now;
                String codigo= Guid.NewGuid().ToString();
                Console.WriteLine($"Codigo : {codigo}");

                string rutaDBackup = "D:\\Log\\Backup\\holaa" + fecha.ToString("yyyyMMdd_HHmmss") + ".txt";
                string rutaDEnviados = "D:\\Log\\Enviados\\holaa" + fecha.ToString("yyyyMMdd_HHmmss") + ".txt";

                Console.WriteLine("Rute Destino Backup " + rutaDBackup);
                Console.WriteLine("Rute Destino Enviados " + rutaDEnviados);


                File.Copy("D:\\Log\\holaa.txt",rutaDEnviados);

           /**     File.Move("D:\\Log\\holaa.txt", rutaDBackup); **/

                if (File.Exists("D:\\Log\\holaa.txt"))
                    {
                    FileInfo archivo = new FileInfo("D:\\Log\\holaa.txt");
                    Console.WriteLine("Ruta : " + archivo.FullName);
                    Console.WriteLine("Nombre : " + archivo.Name);
                    Console.WriteLine("Extension :" + archivo.Extension);
                    Console.WriteLine("Temano : " + archivo.Length);
                    Console.WriteLine("Fecha de Creacion : " + archivo.CreationTime);
                     }

                Console.ReadKey();


                /*
                reader = new StreamReader("D:\\Log\\holaa.txt");
                
                string texto = reader.ReadToEnd();
                Console.WriteLine("Texto : " + texto); */

            }
            catch (Exception ex)
            {
                Console.WriteLine("error : " + ex.Message);
            }
            finally
            {
             /*   reader.Close(); */
            }

            Console.ReadKey();

        }
    }
}
