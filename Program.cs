namespace SimuladorMonoprocesador
{

    //Christian Gil - 2012-1031
    //Tarea 4 - Simulador Monoprocesador
    class Program
    {
        static void Main()
        {
            Monoprocesador cpu = new();

            Console.Write("¿Deseas agregar tareas manualmente? [s/n]: ");
            bool manual = Console.ReadLine()?.ToLower() == "s";

            if (manual)
            {
                while (true)
                {
                    Console.Write("Nombre de la tarea ([Enter] para terminar de cargar tareas): ");
                    string? nombre = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("Terminando ingreso de tareas...");
                        break;
                    }

                    Console.Write("Duración en segundos: ");
                    if (!int.TryParse(Console.ReadLine(), out int duracion) || duracion <= 0)
                    {
                        Console.WriteLine("Duración inválida. Intenta de nuevo.");
                        continue;
                    }

                    cpu.AgregarTarea(new Tarea(nombre, duracion));
                }
            }
            else
            {
                cpu.AgregarTarea(new Tarea("Reproducir musica", 5));
                cpu.AgregarTarea(new Tarea("Abrir word", 3));
                cpu.AgregarTarea(new Tarea("Crear archivo", 4));
            }

            cpu.EjecutarTareas();
        }
    }
}
