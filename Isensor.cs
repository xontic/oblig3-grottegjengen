using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUISensor.exe
{
    internal interface Isensor
    {
        enum Sensortype
        {
            Temperaturmåler,
            Trykkmåler
        }

        double PosisjonX
        {
            get;
            set;
        }
        //  PosisjonY skal være en verdi mellom -90 og +90
        double PosisjonY
        {
            get;
            set;
        }
        int Id
        {
            get;
        }
        void Maal();
        string ToString();
    }
}
