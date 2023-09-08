using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advance1Atos
{
    internal class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
            
        public void getDatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con ID {1} ", Nombre, Id);
        }
    }
}
