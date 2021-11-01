using System;
using System.Collections.Generic;

namespace Task2
{
    class MainClass
    {
        //1. Programa turi paprašyti suvesti 4 teigiamus skaičius
        //2. Patikrinti, kad visi skaičiai yra teigiami(jeigu ne,
        //išvesti vartotojui klaidą)
        //3. Išspausdinti visų skaičių sumą, skirtumą, sandaugą, dalybą,
        //jeigu visi skaičiai teigiami

        public static void Main(string[] args)
        {
            Inputter irasas = new Inputter();


            irasas.Nuskaitymas();
            irasas.SarasasTeigiamas(); // nemoku iskviest
            

            Console.ReadLine();
        }
    }
}
