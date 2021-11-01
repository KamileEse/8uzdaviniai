using System;
using System.IO;

namespace Task5
{
    class MainClass
    {
        //1. Irašyti į failą iš vartotojo paimtus duomenis (jeigu nutiktų klaida,  parodyti žinutę vartotojui)
        //2. Nuskaityti iš failo jeigu nutiktų klaida, parodyti žinutę vartotojui)

        public static void Main(string[] args)
        {
            string vieta = "/Users/kamileeselinaite/Desktop/C#/test2.txt";
            IvestiDuomenis(vieta);
            NuskaitytiDuomenis(vieta);
        }  



        public static void IvestiDuomenis(string vieta)
        {
            Console.WriteLine("Iveskite teksta:");
            string duomenys = Console.ReadLine();

            try
            {
                using (StreamWriter sw = new StreamWriter(vieta))
                {
                    sw.WriteLine(duomenys);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Klaida! {e.Message}");
            }
        }

        public static void NuskaitytiDuomenis(string vieta)
        {
            string duomenys;

            try
            {
                using(StreamReader sr = new StreamReader(vieta))
                {
                    duomenys = sr.ReadToEnd();
                    Console.WriteLine($"Nuskaityti duomenys: {duomenys}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Klaida! {e.Message}");
            }
        }
    }
}
