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
    }
}
