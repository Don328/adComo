using adComo.ConsoleDisplay.ChangeStatus;
using adComo.ConsoleDisplay.Menu;
using adComo.Enums;
using adComo.Factories;
using adComo.Models;
using adComo.Services.MenuServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay
{
    internal static class NewTasks
    {
        internal static void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("New Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in Program.State.Novus)
            {
                ShowOne(opus);
            }

            NewTaskMenuService.Show();
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
