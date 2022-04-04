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
    internal static class PendingTasks
    {
        internal static void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("Pending Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in Program.State.Pendente)
            {
                ShowOne(opus);
            }

            PendingTaskMenuService.Show();
        }

        internal static void ShowOne(Opus opus)
        {
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
