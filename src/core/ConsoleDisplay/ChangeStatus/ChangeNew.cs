using adComo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay.ChangeStatus
{
    internal static class ChangeNew
    {
        internal static Opus PromptForOpusId()
        {
            Console.WriteLine("New tasks can be changed to active or pending.");
            Console.WriteLine("[0]Cancel");
            Console.WriteLine("Enter Task Id:");
            var IdToChange = Console.ReadLine();
            if (IdToChange == "0" || IdToChange == null)
            {
                NewTasks.Show();
            }
            
            var opusToChange = (from o in Program.State.Novus
                                where o.OpusId.ToString() == IdToChange
                                select o).FirstOrDefault();
            
            if (opusToChange == null)
            {
                return OpusIdNotFound();
            }
            else
            {
                return opusToChange;
            }
        }

        internal static ConsoleKey PromptForNewStatus()
        {
            Console.WriteLine("Select new Status: [1]Active [2]Pending [0]Cancel");
            var newStatus = Console.ReadKey().Key;
            Console.WriteLine();
            if (newStatus != ConsoleKey.D1
                && newStatus != ConsoleKey.D2
                && newStatus != ConsoleKey.D0)
            {
                Console.WriteLine("Please select one of the available options.");
                Console.WriteLine();
                PromptForNewStatus();
            }
         
            return newStatus;
        }

        internal static Opus OpusIdNotFound()
        {
            Console.WriteLine("Id not found");
            Console.WriteLine("You must enter a vaid Id from a task in the New Tasks list");
            return PromptForOpusId();
        }
    }
}
