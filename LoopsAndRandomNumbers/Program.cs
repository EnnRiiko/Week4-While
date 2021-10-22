using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajalt sisestada PIN-kood;
            //Programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //Kui sisestatud PIN-kood on 1234, siis kosnool kuvab "Tere tulemast!";
            //Kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti.";
            //Kasutajal on kolm katset. i < 3

            int i = 0;
            
            while (i < 3) //while-loop
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++; //i = i + 1 sama mis i++
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }
       
            }
           
            Console.WriteLine("Kena päeva!");
        }
    }
}
