using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.Services.MenuServices
{
    internal static class ActiveTaskMenuService
    {
        internal static void Show()
        {
            ActiveTaskMenu.Show();
            GetResponse();
        }

        private static void GetResponse()
        {
            var input = Console.ReadKey().Key;
            Console.Clear();
            switch (input)
            {
                case ConsoleKey.D7:
                    ActiveTasks.ChangeStatus();
                    NewTasks.ShowAll();
                    break;
                case ConsoleKey.D9:
                    ActiveTaskService.Remove();
                    ActiveTasks.ShowAll();
                    break;
                case ConsoleKey.D0:
                    MainMenuService.Show();
                    break;
                default:
                    ActiveTasks.ShowAll();
                    break;
            }
        }
    }
}
