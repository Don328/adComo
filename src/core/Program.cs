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
    }
}