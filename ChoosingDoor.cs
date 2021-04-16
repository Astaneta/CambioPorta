using System;

namespace CambioPorta
{

    //Questa classe genera una scelta casuale di una delle tre porte, simulando la scelta di un utente;
    public abstract class ChoosingDoor 
    {
        public static short ChoosedDoor()
        {
            Random random = new Random();
            short choosed = Convert.ToInt16(random.Next(1, 4));
            //Console.WriteLine($"La porta scelta è la porta numero: {choosed}"); //TODO cancellare questo writeline di debug
            return choosed;
        }
    }   
}