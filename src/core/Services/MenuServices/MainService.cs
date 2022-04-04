using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.Services.MenuServices
{
    internal static class MainMenuService
    {
        internal static void Show()
        {
            MainMenu.Show();
            GetResponse();
        }

        private static void GetResponse()
        {
            var key = Console.ReadKey().Key;
            Program.State.SelectMenu(key);
            Console.Clear();
            switch (Program.State.SelectedMenu)
            {
                case ConsoleKey.D1:
                    NewTasks.ShowAll();
                    Show();
                    break;
                case ConsoleKey.D2:
                    ActiveTasks.ShowAll();
                    Show();
                    break;
                case ConsoleKey.D3:
                    PendingTasks.ShowAll();
                    Show();
                    break;
                case ConsoleKey.D4:
                    CompletedTasks.ShowAll();
                    Show();
                    break;
                case ConsoleKey.D9:
                    NewTasks.ShowAll();
                    ActiveTasks.ShowAll();
                    PendingTasks.ShowAll();
                    CompletedTasks.ShowAll();
                    Show();
                    break;
                case ConsoleKey.D0:
                    break;
                default:
                    Show();
                    break;
            }
        }
    }
}
