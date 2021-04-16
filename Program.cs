using System;

namespace CambioPorta
{
    class Program
    {
        static void Main(string[] args)
        {
            int victory = 0;
            int lose = 0;
            for (int i = 0; i < 1000; i++)
            {
                short choosedDoor = ChoosingDoor.ChoosedDoor();
                short winningDoor = WinnderDoor.WinnDoor();
                if (choosedDoor == winningDoor)
                {
                    victory++;
                    //Console.WriteLine("È stata scelta la porta giusta"); //TODO cancellare questo writeline di debug
                }
                else
                {
                    lose++;
                    //Console.WriteLine("È stata scelta la porta sbagliata"); //TODO cancellare questo writeline di debug
                }
            }
            Console.WriteLine($"Il numero di vittorie è: {victory}");
            Console.WriteLine($"La percentuale di vittoria dopo 1000 turni è: {(victory*100)/1000}%"); 
        }
    }
}
