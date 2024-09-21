using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> emple = new List<Empleado>();
            Empleado empleadO1 = new Empleado( 2 , "Rosa" , 140 );

            emple.Add(new Empleado()
            {
                codigo = 1,
                nombres = "Pablo",
                sueldo = 120
            });
            emple.Add(empleadO1);
            emple.Add(new Empleado(3 , "Ariana" , 144));
            emple.Add(new Empleado(4, "Matias", 402));
            imprimir(emple);
            Console.WriteLine("*******************************");
            List<Empleado> lista1 = emple.OrderBy(x => x.nombres).ToList();
            imprimir(lista1);
            Console.WriteLine("*******************************");
            List<Empleado> lista2 = emple.OrderByDescending(x => x.nombres).ToList();
            imprimir(lista2);
            Empleado objEmpleado = emple.Where(x => x.codigo == 2).ToList().First();
            Console.WriteLine("Empleado : " + objEmpleado.codigo);
            Console.WriteLine("*******************************");
            List<Empleado> listaBuscarEmp = emple.Where(x => x.sueldo > 200).ToList();
            imprimir(listaBuscarEmp);
            Console.WriteLine("*******************************");
            int indece = emple.FindIndex(x => x.codigo == 2);
            Console.WriteLine("indice : " + indece);
            Console.WriteLine("*******************************");
            emple.RemoveAt(indece);




            Console.ReadKey();
          
        }
        public static void imprimir(List<Empleado> lista)
        { 
        foreach(Empleado x in lista)
            {
            Console.WriteLine(x.codigo + " - " + x.nombres + " - " + x.sueldo);
            }
        }
    }
}
