using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_03
{
    internal class Empleado
    {
        public int codigo { get; set; }
        public string nombres { get; set; }
        public double sueldo { get; set; }

        public Empleado() { }

        public Empleado(int codigo, string nombres, double sueldo)
        {
            this.codigo = codigo;
            this.nombres = nombres;
            this.sueldo = sueldo;
        }
    }
}
