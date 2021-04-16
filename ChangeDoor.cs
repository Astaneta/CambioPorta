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