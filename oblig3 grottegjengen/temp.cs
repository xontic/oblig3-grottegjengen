using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblig3_grottegjengen
{

    //implementere lovlig PosisjonX-verdi skal være en verdi mellom -180 og + 179, lovlig PosisjonY skal være en verdi mellom -90 og +90.
    //ha et datamedlem til: temperatur(i Kelvin)
    //ha en standardkonstruktør som setter objektets posisjon til(0,0), id til 0, og temperatur til 0.
    //ha en «ett arguments»-konstruktør som tar inn id-verdi som argument.Posisjon skal settes til(0,0) og temperatur skal settes til 0.
    //omdefinere ToString funksjon ved å returnere en streng på følgende format: c-(a, b)
    //der a er PosisjonX-verdi, b er PosisjonY-verdi, og c er Id-verdi.
    //implementere metoden Maal() slik at den lagrer et tilfeldig flyttall mellom 0,0 og 1273,1 i datamedlemmet temperatur.
    //Implementere get-property for datamedlemmet temperatur.

    internal class Tempraturmaaler : ISensor

    {
        private double temperatur; 
        private static readonly Random random = new Random();
        public double PosisjonX { 
            
            get 
            {
                return posisjonX;
            }
            set 
            {
                if (value >= -180 && value <= 179)
                    posisjonX = value;

                // else ?

            } 
        } //  PosisjonX skal være en verdi mellom -180 og +179

        public double PosisjonY {
            get 
            {
                return posisjonY; // hvorfor er det feil her 
            }
            set 
            {
                if (value >= -90 && value <= 90)
                    posisjonY = value;
            } 
        
        
        } //  PosisjonY skal være en verdi mellom -90 og +90
        public int Id { get; set; } //  Id skal være en verdi mellom 0 og 999

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
            Maal();
        }

        public Tempraturmaaler(int id)
        {
            PosisjonX = 0;
            PosisjonY = 0;
            Id = id;
            Maal();
        }

        public void Maal()
        {
            temperatur = random.NextDouble() * 1273.1;
            Console.WriteLine($"Målt Tempratur: {Temperatur}");
        }

        public override string ToString()
        {
            return $"Tempraturmaaler: {Id} - Posisjon: ({PosisjonX}, {PosisjonY}) - Tempratur: {Temperatur}";
        }


    }
}

