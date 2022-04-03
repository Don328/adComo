using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay
{
    internal static class ActiveTasks
    {
        public static void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Active Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in Program.State.Accedant)
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
