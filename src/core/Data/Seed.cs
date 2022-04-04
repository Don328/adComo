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

        internal int OpusCount { get { return opusCount; } }
        internal int NotaCount { get { return notaCount; } }

        internal List<Opus> SeedOpera()
        {
            var opera = new List<Opus>();

            var opus1 = CreateOpus("Task 1");
            opus1.Status = OpusStatus.New;

            var opus2 = CreateOpus("Task 2");
            opus2.Status = OpusStatus.Active;
            var nota1 = CreateNota(
                "Get Started",
                "Let's do this task right away.");
            opus2.Notas.Add(nota1);

            var opus3 = CreateOpus("Task 3");
            opus3.Status = OpusStatus.Active;
            var nota2 = CreateNota(
                "This is a priority",
                "This task needs to be completed soon");
            opus3.Notas.Add(nota2);
            var nota3 = CreateNota(
                "We need to get this done",
                "What is holding this up???");
            opus3.Notas.Add(nota3);
            
            var opus4 = CreateOpus("Task 4");
            opus4.Status = OpusStatus.Pending;
            var nota4 = CreateNota(
                "Waiting on approval",
                "This task is pending approval");
            opus4.Notas.Add(nota4);
            
            
            var opus5 = CreateOpus("Task 5");
            opus5.Status = OpusStatus.Completed;
            var nota5 = CreateNota(
                "Let's do this",
                "This one should be easy");
            opus5.Notas.Add(nota5);
            var nota6 = CreateNota(
                "Completed",
                "That was easy");
            opus5.Notas.Add(nota6);

            var opus6 = CreateOpus("Task 6");
            opus6.Status = OpusStatus.Pending;
            var nota7 = CreateNota(
                "This one can wait",
                "Pending...");
            opus6.Notas.Add(nota7);

            var opus7 = CreateOpus("Task 7");
            opus7.Status = OpusStatus.Active;
            var nota8 = CreateNota(
                "This task should be active",
                "Keep this one going");
            opus7.Notas.Add(nota8);
            var nota9 = CreateNota(
                "Pretty good",
                "Pre-T gooood");
            opus7.Notas.Add(nota9);

            var opus8 = CreateOpus("Task 8");
            opus8.Status = OpusStatus.New;
            
            var opus9 = CreateOpus("Task 9");
            opus9.Status = OpusStatus.Completed;
            var nota10 = CreateNota(
                "Finished",
                "Task completed");
            opus9.Notas.Add(nota10);
            
            var opus10 = CreateOpus("Task 10");
            opus10.Status = OpusStatus.Active;
            var nota11 = CreateNota(
                "Great Task",
                "This task is awesome");
            var nota12 = CreateNota(
                "This is the best Task",
                "If only they could all be like this one");
            opus10.Notas.Add(nota11);
            opus10.Notas.Add(nota12);

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

        private Nota CreateNota(
            string title,
            string text)
        {
            var id = 0;
            if (!isDbSeed)
            {
                id = notaCount + 1;
            }
            var nota = new Nota
            {
                NotaId = id,
                OpusId = opusCount,
                Title = title,
                Text = text
            };
            
            notaCount++;
            return nota;
        }

    }
}
