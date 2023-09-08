using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advance1Atos
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados() { 
            
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id=1, Nombre = "Eviden"});
            listaEmpresas.Add(new Empresa { Id=2, Nombre = "Atos"});

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Avir", Cargo = "Intern", EmpresaId = 1, Salario = 1000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Jose", Cargo = "Intern", EmpresaId = 2, Salario = 1000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Jaime", Cargo = "CEO", EmpresaId = 2, Salario = 100000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Daniel", Cargo = "CEO", EmpresaId = 1, Salario = 100000 }); 

        }

        public void getCEO()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;

            foreach (Empleado item in ceos)
            {
                item.getDatosEmpleado();
            }

        }

        public void getEmpleadosOrdenados() {

            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre select empleado;

            foreach (Empleado item in empleados)
            {
                item.getDatosEmpleado();
            }
        }

        public void getEmpleadosEmpresa(int id)
        {

            IEnumerable<Empleado> empleadosEv = from empleado in listaEmpleados join empresa in listaEmpresas on empleado.EmpresaId equals empresa.Id 
                                              where empresa.Id == id select empleado;

            foreach (Empleado item in empleadosEv)
            {
                item.getDatosEmpleado();
            }
        }


    }
}
