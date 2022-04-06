using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay.ChangeStatus
{
    internal static class ChangePending
    {
        internal static void ShowPrompt()
        {
            Console.WriteLine("Pending Tasks can be changed to active");
            Console.WriteLine("[0]Cancel");
        }

        internal static void PromptForOpusId()
        {
            Console.WriteLine("Enter Task Id:");
        }

        internal static void OpusIdNotFound()
        {
            Console.WriteLine("Id not found");
            Console.WriteLine("Please enter a valid Task Id from the Pending Tasks list");
        }

        internal static void ConfirmStatusChange()
        {
            Console.WriteLine("Change status to Active?");
            Console.WriteLine("[1]Confirm [0]Cancel");
        }
    }
}
