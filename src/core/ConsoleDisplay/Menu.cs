using adComo.Enums;
using adComo.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay
{
    internal static class Menu
    {
        public static void MainMenu()
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
                    NewTasks.Show();
                    MainMenu();
                    break;
                case ConsoleKey.D2:
                    ActiveTasks.Show();
                    MainMenu();
                    break;
                case ConsoleKey.D3:
                    PendingTasks.Show();
                    MainMenu();
                    break;
                case ConsoleKey.D4:
                    CompletedTasks.Show();
                    MainMenu();
                    break;
                case ConsoleKey.D9:
                    NewTasks.Show();
                    ActiveTasks.Show();
                    PendingTasks.Show();
                    CompletedTasks.Show();
                    MainMenu();
                    break;
                case ConsoleKey.D0:
                    break;
                default:
                    MainMenu();
                    break;
            }
        }
        
        public static void NewTasksMenu()
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
                    Menu.MainMenu();
                    break;
                default:
                    Console.Clear();
                    NewTasks.Show();
                    break;
            }
        }
    }
}
