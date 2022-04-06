using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.DeleteDisplay;
using adComo.Enums;
using adComo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsolePrompts
{
    internal static class ActiveTaskPrompt
    {
        internal static void NewStatus(Opus opus)
        {
            var newStatus = Console.ReadKey().Key;
            Console.WriteLine();

            switch (newStatus)
            {
                case ConsoleKey.D1:
                    opus.Status = OpusStatus.Pending;
                    Program.State.Pendente.Add(opus);
                    Program.State.Accedant.Remove(opus);
                    break;
                case ConsoleKey.D2:
                    opus.Status = OpusStatus.Completed;
                    Program.State.Completum.Add(opus);
                    Program.State.Accedant.Remove(opus);
                    break;
                case ConsoleKey.D0:
                    break;
            }
        }

        internal static string GetOpusIdString()
        {
            var IdToChange = Console.ReadLine();
            if (IdToChange == "0" || IdToChange == null)
            {
                ActiveTasks.ShowAll();
            }

            return IdToChange ?? string.Empty;
        }

        internal static void ConfirmDelete(Opus opus)
        {
            Console.Clear();
            RemoveTask.ShowWarningMessage();
            ActiveTasks.ShowOne(opus);
            RemoveTask.RequestConfirmation();
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    Program.State.Accedant.Remove(opus);
                    break;
                case ConsoleKey.D0:
                    break;
                default:
                    ConfirmDelete(opus);
                    break;
            }
        }
    }
}
