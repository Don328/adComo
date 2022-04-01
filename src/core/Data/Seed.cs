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

            var opus2 = new Opus
            {
                OpusId = 2,
                Title = "Task 2"
            };

            var opus3 = new Opus
            {
                OpusId = 3,
                Title = "Task 3"
            };

            var opus4 = new Opus
            {
                OpusId = 4,
                Title = "Task 4"
            };            
            
            var opus5 = new Opus
            {
                OpusId = 5,
                Title = "Task 5"
            };            
            
            var opus6 = new Opus
            {
                OpusId = 6,
                Title = "Task 6"
            };
                        
            var opus7 = new Opus
            {
                OpusId = 7,
                Title = "Task 7"
            };

            var opus8 = new Opus
            {
                OpusId = 8,
                Title = "Task 8"
            };            
            
            var opus9 = new Opus
            {
                OpusId = 9,
                Title = "Task 9"
            };            
            
            var opus10 = new Opus
            {
                OpusId = 10,
                Title = "Task 10"
            };

            opera.Add(opus);
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
    }
}
