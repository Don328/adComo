using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay.Create
{
    internal static class CreateTask
    {
        internal static void ShowPrompt()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("Create New Task");
            Console.WriteLine("----------------");
        }

        internal static string PromptForTitle()
        {

            Console.WriteLine("Enter a title:");
            var title = Console.ReadLine() ?? string.Empty;

            if (title == string.Empty)
            {
                TitleIsEmpty();
            }

            return title;
        }

        private static void TitleIsEmpty()
        {
            Console.WriteLine("Title cannot be empty");
            Console.WriteLine("Press any key to continue. Press [0]Zero to cancel");
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D0:
                    NewTasks.ShowAll();
                    break;
                default:
                    PromptForTitle();
                    break;
            }
        }
    }
}
