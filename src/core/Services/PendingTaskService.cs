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
    internal class PendingTaskService
    {
        internal static void ChangeStatus()
        {
            ChangePending.ShowPrompt();
            ChangePending.PromptForOpusId();
            var idString = GetOpusIdString();
            var opus = GetOpusFromIdString(idString);

            if (opus.OpusId == 0)
            {
                ChangePending.OpusIdNotFound();
                ChangeStatus();
            }

            ChangePending.ConfirmStatusChange();
            var newStatus = Console.ReadKey().Key;
            Console.WriteLine();

            switch (newStatus)
            {
                case ConsoleKey.D1:
                    opus.Status = OpusStatus.Active;
                    Program.State.Accedant.Add(opus);
                    Program.State.Pendente.Remove(opus);
                    break;
                case ConsoleKey.D0:
                    break;
            }
        }

        internal static void Remove()
        {
            RemoveTask.RemovePendingTask();
            ChangePending.PromptForOpusId();
            var idString = GetOpusIdString();
            var opus = GetOpusFromIdString(idString);
            ConfirmDelete(opus);
        }

        private static string GetOpusIdString()
        {
            var IdToChange = Console.ReadLine();
            if (IdToChange == "0" || IdToChange == null)
            {
                PendingTasks.ShowAll();
            }

            return IdToChange ?? string.Empty;
        }

        private static Opus GetOpusFromIdString(string id)
        {
            var opus = (from o
                        in Program.State.Pendente
                        where o.OpusId.ToString() == id
                        select o)
                        .FirstOrDefault();

            if (opus == null)
            {
                ChangePending.OpusIdNotFound();
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
            PendingTasks.ShowOne(opus);
            RemoveTask.RequestConfirmation();
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    Program.State.Pendente.Remove(opus);
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
