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

            var opus1 = CreateOpus("Task 1");
            opus1.Status = OpusStatus.New;

            var opus2 = CreateOpus("Task 2");
            opus2.Status = OpusStatus.Active;
            
            var opus3 = CreateOpus("Task 3");
            opus3.Status = OpusStatus.Active;
            
            var opus4 = CreateOpus("Task 4");
            opus4.Status = OpusStatus.Pending;
            
            var opus5 = CreateOpus("Task 5");
            opus5.Status = OpusStatus.Completed;
            
            var opus6 = CreateOpus("Task 6");
            opus6.Status = OpusStatus.Pending;
            
            var opus7 = CreateOpus("Task 7");
            opus7.Status = OpusStatus.Active;
            
            var opus8 = CreateOpus("Task 8");
            opus8.Status = OpusStatus.New;
            
            var opus9 = CreateOpus("Task 9");
            opus9.Status = OpusStatus.Completed;
            
            var opus10 = CreateOpus("Task 10");
            opus10.Status = OpusStatus.Active;


            opera.Add(opus1);
            opera.Add(opus2);
            opera.Add(opus3);
            opera.Add(opus4);
            opera.Add(opus5);
            opera.Add(opus6);
            opera.Add(opus7);
            opera.Add(opus8);
            opera.Add(opus9);
            opera.Add(opus10);

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
