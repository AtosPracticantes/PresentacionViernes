using C_Advance1Atos;

class Program()
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main program");

        ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();

        try
        {
            Console.WriteLine("Introduce el id de la empresa de la cual deseas obtener los empleados:");
            int selectedId = Convert.ToInt32(Console.ReadLine());
            ce.getEmpleadosEmpresa(selectedId);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Introdujiste un valor no valido");
            Console.WriteLine(ex.Message);  
        }


    }
}