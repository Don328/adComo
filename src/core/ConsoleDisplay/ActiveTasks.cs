﻿using adComo.ConsoleDisplay.Menu;
using adComo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay
{
    internal static class ActiveTasks
    {
        internal static void Show()
        {
            Console.WriteLine();
            Console.WriteLine("Active Tasks:");
            Console.WriteLine("--------------------------------");
            foreach (var opus in Program.State.Accedant)
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
                        NotaDisplay.Show(nota);
                    }
                }
                else
                {
                    Console.WriteLine("*None*");
                }
                Console.WriteLine();
            }
                
            ActiveTaskMenu.Show();
        }

        internal static void ChangeStatus()
        {
            Console.WriteLine("Active tasks can be changed or pending or completed.");
            Console.WriteLine("Enter Task Id:");
            var IdToChange = Console.ReadLine();
            var opusToChange = (from o in Program.State.Accedant
                                where o.OpusId.ToString() == IdToChange
                                select o).FirstOrDefault();
            if (opusToChange != null)
            {
                Console.WriteLine("Select new Status: [1]Pending [2]Completed [0]Cancel");
                var newStatus = Console.ReadKey().Key;
                Console.WriteLine();
                Program.State.Accedant.Remove(opusToChange);
                switch(newStatus)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Create a note with a reason for pending");
                        NotaDisplay.Add(opusToChange.OpusId);
                        opusToChange.Status = OpusStatus.Pending;
                        Program.State.Pendente.Add(opusToChange);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Create a note for the completed task:");
                        NotaDisplay.Add(opusToChange.OpusId);
                        opusToChange.Status = OpusStatus.Completed;
                        Program.State.Completum.Add(opusToChange);
                        break;
                    case ConsoleKey.D0:
                        Console.Clear();
                        Show();
                        break;
                }
            }
            else
            {
                Console.Clear();
                Show();
            }
        }
    }
}
