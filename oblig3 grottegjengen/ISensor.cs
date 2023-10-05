using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblig3_grottegjengen
{
    interface ISensor
    {
      
        
            double PosisjonX
            {
                get;
                set;
            }
            
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
