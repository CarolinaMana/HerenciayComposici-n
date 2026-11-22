using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciayComposición
{
    // Desarrollador hereda de Empleado
    public class Desarrollador : Empleado
    {
        public string LenguajePrincipal { get; set; }

        // Uso de 'base' para invocar el constructor de la clase padre (Empleado)
        public Desarrollador(int id, string nombre, decimal salarioBase, string lenguajePrincipal)
            : base(id, nombre, salarioBase)
        {
            LenguajePrincipal = lenguajePrincipal;
        }

        // Sobrescritura del método para incluir su propiedad específica
        public override void MostrarInformacion()
        {
            Console.WriteLine($"[ID: {Id}] Nombre: {Nombre} | Salario Base: {SalarioBase:C} | Rol: Desarrollador ({LenguajePrincipal})");
        }
    
    }
}
