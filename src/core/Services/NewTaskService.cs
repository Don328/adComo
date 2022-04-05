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
            ChangeNew.PromptForOpusId();
            var idString = GetOpusIdString();
            var opus = GetOpusFromIdString(idString);

            if (opus.OpusId == 0)
            {
                ChangeNew.OpusIdNotFound();
                ChangeStatus();
            }

            ChangeNew.PromptForNewStatus();
            var newStatus = Console.ReadKey().Key;
            Console.WriteLine();
            
            switch (newStatus)
            {
                case ConsoleKey.D1:
                    opus.Status = OpusStatus.Active;
                    Program.State.Accedant.Add(opus);
                    Program.State.Novus.Remove(opus);
                    break;
                case ConsoleKey.D2:
                    opus.Status = OpusStatus.Pending;
                    Program.State.Pendente.Add(opus);
                    Program.State.Novus.Remove(opus);
                    break;
                case ConsoleKey.D0:
                    break;
            }
        }

        internal static Opus GetOpusFromIdString(string id)
        {
            var opus = (from o
                        in Program.State.Novus
                        where o.OpusId.ToString() == id
                        select o)
                        .FirstOrDefault();

            if (opus == null)
            {
                ChangeNew.OpusIdNotFound();
                return new Opus { OpusId = 0 };
            }
            else
            {
                return opus;
            }
        }

        internal static void Remove()
        {
            RemoveTask.RemoveNewTask();
            ChangeNew.PromptForOpusId();
            var idString = GetOpusIdString();
            var opus = GetOpusFromIdString(idString);
            ConfirmDelete(opus);
        }

        private static string GetOpusIdString()
        {
            var IdToChange = Console.ReadLine();
            if (IdToChange == "0" || IdToChange == null)
            {
                NewTasks.ShowAll();
            }
         
            return IdToChange ?? string.Empty;
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
