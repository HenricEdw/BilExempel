using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nu måste vi använda konstruktorn för att sätta ett värde på maxhastighet
            //Alla andra instansvariabler får korrekta "default"-värden 
            Bil bil = new Bil(220);
            bil.Colour = "Svart";
            bil.Drive(180);

            Console.WriteLine($"Vi kör nu i {bil.Speed}km/h");
            //Går inte för maxspeed är just nu 220
            bil.Drive(250);
            Console.WriteLine($"Vi försöker gasa över maxhastighet, men kör nu i {bil.Speed}km/h");

            bil.TrimCar(260);
            //Nu kan vi komma upp i 250, för maxspeed sattes till 260 via Trim-metoden!
            bil.Drive(250);
            Console.WriteLine($"Nu är bilen trimmad så vi kan köra i {bil.Speed}km/h");

            Console.ReadLine();
        }
    }
}
