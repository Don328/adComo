using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.ChangeStatus;
using adComo.ConsoleDisplay.DeleteDisplay;
using adComo.ConsolePrompts;
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

            ChangeActive.NewStatusPromptMessage();
            ActiveTaskPrompt.NewStatus(opus);
        }

        internal static void Remove()
        {
            RemoveTask.RemoveActiveTask();
            ChangeActive.PromptForOpusId();
            var idString = ActiveTaskPrompt.GetOpusIdString();
            var opus = GetOpusFromIdString(idString);
            ActiveTaskPrompt.ConfirmDelete(opus);
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
    }
}
