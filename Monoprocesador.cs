using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorMonoprocesador
{
    public class Monoprocesador
    {
        private readonly Queue<Tarea> _colaTareas = new();

        public void AgregarTarea(Tarea tarea)
        {
            _colaTareas.Enqueue(tarea);
            Console.WriteLine($"Se agregó  a la cola la tarea [{tarea.Nombre}] (duración: {tarea.DuracionSegundos}s)");
        }

        public void EjecutarTareas()
        {
            Console.WriteLine("=== Ejecución iniciada ===");

            while (_colaTareas.Count > 0)
            {
                Tarea tareaActual = _colaTareas.Dequeue();
                tareaActual.Ejecutar();
            }

            Console.WriteLine("=== Tareas completadas ===");
        }
    }
}
