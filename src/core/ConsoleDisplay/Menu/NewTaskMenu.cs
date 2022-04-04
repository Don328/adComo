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
            Console.WriteLine("[0]Main Menu");

            var input = Console.ReadKey().Key;
            Console.WriteLine();
            switch (input)
            {
                case ConsoleKey.D1:
                    // NewTasks.Add();
                    Console.Clear();
                    NewTasks.Show();
                    break;
                case ConsoleKey.D7:
                    NewTasks.ChangeStatus();
                    Console.Clear();
                    NewTasks.Show();
                    break;
                case ConsoleKey.D8:
                    NotaDisplay.Add();
                    Console.Clear();
                    NewTasks.Show();
                    break;
                case ConsoleKey.D0:
                    Console.Clear();
                    MainMenu.Show();
                    break;
                default:
                    Console.Clear();
                    NewTasks.Show();
                    break;
            }
        }
    }
}
