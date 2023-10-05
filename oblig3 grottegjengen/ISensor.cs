using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblig3_grottegjengen
{
    interface ISensor
    {
      
            //  PosisjonX skal være en verdi mellom -180 og +179
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
                set;
            }
            void Maal();
            string ToString();
       
    }
}
