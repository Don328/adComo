using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.Services.MenuServices
{
    internal static class CompletedTaskMenuService
    {
        internal static void Show()
        {
            CompletedTaskMenu.Show();
            GetResponse();
        }

        private static void GetResponse()
        {
            var input = Console.ReadKey().Key;
            switch(input)
            {
                case ConsoleKey.D0:
                    MainMenuService.Show();
                    break;
                default:
                    CompletedTasks.ShowAll();
                    break;
            }
        }
    }
}
