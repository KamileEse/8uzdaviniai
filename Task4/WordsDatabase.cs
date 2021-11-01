using System;
using System.Collections.Generic;

namespace Task4
{
    public class WordsDatabase
    {
        public WordsDatabase()
        {
            Console.WriteLine("Iveskite teksta:");
            string tekstas = Console.ReadLine();

            List<string> tekstai = new List<string>();

            while (!tekstas.Equals(tekstas))
            {
                Console.WriteLine("Zodis issaugotas");
                Console.WriteLine("Iveskite teksta");
                tekstas = Console.ReadLine();

                tekstai.Add(tekstas);
            }

            foreach (string i in tekstai)
            {
                Console.WriteLine("Ivedete dublikata");
            }
        }
    }
}
