using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblig3_grottegjengen
{
        public class CUIsensor
        {
          public static void RunSensorProgram()  
          {
                List<ISensor> sensor = new List<ISensor>(10);

                for (int i = 0; i < 5; i++)
                {   
                    sensor.Add(new Tempraturmaaler(i+1));
                    sensor[i].PosisjonX = 1;
                    sensor[i].PosisjonY = i + 1;
                
                }

                for (int i = 5; i < 10; i++)
                {
                    sensor.Add(new Trykkmaaler(i + 1));
                    sensor[i].PosisjonX = 2 * i - 9;
                    sensor[i].PosisjonY = 1;
                }

                //foreach (var s in sensor) // dette er en foreach som går gjennom alle sensorene og måler dem.
                //{
                //     s.Maal(); 
                //}
            foreach (var s in sensor) 
            {
                if (s is Tempraturmaaler) // dette er en if som sjekker om sensoren er en tempraturmaaler eller trykkmaaler og måler dem.
                {

                    Tempraturmaaler temp = s as Tempraturmaaler; 
                    temp.Maal();  
                }
                else if (s is Trykkmaaler) 
                {
                    Trykkmaaler trykk = s as Trykkmaaler;
                    trykk.Maal();  
                }
            }

            foreach (var s in sensor)
                {
                    Console.WriteLine($"{s.ToString()}");
                }

          }

        }
}

