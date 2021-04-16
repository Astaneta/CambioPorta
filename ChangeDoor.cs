using System;
using System.Collections.Generic;

namespace CambioPorta
{
    public abstract class ChangeDoor
    {
        public static void changingDoor(ref short choosed, short winning)
        {
            short[] allDoor = new short[]{1, 2, 3};
            short toggledDoor = 0;
            Console.WriteLine($"La porta scelta è la n. {choosed}");
            Console.WriteLine($"La porta vincente è la n. {winning}");
            foreach (short item in allDoor)
            {
                if (item != choosed && item != winning)
                {
                    toggledDoor = item;
                    Console.WriteLine($"La porta eliminata è la n. {toggledDoor}");
                    break;
                }
            }
            foreach (short item in allDoor)
            {
                if (item != choosed && item != toggledDoor)
                {
                    choosed = item;
                    Console.WriteLine($"Ora la porta scelta è la n. {choosed}");
                    break;
                }
            }
            
        }
    }
}