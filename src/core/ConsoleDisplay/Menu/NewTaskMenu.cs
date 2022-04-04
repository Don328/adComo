using adComo.Services;
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
                    MainMenu.Show();
                    break;
                default:
                    Console.Clear();
                    NewTasks.ShowAll();
                    break;
            }
        }
    }
}
