using System;

namespace CambioPorta
{
    class Program
    {
        static void Main(string[] args)
        {
            int victory = 0;
            int lose = 0;
            int turns = 100;
            for (int i = 0; i < turns; i++)
            {
                short choosedDoor = ChoosingDoor.ChoosedDoor();
                short winningDoor = WinneerDoor.WinnDoor();
                ChangeDoor.changingDoor(ref choosedDoor, winningDoor);
                if (choosedDoor == winningDoor)
                {
                    victory++;
                    Console.WriteLine("Hai vinto");
                    Console.WriteLine();
                }
                else
                {
                    lose++;
                    Console.WriteLine("Hai perso");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Il numero di vittorie è: {victory}");
            Console.WriteLine($"La percentuale di vittoria dopo {turns} turni è: {(victory*100)/turns}%"); 

            
        }
    }
}
