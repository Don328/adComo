using adComo.ConsoleDisplay;
using adComo.ConsoleDisplay.ChangeStatus;
using adComo.ConsoleDisplay.Create;
using adComo.ConsoleDisplay.DeleteDisplay;
using adComo.Enums;
using adComo.Factories;
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
        internal static void Create()
        {
            CreateTask.ShowPrompt();

            var title = CreateTask.PromptForTitle();
            var opus = OpusFactory.CreateOpus(title);
            Program.State.AddOpus(opus);
            NewTasks.ShowAll();
        }

        internal static void ChangeStatus()
        {
            ChangeNew.ShowPrompt();
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
                    break;
            }
        }

        internal static void Remove()
        {
            RemoveTask.ShowPrompt();
            Opus opusToDelete = ChangeNew.PromptForOpusId();
            ConfirmDelete(opusToDelete);
        }

        private static void ConfirmDelete(Opus opus)
        {
            Console.Clear();
            RemoveTask.ShowWarningMessage();
            NewTasks.ShowOne(opus);
            RemoveTask.RequestConfirmation();
            var key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.D1:
                    Program.State.Novus.Remove(opus);
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
