using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*  *//

            List<int> lista = new List<int>();

            lista.Add(11);
            lista.Add(24);  
            lista.Add(34);
            lista.Add(42);
            lista.Add(5423);
            lista.Add(612);
            lista.Add(75);
            lista.Add(84);
            lista.Add(4);
            lista.Add(14);
            lista.Add(14);
            imprimirArreglo(lista);
            /*Metodos de list*/
            /*  int contar = lista.Count;
              Console.WriteLine("Total de Elementos : "+contar);
              Console.WriteLine("**********************");
              lista.Sort();
              imprimirArreglo(lista);
              Console.WriteLine("**********************");
              lista.Reverse();
              imprimirArreglo(lista);
            */
            /* lista.Remove(11);
              imprimirArreglo(lista);
              lista.RemoveAt(11);
              imprimirArreglo(lista);
            
            lista.RemoveAll(x => x == 14);
           
            Console.WriteLine("**********************");
            lista.RemoveRange(1,2);
            imprimirArreglo(lista);
            

            Console.WriteLine("**********************");
            lista.RemoveAll(x => x % 2 == 0);/* 0 para borrar los pares / 1 para borrar los imparas */
           /*  imprimirArreglo(lista); */ 
            int buscarNumero = lista.IndexOf(11);
            Console.WriteLine("Buscar mi,ero 11 (posiscion) = "+buscarNumero); /*Si el numer ono existe envia -1*/
            int buscarElemento1 = lista.First();
            Console.WriteLine("Leer primer elemento : " + buscarElemento1);

            int buscarElemento2 = lista.FirstOrDefault(x => x == 14);
            Console.WriteLine("primer elemento1 : "+buscarElemento2);


            bool existeElemento = lista.Exists(x => x == 14);
            Console.WriteLine("existe : " + existeElemento);
            lista.Clear();
            Console.ReadKey();

}
public static void imprimirArreglo(List<int> lista) {

  foreach (int i in lista) {

      Console.WriteLine(i);
  }

}

}
}
