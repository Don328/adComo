using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay
{
    internal static class CompletedTasks
    {
        public static void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Completed Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in Program.State.Completum)
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
                        NotaDisplay.Show(nota);
                    }
                }
                else
                {
                    Console.WriteLine("*None*");
                }
                Console.WriteLine();
            }
        }
    }
}
