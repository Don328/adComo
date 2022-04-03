using adComo.Data;
using adComo.Enums;
using adComo.Factories;
using adComo.Models;

namespace adComo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(1000);
            var state = new State();
            SelectDisplay(state);
        }

        private static void SelectDisplay(State state)
        {
            Console.WriteLine(
                "Select Display: [1]New " +
                "[2]Active [3]Pending " +
                "[4]Completed " +
                "[7]Change Status" +
                "[8]Add Note" +
                "[9]All [0]Exit");
            var key = Console.ReadKey().Key;
            Console.Clear();
            switch(key)
            {
                case ConsoleKey.D1:
                    DisplayNewTasks(state);
                    
                    Console.WriteLine("[7]Change Status");
                    Console.WriteLine("[8]Add Note");
                    var input = Console.ReadKey().Key;
                    Console.WriteLine();
                    switch(input)
                    {
                        case ConsoleKey.D7:
                            Console.WriteLine("New tasks can be changed to active or pending.");
                            Console.WriteLine("Enter Task Id:");
                            var IdToChange = Console.ReadLine();
                            Console.WriteLine("Select new Status: [1]Active [2]Pending");
                            var newStatus = Console.ReadKey().Key;
                            Console.WriteLine();
                            var opusToChange = (from o in state.Novus
                                                where o.OpusId.ToString() == IdToChange
                                                select o).FirstOrDefault();

                            if (opusToChange != null)
                            {
                                state.Novus.Remove(opusToChange);
                                
                                if (newStatus == ConsoleKey.D1)
                                {
                                    opusToChange.Status = OpusStatus.Active;
                                    state.Accedant.Add(opusToChange);
                                }

                                if (newStatus == ConsoleKey.D2)
                                {
                                    opusToChange.Status = OpusStatus.Pending;
                                    state.Pendente.Add(opusToChange);
                                }
                            }
                            break;
                        case ConsoleKey.D8:
                            Console.WriteLine("Enter Task Id:");
                            var index = Console.ReadLine();
                            var opusToAnnotate = (from o in state.Novus
                                        where o.OpusId.ToString() == index
                                        select o).FirstOrDefault();
                            if (opusToAnnotate != null)
                            {
                                Console.WriteLine("Enter a Title:");
                                var title = Console.ReadLine()?? String.Empty;

                                Console.WriteLine("Enter the text of the note");
                                var text = Console.ReadLine()?? string.Empty;
                                
                                var nota = NotaFactory.CreateNota(title, text, opusToAnnotate.OpusId);
                                state.AddNota(nota, opusToAnnotate.Status);
                            }
                            break;
                    }
                    SelectDisplay(state);
                    break;
                case ConsoleKey.D2:
                    DisplayActiveTasks(state);
                    SelectDisplay(state);
                    break;
                case ConsoleKey.D3:
                    DisplayPendingTasks(state);
                    SelectDisplay(state);
                    break;
                case ConsoleKey.D4:
                    DisplayCompletedTasks(state);
                    SelectDisplay(state);
                    break;

                case ConsoleKey.D8:

                    break;
                case ConsoleKey.D9:
                    DisplayNewTasks(state);
                    DisplayActiveTasks(state);
                    DisplayPendingTasks(state);
                    DisplayCompletedTasks(state);
                    SelectDisplay(state);
                    break;
                case ConsoleKey.D0:
                    break;
                default:
                    SelectDisplay(state);
                    break;
            }
        }

        private static void DisplayNewTasks(State state)
        {
            Console.WriteLine();
            Console.WriteLine("New Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in state.Novus)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine("----------------");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
                Console.WriteLine("Notes:");
                Console.WriteLine("--------");
                if (opus.Notas.Any())
                {
                    foreach (var nota in opus.Notas)
                    {
                        DisplayNota(nota);
                    }
                }
                else
                {
                    Console.WriteLine("*None*");
                }
                Console.WriteLine();
            }
        }

        private static void DisplayActiveTasks(State state)
        {
            Console.WriteLine();
            Console.WriteLine("Active Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in state.Accedant)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine("----------------");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
                Console.WriteLine("Notes:");
                Console.WriteLine("--------");
                if (opus.Notas.Any())
                {
                    foreach (var nota in opus.Notas)
                    {
                        DisplayNota(nota);
                    }
                }
                else
                {
                    Console.WriteLine("*None*");
                }
                Console.WriteLine();
            }
        }

        private static void DisplayPendingTasks(State state)
        {
            Console.WriteLine();
            Console.WriteLine("Pending Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in state.Pendente)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine("----------------");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
                Console.WriteLine("Notes:");
                Console.WriteLine("--------");
                if (opus.Notas.Any())
                {
                    foreach (var nota in opus.Notas)
                    {
                        DisplayNota(nota);
                    }
                }
                else
                {
                    Console.WriteLine("*None*");
                }
                Console.WriteLine();
            }
        }

        private static void DisplayCompletedTasks(State state)
        {
            Console.WriteLine();
            Console.WriteLine("Completed Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in state.Completum)
            {
                Console.WriteLine($"Title: {opus.Title}");
                Console.WriteLine("----------------");
                Console.WriteLine($"Id: {opus.OpusId}");
                Console.WriteLine($"Status: {opus.Status}");
                Console.WriteLine();
                Console.WriteLine("Notes:");
                Console.WriteLine("--------");
                if (opus.Notas.Any())
                {
                    foreach (var nota in opus.Notas)
                    {
                        DisplayNota(nota);
                    }
                }
                else
                {
                    Console.WriteLine("*None*");
                }
                Console.WriteLine();
            }
        }

        private static void DisplayNota(Nota nota)
        {
            Console.WriteLine($"OpusId: {nota.OpusId}");
            Console.WriteLine($"Title: {nota.Title}");
            Console.WriteLine($"NotaId: {nota.NotaId}");
            Console.WriteLine($"Text: {nota.Text}");
            Console.WriteLine("--------");
            Console.WriteLine();
        }
    }
}