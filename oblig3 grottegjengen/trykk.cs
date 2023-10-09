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
                Console.WriteLine($"Målt trykk: {trykk:f1}");
            }
            
            public override string ToString()
            {
                return $"Trykkmaaler: {Id:D2} - Posisjon: ({PosisjonX}, {PosisjonY}) - Målt trykk: {trykk:f1}"; // valgte å skive ToString som dette issteden for c-(a,b) for å gjøre det mer oversiktlig for hva type sensor det er. 
            }



        }
    
}
