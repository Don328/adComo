using adComo.Services.MenuServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay.Menu
{
    internal static class ActiveTaskMenu
    {
        public static void Show()
        {
            Console.WriteLine();

            Console.WriteLine("[7]Change Status");
            Console.WriteLine("[8]Add Note");
            Console.WriteLine("[9]Delete Task");
            Console.WriteLine("[0]Main Menu");
        }
    }
}
