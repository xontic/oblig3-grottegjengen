using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GUISensor.exe 
{
    internal class Temperaturmaaler : Isensor
    {
        // Datamedlem
        private static readonly Random random = new Random();
        private double posisjonX;
        private double posisjonY;
        private int id;
        private double temperatur;  // Kelvin


        public Temperaturmaaler() //standardkonstruktør som setter objektets posisjon til (0,0), id til 0, og  temperatur til 0.
        {
            posisjonX = 0;
            posisjonY = 0;
            id = 0;
            temperatur = 0;
        }
        public Temperaturmaaler(int Id) //Ett argumentskonstruktør som setter objektets posisjon til (0,0) og temperatur til 0.
        {
            posisjonX = 0;
            posisjonY = 0;
            temperatur = 0;
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
            { return id; 

            }
            set
            {
                id = value;
            }
        }

        public override string ToString()
        {
            return $"{Id} - ({posisjonX}, {posisjonY})" ;
        }
        public void Maal()                 //oppretter en metode for mål 
        {
            temperatur = random.NextDouble() * 1273.1; // Generates a random double pablo between 0.5 and 2.5
        }

        public double Temperatur
        {
            get
            {
                return temperatur;
            }
            set
            {
                temperatur = value;
            }
        }

    }
}
