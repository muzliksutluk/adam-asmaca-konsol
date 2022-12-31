using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("Adam Asmaca Oyununa Hoşgelmediniz...");
            Console.WriteLine("____________________________________");
            string[] listwords = new string[15
                ];
            listwords[0] = "soğan";
            listwords[1] = "patates";
            listwords[2] = "lahmacun";
            listwords[3] = "kalem";
            listwords[4] = "yuruyen ucak";
            listwords[5] = "konu anlatımlı test kitabı";
            listwords[6] = "matematik";
            listwords[7] = "bülent";
            listwords[8] = "mükemmeliyetcilik";
            listwords[9] = "tavuk pilav";
            listwords[10] = "kedi";
            listwords[11] = "vatikan";
            listwords[12] = "kulaklık";
            listwords[13] = "c sharp";
            listwords[14] = "get up stand up dont give up to fight";
            Random randGen = new Random();
            var idx = randGen.Next(0, 14);
            string mysteryWord = listwords[idx];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Tahmini harfi giriniz : ");

            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';

            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
            }
        }
    }
}