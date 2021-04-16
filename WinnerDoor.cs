using System;

namespace CambioPorta
{
    public abstract class WinneerDoor
    {
        // Following method just return a random number from 1 to 3
        public static short WinnDoor()
        {
            Random random = new Random();

            short winner = Convert.ToInt16(random.Next(1, 4));

            //Console.WriteLine("La porta vincente è: {0}", winner); //TODO cancellare questo writeline di debug

            return winner;
        }
    }
}