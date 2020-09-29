using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExcercise
{
    internal class Bil
    {
        //MaxSpeed ska vi inte kunna ända hipp som happ utanför klassen
        public int MaxSpeed { get; private set; }
        public string Colour { get; set; }
        public int Speed { get; private set; }

        //Vi skapar en konstruktor som TVINGAR den som använder klassen
        //att sätta en maxhastighet. Ingen kan nu använda en instans av
        //klassen Bil utan att ange en maxhastighet
        public Bil(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
            Colour = string.Empty;
            Speed = 0;
        }

        public int Drive(int speed)
        {
            //Om den hastighet vi försöker få upp bilen i övergår
            //högsta tillåtna hastighet, sätter vi hastigheten till 
            //maxhastighet.
            if (speed > MaxSpeed)
            {
                Speed = MaxSpeed;
            }
            else
            {
                Speed = speed;
            }

            return Speed;
        }

        //Här skulle vi kunna skapa en Trim-metod eller liknande om vi vill kunna ändra
        //MaxSpeed på något sätt
        public int TrimCar(int newMaxSpeed)
        {
            if (newMaxSpeed > 0)
            {
                //Vi kommer åt propertyns privata set eftersom vi är inne i klassen
                MaxSpeed = newMaxSpeed;
            }

            return MaxSpeed;
        }
    }
}
