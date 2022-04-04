using adComo.Factories;
using adComo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.ConsoleDisplay
{
    internal static class NotaDisplay
    {
        public static void Show(Nota nota)
        {
            Console.WriteLine($"OpusId: {nota.OpusId}");
            Console.WriteLine($"Title: {nota.Title}");
            Console.WriteLine($"NotaId: {nota.NotaId}");
            Console.WriteLine($"Text: {nota.Text}");
            Console.WriteLine("--------");
            Console.WriteLine();
        }

        public static void Add(int? id = null)
        {
            var index = string.Empty;
            
            if (id == null)
            { 
                Console.WriteLine("Enter Task Id:");
                index = Console.ReadLine();
            }
            else
            {
                index = id.ToString();
            }

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
        }
    }
}
