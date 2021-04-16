using System;
using System.Collections.Generic;

namespace CambioPorta
{
    public abstract class ChangeDoor
    {
        // Following method check for the unchoosed and not winner door, changing choosed door with the remaining closed door
        public static void changingDoor(ref short choosed, short winning)
        {
            short[] allDoor = new short[]{1, 2, 3};
            short toggledDoor = 0;
            foreach (short item in allDoor)
            {
                if (item != choosed && item != winning)
                {
                    toggledDoor = item;
                    break;
                }
            }
            foreach (short item in allDoor)
            {
                if (item != choosed && item != toggledDoor)
                {
                    choosed = item;
                    break;
                }
            }
            
        }
    }
}