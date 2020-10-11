using System;

namespace GuesTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                int skaicius = new Random().Next(0, 100);
                int zaidejas = 0;
                int spejimai = 0;
                while (zaidejas != skaicius)
                {
                    Console.Write("Iveskite spejama skaiciu: ");
                    zaidejas = Convert.ToInt32(Console.ReadLine());
                    spejimai++;
                    if (zaidejas > skaicius)
                    {

                        Console.WriteLine("Jusu skaicius didesnis uz kompiuterio, iveskite mazesni");


                    }
                    else if (zaidejas < skaicius)
                    {
                        Console.WriteLine("Jusu skaicius mazesnis uz kompiuterio, iveskite didesni");

                    }
                    else
                    {
                        Console.WriteLine($"Laimejote! Jusu skaicius: {zaidejas} Kompiuterio skaicius: {skaicius} Jus spejote {spejimai} kartus");
                    }
                }

                Console.WriteLine("Ar norite zaisti dar karta? y / n");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}
