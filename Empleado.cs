using System;

namespace HerenciayComposición
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }

        public Empleado(int id, string nombre, decimal salarioBase)
        {
            Id = id;
            Nombre = nombre;
            SalarioBase = salarioBase;
        }

        // Método virtual para permitir que las clases hijas amplíen la información
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"[ID: {Id}] Nombre: {Nombre} | Salario Base: {SalarioBase:C}");
        }
    }
}
