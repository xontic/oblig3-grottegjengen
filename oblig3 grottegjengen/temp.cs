using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oblig3_grottegjengen
{

    internal class Tempraturmaaler : ISensor


    {
        private double temperatur; // anta det alltid er i kelvin
        private static readonly Random random = new Random();

        private double posisjonX; 
        private double posisjonY; 

        public double PosisjonX { 
            
            get 
            {
                return posisjonX;
            }
            set 
            {
                if (value >= -180 && value <= 179)
                    posisjonX = value;

            } 
        } 

        public double PosisjonY {
            get 
            {
                return posisjonY; 
            }
            set 
            {
                if (value >= -90 && value <= 90)
                    posisjonY = value;
            } 
        
        
        } 
        public int Id { get; set; } 

        public double Temperatur
        {
            get { return temperatur; } //  Temperatur skal være en verdi mellom 0,0 og 1273,1
            private set { temperatur = value; } 
        }

        public Tempraturmaaler()
        {
            PosisjonX = 0;
            PosisjonY = 0;
            Id = 0;
            temperatur = 0;
        }

        public Tempraturmaaler(int id)
        {
            PosisjonX = 0;
            PosisjonY = 0;
            Id = id;
            temperatur = 0;
        }

        public void Maal()
        {
            temperatur = random.NextDouble() * 1273.1;
            Console.WriteLine($"Målt Tempratur: {Temperatur:f1}");
        }

        public override string ToString()
        {
            return $"Temperaturmaaler: {Id:D2} - Posisjon: ({PosisjonX}, {PosisjonY} Målt Tempratur: {Temperatur:f1})"; // valgte å skive ToString som dette issteden for c-(a,b) for å gjøre det mer oversiktlig for hva type sensor det er. 
        }


    }
}

