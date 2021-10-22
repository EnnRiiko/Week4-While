using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhulikku numbrit 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata;
            //Siis mängu võidab arvuti.
            //Programm genereerib juhusliku numbri ühe korra.

            Random rnd = new Random();
            int cpuComputer = rnd.Next(1, 11);
            int i = 0;
            

            while (i < 3)
            {
                Console.WriteLine("Sisesta number 1 kuni 10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuComputer == userNumber)
                {
                    Console.WriteLine("Sisestasid õige numbri, oled võitja!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number, {3 - i} katset on jäänud.");

                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
