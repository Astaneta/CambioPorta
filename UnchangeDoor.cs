using System;

namespace CambioPorta
{
    public abstract class UnchangeDoor
    {
        public static void UnchangingDoor(short choosed, short winning)
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
        }
    }
}