using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay.Menu
{
    internal class MainMenu
    {
        internal static void Show()
        {
            Console.WriteLine(
                "Select Display: [1]New " +
                "[2]Active [3]Pending " +
                "[4]Completed " +
                "[9]All [0]Exit");
        }
    }
}
