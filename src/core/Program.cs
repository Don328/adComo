using adComo.ConsoleDisplay;
using adComo.Data;
using adComo.Enums;
using adComo.Factories;
using adComo.Models;

namespace adComo
{
    class Program
    {
        private static State state = new State();
        internal static State State { get { return state; } }

        static async Task Main(string[] args)
        {
            await Task.Delay(1000);
            state = new State();
            Menu.MainMenu();
        }

        //public static void SelectDisplay()
        //{
        //    Console.WriteLine(
        //        "Select Display: [1]New " +
        //        "[2]Active [3]Pending " +
        //        "[4]Completed " +
        //        "[9]All [0]Exit");
        //    var key = Console.ReadKey().Key;
        //    state.SelectMenu(key);
        //    Console.Clear();
        //    switch(state.SelectedMenu)
        //    {
        //        case ConsoleKey.D1:
        //            NewTasks.Show();
        //            SelectDisplay();
        //            break;
        //        case ConsoleKey.D2:
        //            ActiveTasks.Show();
        //            SelectDisplay();
        //            break;
        //        case ConsoleKey.D3:
        //            PendingTasks.Show();
        //            SelectDisplay();
        //            break;
        //        case ConsoleKey.D4:
        //            CompletedTasks.Show();
        //            SelectDisplay();
        //            break;
        //        case ConsoleKey.D9:
        //            NewTasks.Show();
        //            ActiveTasks.Show();
        //            PendingTasks.Show();
        //            CompletedTasks.Show();
        //            SelectDisplay();
        //            break;
        //        case ConsoleKey.D0:
        //            break;
        //        default:
        //            SelectDisplay();
        //            break;
        //    }
        //}
    }
}