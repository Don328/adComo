using adComo.Data;
using adComo.Models;

namespace adComo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(1000);
            var state = new State();
            DisplayNewTasks(state);
            await Task.Delay(1000);
            DisplayActiveTasks(state);
            await Task.Delay(1000);
            DisplayPendingTasks(state);
            await Task.Delay(1000);
            DisplayCompletedTasks(state);
        }

        private static void DisplayNewTasks(State state)
        {
            Console.WriteLine();
            Console.WriteLine("New Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in state.Novus)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine("----------------");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
                Console.WriteLine("Notes:");
                Console.WriteLine("--------");
                if (opus.Notas.Any())
                {
                    foreach (var nota in opus.Notas)
                    {
                        DisplayNota(nota);
                    }
                }
                else
                {
                    Console.WriteLine("*None*");
                }
                Console.WriteLine();
            }
        }

        private static void DisplayActiveTasks(State state)
        {
            Console.WriteLine();
            Console.WriteLine("Active Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in state.Accedant)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine("----------------");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
                Console.WriteLine("Notes:");
                Console.WriteLine("--------");
                if (opus.Notas.Any())
                {
                    foreach (var nota in opus.Notas)
                    {
                        DisplayNota(nota);
                    }
                }
                else
                {
                    Console.WriteLine("*None*");
                }
                Console.WriteLine();
            }
        }

        private static void DisplayPendingTasks(State state)
        {
            Console.WriteLine();
            Console.WriteLine("Pending Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in state.Pendente)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine("----------------");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
                Console.WriteLine("Notes:");
                Console.WriteLine("--------");
                if (opus.Notas.Any())
                {
                    foreach (var nota in opus.Notas)
                    {
                        DisplayNota(nota);
                    }
                }
                else
                {
                    Console.WriteLine("*None*");
                }
                Console.WriteLine();
            }
        }

        private static void DisplayCompletedTasks(State state)
        {
            Console.WriteLine();
            Console.WriteLine("Completed Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in state.Completum)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine("----------------");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
                Console.WriteLine("Notes:");
                Console.WriteLine("--------");
                if (opus.Notas.Any())
                {
                    foreach (var nota in opus.Notas)
                    {
                        DisplayNota(nota);
                    }
                }
                else
                {
                    Console.WriteLine("*None*");
                }
                Console.WriteLine();
            }
        }

        private static void DisplayNota(Nota nota)
        {
            Console.WriteLine($"OpusId: {nota.OpusId}");
            Console.WriteLine($"Title: {nota.Title}");
            Console.WriteLine($"NotaId: {nota.NotaId}");
            Console.WriteLine($"Text: {nota.Text}");
            Console.WriteLine("--------");
            Console.WriteLine();
        }
    }
}