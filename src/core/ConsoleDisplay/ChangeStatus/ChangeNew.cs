using adComo.Models;
using adComo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay.ChangeStatus
{
    internal static class ChangeNew
    {
        internal static void ShowPrompt()
        {
            Console.WriteLine("New tasks can be changed to active or pending.");
            Console.WriteLine("[0]Cancel");
        }

        internal static void PromptForOpusId()
        {
            Console.WriteLine("Enter Task Id:");
        }

        internal static void PromptForNewStatus()
        {
            Console.WriteLine("Select new Status: [1]Active [2]Pending [0]Cancel");
        }

        internal static void OpusIdNotFound()
        {
            Console.WriteLine("Id not found");
            Console.WriteLine("You must enter a vaid Id from a task in the New Tasks list");
        }
    }
}
