using System;

namespace CambioPorta
{
    class Program
    {
        static void Main(string[] args)
        {
            int victoryWithChange = 0;
            int victoryWithoutChange = 0;
            int turns = 100000;

            // Turns without change the selected door
            for (int i = 0; i < turns; i++)
            {
                short choosedDoor = ChoosingDoor.ChoosedDoor();
                short winningDoor = WinneerDoor.WinnDoor();
                if (choosedDoor == winningDoor)
                {
                    victoryWithoutChange++;
                }

            }
            // Turns changing the selected door
            for (int i = 0; i < turns; i++)
            {
                short choosedDoor = ChoosingDoor.ChoosedDoor();
                short winningDoor = WinneerDoor.WinnDoor();
                ChangeDoor.changingDoor(ref choosedDoor, winningDoor);
                if (choosedDoor == winningDoor)
                {
                    victoryWithChange++;
                }
            }
            Console.WriteLine($"The number of victory without changing the door is: {victoryWithoutChange}");
            Console.WriteLine($"The percentual of victory after {turns} turns is: {(victoryWithoutChange*100)/turns}%"); 
            Console.WriteLine($"The number of victory changing the door is: {victoryWithChange}");
            Console.WriteLine($"The percentual of victory after {turns} turns is: {(victoryWithChange*100)/turns}%"); 
        }
    }
}
