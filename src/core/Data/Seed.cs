using adComo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adComo.Data
{
    internal class Seed
    {
        private readonly bool isDbSeed;

        internal Seed(bool isDbSeed = false)
        {
            this.isDbSeed = isDbSeed;
        }

        internal List<Opus> SeedOpera()
        {
            var opera = new List<Opus>();

            var opus = new Opus
            {
                OpusId = 1,
                Title = "Task 1"
            };

            opera.Add(opus);

            return opera;
        }
    }
}
