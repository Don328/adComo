﻿using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.ChangeStatus;
using adComo.Enums;
using adComo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.Services
{
    internal static class NewTaskService
    {
        internal static void ChangeStatus()
        {
            Opus opusToChange = ChangeNew.PromptForOpusId();
            var newStatus = ChangeNew.PromptForNewStatus();

            switch (newStatus)
            {
                case ConsoleKey.D1:
                    opusToChange.Status = OpusStatus.Active;
                    Program.State.Accedant.Add(opusToChange);
                    Program.State.Novus.Remove(opusToChange);
                    break;
                case ConsoleKey.D2:
                    opusToChange.Status = OpusStatus.Pending;
                    Program.State.Pendente.Add(opusToChange);
                    Program.State.Novus.Remove(opusToChange);
                    break;
                case ConsoleKey.D0:
                    NewTasks.Show();
                    break;
            }
        }
}
