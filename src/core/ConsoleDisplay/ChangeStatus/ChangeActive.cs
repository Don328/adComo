using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay.ChangeStatus
{
    internal static class ChangeActive
    {
        internal static void PromptForOpusId()
        {
            Console.WriteLine("Enter Task Id:");
        }

        internal static void OpusIdNotFound()
        {
            Console.WriteLine("Id not found");
            Console.WriteLine("You must enter a vaid Id from a task in the Active Tasks list");
        }

        internal static void ShowPrompt()
        {
            Console.WriteLine("Active tasks can be changed to pending or completed.");
            Console.WriteLine("[0]Cancel");
        }

        internal static void PromptForNewStatus()
        {
            Console.WriteLine("Select new Status: [1]Pending [2]Completed [0]Cancel");

        }
    }
}
