using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayComposición
{

        public class Departamento
        {
            public string NombreDepartamento { get; set; }

            // Colección de empleados (Composición / Agregación)
            private List<Empleado> _empleados;

            public Departamento(string nombreDepartamento)
            {
                NombreDepartamento = nombreDepartamento;
                _empleados = new List<Empleado>();
            }

            public void AgregarEmpleado(Empleado empleado)
            {
                _empleados.Add(empleado);
            }

            public void ListarEmpleados()
            {
                Console.WriteLine($"\n==========================================");
                Console.WriteLine($" DEPARTAMENTO: {NombreDepartamento.ToUpper()}");
                Console.WriteLine($"==========================================");

                if (_empleados.Count == 0)
                {
                    Console.WriteLine("No hay empleados registrados en este departamento.");
                    return;
                }

                foreach (var emp in _empleados)
                {
                    emp.MostrarInformacion();
                }
                Console.WriteLine($"Total de empleados: {_empleados.Count}\n");
            }
        }
    }