using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.ChangeStatus;
using adComo.ConsoleDisplay.DeleteDisplay;
using adComo.Enums;
using adComo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.Services
{
    internal static class ActiveTaskService
    {
        internal static void ChangeStatus()
        {
            ChangeActive.ShowPrompt();
            ChangeActive.PromptForOpusId();
            var idString = GetOpusIdString();
            var opus = GetOpusFromIdString(idString);

            if (opus.OpusId == 0)
            {
                ChangeActive.OpusIdNotFound();
                ChangeStatus();
            }

            ChangeActive.PromptForNewStatus();
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

        internal static void Remove()
        {
            RemoveTask.RemoveActiveTask();
            ChangeActive.PromptForOpusId();
            var idString = GetOpusIdString();
            var opus = GetOpusFromIdString(idString);
            ConfirmDelete(opus);
        }

        private static string GetOpusIdString()
        {
            var IdToChange = Console.ReadLine();
            if (IdToChange == "0" || IdToChange == null)
            {
                ActiveTasks.ShowAll();
            }

            return IdToChange ?? string.Empty;
        }

        private static Opus GetOpusFromIdString(string id)
        {
            var opus = (from o
                        in Program.State.Accedant
                        where o.OpusId.ToString() == id
                        select o)
                        .FirstOrDefault();

            if (opus == null)
            {
                ChangeActive.OpusIdNotFound();
                return new Opus { OpusId = 0 };
            }
            else
            {
                return opus;
            }
        }

        private static void ConfirmDelete(Opus opus)
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
