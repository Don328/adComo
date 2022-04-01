using adComo.Data;
using adComo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo
{
    internal class State
    {
        private List<Opus> opera = new List<Opus>();

        internal State()
        {
            var seed = new Seed();
            opera = seed.SeedOpera();
        }

        public List<Opus> Opera { get { return opera; } }
    }
}
