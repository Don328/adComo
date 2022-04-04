using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.Services.MenuServices
{
    internal static class NewTaskMenuService
    {
        internal static void Show()
        {
            NewTaskMenu.Show();
            GetResponse();
        }

        private static void GetResponse()
        {
            var input = Console.ReadKey().Key;
            Console.WriteLine();
            switch (input)
            {
                case ConsoleKey.D1:
                    NewTaskService.Create();
                    Console.Clear();
                    NewTasks.ShowAll();
                    break;
                case ConsoleKey.D7:
                    NewTaskService.ChangeStatus();
                    Console.Clear();
                    NewTasks.ShowAll();
                    break;
                case ConsoleKey.D8:
                    NotaDisplay.Add();
                    Console.Clear();
                    NewTasks.ShowAll();
                    break;
                case ConsoleKey.D9:
                    NewTaskService.Remove();
                    Console.Clear();
                    NewTasks.ShowAll();
                    break;
                case ConsoleKey.D0:
                    Console.Clear();
                    MainMenuService.Show();
                    break;
                default:
                    Console.Clear();
                    NewTasks.ShowAll();
                    break;
            }
        }
    }
}
