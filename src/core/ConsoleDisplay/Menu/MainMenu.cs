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
                    ActiveTasks.Show();
                    Show();
                    break;
                case ConsoleKey.D3:
                    PendingTasks.Show();
                    Show();
                    break;
                case ConsoleKey.D4:
                    CompletedTasks.Show();
                    Show();
                    break;
                case ConsoleKey.D9:
                    NewTasks.ShowAll();
                    ActiveTasks.Show();
                    PendingTasks.Show();
                    CompletedTasks.Show();
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
