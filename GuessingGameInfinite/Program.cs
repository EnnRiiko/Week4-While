using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhulikku numbrit 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //Programm genereerib juhusliku numbri ühe korra.

            Random rnd = new Random();
            int cpuComputer = rnd.Next(1, 11);
            bool loopActive = true;
            

            while (loopActive) 
            {
                Console.WriteLine("Sisesta number 1 kuni 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(cpuComputer == userNumber)
                {
                    Console.WriteLine("Sisestasid õige numbri, oled võitja!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale number proovi uuesti.");
                }

            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
