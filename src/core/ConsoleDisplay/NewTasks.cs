using adComo.ConsoleDisplay.Menu;
using adComo.Enums;
using adComo.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay
{
    internal static class NewTasks
    {
        internal static void Show()
        {
            Console.WriteLine();
            Console.WriteLine("New Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in Program.State.Novus)
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

            NewTaskMenu.Show();
        }

        internal static void ChangeStatus()
        {
            Console.WriteLine("New tasks can be changed to active or pending.");
            Console.WriteLine("Enter Task Id:");
            var IdToChange = Console.ReadLine();
            Console.WriteLine("Select new Status: [1]Active [2]Pending");
            var newStatus = Console.ReadKey().Key;
            Console.WriteLine();
            var opusToChange = (from o in Program.State.Novus
                                where o.OpusId.ToString() == IdToChange
                                select o).FirstOrDefault();

            if (opusToChange != null)
            {
                if (newStatus == ConsoleKey.D1)
                {
                    opusToChange.Status = OpusStatus.Active;
                    Program.State.Accedant.Add(opusToChange);
                    Program.State.Novus.Remove(opusToChange);
                }

                if (newStatus == ConsoleKey.D2)
                {
                    opusToChange.Status = OpusStatus.Pending;
                    Program.State.Pendente.Add(opusToChange);
                    Program.State.Novus.Remove(opusToChange);
                }
            }
        }
    }
}
