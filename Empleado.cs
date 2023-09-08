using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advance1Atos
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }
        //Clave foranea
        public int EmpresaId { get; set; }

        public void getDatosEmpleado(){
            Console.WriteLine("Empleado {0} con ID {1}, Cargo {2} con salario {3} y pertenece a la empresa {4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }

    }
}
