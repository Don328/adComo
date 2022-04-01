using adComo.Enums;
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
        private int opusCount = 0;
        private int notaCount = 0;

        internal Seed(bool isDbSeed = false)
        {
            this.isDbSeed = isDbSeed;
        }

        internal List<Opus> SeedOpera()
        {
            var opera = new List<Opus>();

            opera.Add(CreateOpus("Task 1"));
            opera.Add(CreateOpus("Task 2"));
            opera.Add(CreateOpus("Task 3"));
            opera.Add(CreateOpus("Task 4"));
            opera.Add(CreateOpus("Task 5"));
            opera.Add(CreateOpus("Task 6"));
            opera.Add(CreateOpus("Task 7"));
            opera.Add(CreateOpus("Task 8"));
            opera.Add(CreateOpus("Task 9"));
            opera.Add(CreateOpus("Task 10"));

            return opera;
        }

        private Opus CreateOpus(string title)
        {
            var id = 0;
            if (!isDbSeed)
            {
                id = opusCount + 1;
            }
            var opus = new Opus
            {
                OpusId = id,
                Title = title,
                Status = OpusStatus.New
            };
            opusCount++;

            return opus;
        }
    }
}
