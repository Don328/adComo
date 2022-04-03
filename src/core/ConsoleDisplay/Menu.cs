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
            Console.WriteLine("[0]Menu");

            var input = Console.ReadKey().Key;
            Console.WriteLine();
            switch (input)
            {
                case ConsoleKey.D7:
                    Console.WriteLine("New tasks can be changed to active or pending.");
                    Console.WriteLine("Enter Task Id:");
                    var IdToChange = Console.ReadLine();
                    Console.WriteLine("Select new Status: [1]Active [2]Pending");
                    var newStatus = Console.ReadKey().Key;
                    Console.WriteLine();
                    var opusToChange = (from o in Program.State.Novus
                                        where o.OpusId.ToString() == IdToChange
                                        select o).FirstOrDefault();

                    if (opusToChange != null)
                    {
                        Program.State.Novus.Remove(opusToChange);

                        if (newStatus == ConsoleKey.D1)
                        {
                            opusToChange.Status = OpusStatus.Active;
                            Program.State.Accedant.Add(opusToChange);
                        }

                        if (newStatus == ConsoleKey.D2)
                        {
                            opusToChange.Status = OpusStatus.Pending;
                            Program.State.Pendente.Add(opusToChange);
                        }
                    }
                    break;
                case ConsoleKey.D8:
                    Console.WriteLine("Enter Task Id:");
                    var index = Console.ReadLine();
                    var opusToAnnotate = (from o in Program.State.Novus
                                          where o.OpusId.ToString() == index
                                          select o).FirstOrDefault();
                    if (opusToAnnotate != null)
                    {
                        Console.WriteLine("Enter a Title:");
                        var title = Console.ReadLine() ?? String.Empty;

                        Console.WriteLine("Enter the text of the note");
                        var text = Console.ReadLine() ?? string.Empty;

                        var nota = NotaFactory.CreateNota(title, text, opusToAnnotate.OpusId);
                        Program.State.AddNota(nota, opusToAnnotate.Status);
                    }
                    break;
                case ConsoleKey.D0:
                    Console.Clear();
                    Menu.MainMenu();
                    break;
            }
        }
    }
}
