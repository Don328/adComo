using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay.Menu
{
    internal class ActiveTaskMenu
    {
        public static void Show()
        {
            Console.WriteLine();

            Console.WriteLine("[7]Change Status");
            Console.WriteLine("[8]Add Note");
            Console.WriteLine("[0]Main Menu");

            var input = Console.ReadKey().Key;
            Console.WriteLine();
            switch (input)
            {
                case ConsoleKey.D7:
                    ActiveTasks.ChangeStatus();
                    Console.Clear();
                    NewTasks.Show();
                    break;
                case ConsoleKey.D8:
                    NotaDisplay.Add();
                    Console.Clear();
                    ActiveTasks.Show();
                    break;
                case ConsoleKey.D0:
                    Console.Clear();
                    MainMenu.Show();
                    break;
                default:
                    Console.Clear();
                    ActiveTasks.Show();
                    break;
            }
        }
    }
}
