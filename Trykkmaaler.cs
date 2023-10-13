using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUISensor.exe
{
    internal class Trykkmaaler : Isensor
    {
                // Datamedlem
        private static readonly Random random = new Random();
        private double posisjonX;
        private double posisjonY;
        private int id;
        private double trykk;

        public Trykkmaaler() //standardkonstruktør som setter objektets posisjon til (0,0), id til 0, og  temperatur til 0.
        {
            posisjonX = 0;
            posisjonY = 0;
            id = 0;
            trykk = 0;
        }
        public Trykkmaaler(int Id) //Ett argumentskonstruktør som setter objektets posisjon til (0,0) og temperatur til 0.
        {
            posisjonX = 0;
            posisjonY = 0;
            trykk = 0;
            id = Id;
        }


        public double PosisjonX
        {
            get
            {
                return posisjonX;
            }
            set
            {
                if (posisjonX > 179)
                {
                    posisjonX = value;
                }
                else if (posisjonX < -180)
                {
                    posisjonX = -value;
                }
                else { posisjonX = value; }

            }
        }
        public double PosisjonY
        {
            get
            {
                return posisjonY;
            }
            set
            {
                if (posisjonY > 90)
                {
                    posisjonY = value;
                }
                else if (posisjonX < -90)
                {
                    posisjonY = -value;
                }
                else { posisjonY = value; }

            }
        }

        public int Id
        {
            get 
            { 
                return id; 
            }
            set 
            { 
                id = value; 
            } 
        }

        public override string ToString()
        {
            return $"{Id} - ({posisjonX}, {posisjonY})";
        }
        public void Maal()                 //oppretter en metode for mål 
        {
            trykk = 0.5 + (random.NextDouble() * 2); // Generates a random double pablo between 0.5 and 2.5
        }

        public double Trykk
        {
            get
            {
                return trykk;
            }
            set
            {
                trykk = value;
            }
        }
    }
}
