using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblig3_grottegjengen
{

        //        Lag et testprogram kildekodefil «CUISensorer.cs» som:
        //• oppretter en liste som kan inneholde 10 sensorer(ISensor). 
        //• oppretter ti objekter(og legger disse inn i listen) : første fem objekter i listen skal være
        //temperaturmålere, siste fem skal være trykkmålere.Id-numre skal gå fra 1 til 10. 
        //• oppdaterer posisjoner slik at temperaturmålere har posisjoner (1,1), (1,2), (1,3), (1,4) 
        //og(1,5) og trykkmålere har posisjoner(1,1), (3,1), (5,1), (7,1) og(9,1). (Du skal bruke
        //to løkker til å oppnå dette.)
        //• utføre en måling for hver sensor
        //• skrive ut id nummer og resultat av en måling for hver sensor
        //• skriv ut returverdien av ToString for hver sensor

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
                foreach (var s in sensor) // for å legge til en verdi på sensoren i lista. må endre slik at det er fra enten temp eller trykk siden de har forsjellige intervaller 
                {
                     s.Maal(); // hvilken maal fra hvor trykk eller temp hvem vet ?
                }
                foreach (var s in sensor)
                {
                    Console.WriteLine($"{s.ToString()}");
                }

       


        }

    }


    }

