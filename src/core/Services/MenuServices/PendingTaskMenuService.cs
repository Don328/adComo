using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.Services.MenuServices
{
    internal static class PendingTaskMenuService
    {
        internal static void Show()
        {
            PendingTaskMenu.Show();
            GetResponse();
        }

        private static void GetResponse()
        {
            var input = Console.ReadKey().Key;
            switch(input)
            {
                case ConsoleKey.D7:
                    PendingTaskService.ChangeStatus();
                    PendingTasks.ShowAll();
                    break;
                case ConsoleKey.D8:
                    break;
                case ConsoleKey.D9:
                    PendingTaskService.Remove();
                    PendingTasks.ShowAll();
                    break;
                case ConsoleKey.D0:
                    MainMenuService.Show();
                    break;
                default:
                    PendingTasks.ShowAll();
                    break;
            }
        }
    }
}
