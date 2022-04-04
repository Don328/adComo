using adComo.Services;
using adComo.Services.MenuServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay.Menu
{
    internal class NewTaskMenu
    {
        public static void Show()
        {
            Console.WriteLine();
            Console.WriteLine("[1]Crete New Task");
            Console.WriteLine("[7]Change Status");
            Console.WriteLine("[8]Add Note");
            Console.WriteLine("[9]Delte Task");
            Console.WriteLine("[0]Main Menu");
        }
    }
}
