using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Problema_02Importan
{
    internal class Program
    {


        static void Main(string[] args)
        {

            string ruta = ConfigurationManager.AppSettings["ruta"].ToString();/*Cuando no sale apunta al foco roto y busca agregar sys.configuration*/

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(ruta);
                string texto = reader.ReadToEnd();
                Console.WriteLine("Texto : "+ texto); /*Lee todo*/
                /*

                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    linea = reader.ReadLine();
                } este lee linea por linea
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine("error : " + ex.Message);
            }
            finally
            {
                reader.Close();
            }

            Console.ReadKey();

        }
    }
}
