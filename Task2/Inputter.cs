using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class Inputter
    {
        public void Nuskaitymas()
        {
            List<int> manoSarasas = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Iveskite skaiciu {i + 1}");
                string ivestis = Console.ReadLine();
                int skaicius = Convert.ToInt32(ivestis);
                manoSarasas.Add(skaicius); // --Add yra metodas
            }
        }

        public bool SarasasTeigiamas(List<int> skaiciuSarasas)
        {
            bool rezultatas = true;   // rezultatas bus true, kol nesutiksiu neigiamo. kai
            //sutiksiu, pakeis i false -->

            if (skaiciuSarasas == null || skaiciuSarasas.Count == 0) // -- kai ne metodas, tai be skliaustu
            {
                rezultatas = false;
            }

            foreach (var skaicius in skaiciuSarasas)
            {
                // jei 1 - nieko nedaro
                // jei -2 - rezultatui priskirs false reiksme

                if (skaicius <= 0)
                {
                    rezultatas = false;
                }
            }
            // rezultatas - false

            return rezultatas; // grazina false
        }

        public void MatematiniaiVeiksmai(List<int> skaiciuSarasas)
        {
            var suma = skaiciuSarasas.Count();

            var sandauga = skaiciuSarasas.Aggregate((x, y) => x * y);
        }

    }
}
