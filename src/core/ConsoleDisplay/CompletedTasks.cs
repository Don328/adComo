using adComo.ConsoleDisplay.Menu;
using adComo.Models;
using adComo.Services.MenuServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay
{
    internal static class CompletedTasks
    {
        internal static void ShowAll()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Completed Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in Program.State.Completum)
            {
                ShowOne(opus);
            }

            CompletedTaskMenuService.Show();
        }

        internal static void ShowOne(Opus opus)
        {
            Console.Clear();
            Console.WriteLine($"Title: {opus.Title}");
            Console.WriteLine("----------------");
            Console.WriteLine($"Id: {opus.OpusId}");
            Console.WriteLine($"Status: {opus.Status}");
            Console.WriteLine();
                
            if (opus.Notas.Any())
            {
                Console.WriteLine("Notes:");
                Console.WriteLine("--------");
                
                foreach (var nota in opus.Notas)
                {
                    NotaDisplay.Show(nota);
                }
            }
            
            Console.WriteLine();
        }
    }
}
