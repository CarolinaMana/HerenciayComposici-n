using HerenciayComposición;
using System;

namespace HerenciayComposición
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Instanciar el departamento
            Departamento deptoTecnologia = new Departamento("Tecnología e Innovación");

            // 2. Crear al menos tres objetos (combinando Empleado base y Desarrollador)
            Empleado emp1 = new Empleado(101, "Carlos Martínez", 45000m);
            Desarrollador dev1 = new Desarrollador(102, "Ana Gómez", 65000m, "C#");
            Desarrollador dev2 = new Desarrollador(103, "Luis Rodríguez", 62000m, "Python");

            // 3. Registrar los empleados en el departamento
            deptoTecnologia.AgregarEmpleado(emp1);
            deptoTecnologia.AgregarEmpleado(dev1);
            deptoTecnologia.AgregarEmpleado(dev2);

            // 4. Listar los empleados registrados
            deptoTecnologia.ListarEmpleados();

            Console.ReadKey();
        }
    }
}