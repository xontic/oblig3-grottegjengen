using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblig3_grottegjengen
{
        internal class Trykkmaaler : ISensor

        {
            private double trykk;
            private static readonly Random random = new Random();
            public double PosisjonX { get; set; }
            public double PosisjonY { get; set; }
            public int Id { get; set; }

            public double Trykk
            {
                get { return trykk; }
                private set { trykk = value; }
            }

            public Trykkmaaler()
            {
                PosisjonX = 0;
                PosisjonY = 0;
                Id = 0;
                Trykk = 2;
            }

            public Trykkmaaler(int id)
            {
                PosisjonX = 0;
                PosisjonY = 0;
                Id = id;
                Trykk = 2;
            }

            public void Maal()
            {
                trykk = 0.5 + (random.NextDouble() * 2); // Generates a random double pablo between 0.5 and 2.5
                Console.WriteLine($"Målt trykk: {trykk}");
            }

            public override string ToString()
            {
                return $"Trykkmaaler: {Id} - Posisjon: ({PosisjonX}, {PosisjonY}) - Trykk: {Trykk}";
            }


        }
    
}
