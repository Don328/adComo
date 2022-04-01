using adComo.Data;
using adComo.Enums;
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
        private List<Opus> novus = new List<Opus>();
        private List<Opus> accedant = new List<Opus>();
        private List<Opus> pendente = new List<Opus>();
        private List<Opus> completum = new List<Opus>();

        internal State()
        {
            var seed = new Seed();
            opera = seed.SeedOpera();
            SortOpera();
        }

        public List<Opus> Novus { get { return novus; } }
        public List<Opus> Accedant { get { return accedant; } }
        public List<Opus> Pendente { get { return pendente; } }
        public List<Opus> Completum { get { return completum; } }

        private void SortOpera()
        {
            foreach (var opus in opera)
            {
                switch(opus.Status)
                {
                    case OpusStatus.New:
                        Novus.Add(opus);
                        break;
                    case OpusStatus.Active:
                        Accedant.Add(opus);
                        break;
                    case OpusStatus.Pending:
                        Pendente.Add(opus);
                        break;
                    case OpusStatus.Completed:
                        Completum.Add(opus);
                        break;
                    default:
                        Novus.Add(opus);
                        break;
                }
            }
        }
    }
}
