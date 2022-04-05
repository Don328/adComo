using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay.DeleteDisplay
{
    internal static class RemoveTask
    {
        internal static void RemoveNewTask()
        {
            Console.WriteLine("Chose a task form the New Tasks list to remove");
        }

        internal static void RemoveActiveTask()
        {
            Console.WriteLine("Chose a task form the Active Tasks list to remove");
        }

        internal static void RemovePendingTask()
        {
            Console.WriteLine("Chose a task form the Pending Tasks list to remove");
        }

        internal static void ShowWarningMessage()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("DELETE TASK");
            Console.WriteLine("********************************");
            Console.WriteLine("This will permenantly remove this task");
            Console.WriteLine("********************************");
        }

        internal static void RequestConfirmation()
        {
            Console.WriteLine();
            Console.WriteLine("Are you sure? [1]Delete [0]Cancel");
        }
    }
}
