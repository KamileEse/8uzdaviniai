using System;

namespace Task1
{
    partial class MainClass
    {
        //1. Programa turi paprašyti varototojo suvesti savo amžių
        //2. Jeigu mažiau nei 18, išspausdinti, kad vartotojas dar negali vairuoti ar pirkti alkoholio
        //3. Jeigu daugiau nei 18 bet mažiau nei 20, kad gali vairuoti, bet negali pirkti alko.. 
        //4. Jeigu daugiau nei 20, kad gali ir vairuoti ir pirkti alko..

        public static void Main(string[] args)
        {
            AgeChecker age = new AgeChecker();
            int amzius = age.Nuskaitymas();
            Possibilities galimybe = age.ageEvaluate(amzius);
            IsvestiRezultata(galimybe);
            Console.ReadLine();
        }

        public static void IsvestiRezultata(Possibilities galimybe)
        {
            switch (galimybe)
            {
                case Possibilities.nieko:
                    Console.WriteLine("Nieko negalima");
                    break;
                case Possibilities.vairuoti:
                    Console.WriteLine("Vairuoti gali, pirkti negali");
                    break;
                case Possibilities.vairuotiGerti:
                    Console.WriteLine("Daryk ka nori");
                    break;
            }
        }
    }
}
