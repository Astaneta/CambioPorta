using System;

namespace CambioPorta
{
    public abstract class ChoosingDoor 
    {
        // This method just return a number between 1 and 3, simulating the choose of a door
        public static short ChoosedDoor()
        {
            Random random = new Random();
            short choosed = Convert.ToInt16(random.Next(1, 4));
            //Console.WriteLine($"La porta scelta è la porta numero: {choosed}"); //TODO cancellare questo writeline di debug
            return choosed;
        }
    }   
}