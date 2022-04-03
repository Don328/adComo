using adComo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.Factories
{
    internal static class NotaFactory
    {
        internal static Nota CreateNota(
            string title,
            string text,
            int opusId)
        {
            var nota = new Nota
            {
                Title = title,
                Text = text,
                OpusId = opusId,
            };

            return nota;
        }
    }
}
