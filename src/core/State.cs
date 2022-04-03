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
        private ConsoleKey selectedMenu = 0;
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

        public ConsoleKey SelectedMenu { get { return selectedMenu; } }
        public List<Opus> Novus { get { return novus; } }
        public List<Opus> Accedant { get { return accedant; } }
        public List<Opus> Pendente { get { return pendente; } }
        public List<Opus> Completum { get { return completum; } }

        public void SelectMenu(ConsoleKey key)
        {
            selectedMenu = key;
        }

        public void AddNota(Nota nota, OpusStatus status)
        {
            switch (status)
            {
                case OpusStatus.New:
                    var opusNovus = (from o in Novus
                                     where o.OpusId == nota.OpusId
                                     select o).FirstOrDefault();
                    opusNovus?.Notas.Add(nota);
                    break;
                case OpusStatus.Active:
                    var opusAccedant = (from o in Accedant
                                        where o.OpusId == nota.OpusId
                                        select o).FirstOrDefault();
                    opusAccedant?.Notas.Add(nota);
                    break;
                case OpusStatus.Pending:
                    var opusPenente = (from o in Pendente
                                       where o.OpusId == nota.OpusId
                                       select o).FirstOrDefault();
                    opusPenente?.Notas.Add(nota);
                    break;
                case OpusStatus.Completed:
                    var opusCompletum = (from o in Completum
                                         where o.OpusId == nota.OpusId
                                         select o).FirstOrDefault();
                    opusCompletum?.Notas.Add(nota);
                    break;
            }
        }

        private void SortOpera()
        {
            foreach (var opus in opera)
            {
                switch (opus.Status)
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
