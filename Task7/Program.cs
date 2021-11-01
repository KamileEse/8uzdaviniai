using System;
using System.Collections.Generic;

namespace Task7
{
    class MainClass
    {
        //1. Programa turi pasiūlyti prisijungti arba registruotis
        //2. Jeigu varotojas bando prisijungti reikia patikrinti ar Name ir Password yra teisingi
        //3. Jeigu registruojamas naujas, patikrinti ar Name neegzistuoja ir slaptažodis ilgesnis nei šeši simboliai
        //4. Vartotojai išsaugomi į failą
        //5. Programa turi keletą iš anksto išsaugotų vartotojų

        static void Main(string[] args)
        {
            if (VartotojuDuomenuBaze.PatikrintiDuomenis())
            {
                if (PrasytiPasirinkti())
                {
                    Console.WriteLine("Sveiki prisijunge");
                    Console.ReadLine();
                }
            }
        }

        static bool PrasytiPasirinkti()
        {
            int pasirinkimas = 0;
            while (pasirinkimas != 1 && pasirinkimas != 2)
            {
                Console.WriteLine("Jei norite prisijungti - iveskite 1, " +
                "jei norite registruotis - iveskite 2");
                try
                {
                    pasirinkimas = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    pasirinkimas = 0;
                }
            }

            switch (pasirinkimas)
            {
                case 1:
                    {
                        return Prisijungimas.Prisijungti();
                    }
                case 2:
                    {
                        return Registracija.Registruotis();
                    }
                default:
                    {
                        return false;
                    }
            }
        }
    }
}
