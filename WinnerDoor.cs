using System;

namespace CambioPorta
{
    public abstract class WinnderDoor
    {
        // Il seguente metodo si limita a restituire un numero random da 1 a 3
        public static short WinnDoor()
        {
            Random random = new Random();

            short winner = Convert.ToInt16(random.Next(1, 4));

            //Console.WriteLine("La porta vincente è: {0}", winner); //TODO cancellare questo writeline di debug

            return winner;
        }
    }
}