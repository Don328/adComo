using adComo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.Factories
{
    internal class OpusFactory
    {
        internal static Opus CreateOpus(string title)
        {
            var opus = new Opus
            {
                Title = title
            };

            return opus;
        }
    }
}
