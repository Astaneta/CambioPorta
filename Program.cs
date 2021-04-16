using System;

namespace CambioPorta
{
    class Program
    {
        static void Main(string[] args)
        {
            int victoryWithChange = 0;
            int victoryWithoutChange = 0;
            int turns = 50000;

            // Turni non cambiando porta
            for (int i = 0; i < turns; i++)
            {
                short choosedDoor = ChoosingDoor.ChoosedDoor();
                short winningDoor = WinneerDoor.WinnDoor();
                UnchangeDoor.UnchangingDoor(choosedDoor, winningDoor);
                if (choosedDoor == winningDoor)
                {
                    victoryWithoutChange++;
                }
            }

            // Turni cambiando porta
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
            Console.WriteLine($"Il numero di vittorie non cambiando porta è: {victoryWithoutChange}");
            Console.WriteLine($"La percentuale di vittoria dopo {turns} turni è: {(victoryWithoutChange*100)/turns}%"); 
            Console.WriteLine($"Il numero di vittorie cambiando porta è: {victoryWithChange}");
            Console.WriteLine($"La percentuale di vittoria dopo {turns} turni è: {(victoryWithChange*100)/turns}%"); 
        }
    }
}
