using System;

namespace CambioPorta

{
    public abstract class WinnderDoor
    {
        public int WinningDoor { get; set; }

        // Il seguente metodo si limita a restituire un numero random da 1 a 3
        public static int WinnDoor()
        {
            Random random = new Random();

            int winner = random.Next(1, 4);

            Console.WriteLine("La porta vincente è: {0}", winner);

            return winner;
        }
    }
}