using System;

namespace Task4
{
    class MainClass
    {
        //1. Programa iš vartotojo turi priimti neribotą skaičių string'ų (žodžių)
        //2. Jeigu vartotojas suveda pasikartojantį žodį, programa išspausdina,
        // kad tai yra dublikatas, kitu atveju, išspausdina kad žodis išsaugotas
        //3. Programa turi turėti klasę, pvz (WordsDatabase.cs) kuri saugotų vartotojo suvestus žodžius
        //4. Objektas kuriame saugomi žodžiai, neturėtų būti pasiekiamas iš kitų klasių tiesiogai

        public static void Main(string[] args)
        {
            WordsDatabase duomenys = new WordsDatabase();

            Console.ReadLine();
        }
    }
}
