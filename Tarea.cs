using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorMonoprocesador
{
    public class Tarea
    {
        public string Nombre { get; set; }
        public int DuracionSegundos { get; set; }

        public Tarea (string nombre, int duracionSegundos)
        {
            Nombre = nombre;
            DuracionSegundos = duracionSegundos;
        }

        public void Ejecutar()
        {
            Console.WriteLine($"[Iniciando] {Nombre} - {DateTime.Now:T}");
            Thread.Sleep(DuracionSegundos * 1000);
            Console.WriteLine($"[Finalizando] {Nombre} - {DateTime.Now:T}");
        }
    }
}
