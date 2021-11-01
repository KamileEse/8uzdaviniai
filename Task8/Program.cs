using System;
using System.Collections.Generic;
using System.IO;

namespace Task8
{
    //1. Turime 2 failus: Studentai.txt ir Destytojai.txt tokiu formatu
        //Vardenis Pavardenis 1
        //Pavardis Vardauskas 4 ir t.t
    //2. Ijungus, programa turi atvaizduoti sugrupuota informacija: kursas, destytojai tam kurse, studentai tam kurse
    //3. Apacioje lenteles, turi buti informacija kiek yra kursu, kiek studentu ir kiek destytoju

    class MainClass
    {
        public static List<Zmogus> studentuSarasas = new List<Zmogus>();
        public static List<Zmogus> destytojuSarasas = new List<Zmogus>();
        public static List<int> kursuSarasas = new List<int>();

        static void Main(string[] args)
        {
            UzpildytiDuomenimis();
            UzpildytiKursus();
            SugrupuotiSarasus();
            Suskaiciuoti();

            studentuSarasas.Sort((a, b) => a.Vardas.CompareTo(b.Vardas));
            destytojuSarasas.Sort((a, b) => a.Vardas.CompareTo(b.Vardas));
            kursuSarasas.Sort();

            Console.WriteLine();
            Console.ReadLine();

        }

        static void UzpildytiDuomenimis()
        {
            string[] tempA;
            string temp;

            using (StreamReader sr = File.OpenText("/Users/kamileeselinaite/Desktop/C#/Studentai.txt"))
            {
                while((temp = sr.ReadLine()) != null)
                {
                    tempA = temp.Split(' ');
                    Studentas studentas = new Studentas(tempA[0], tempA[1], Convert.ToInt32(tempA[2]));
                    studentuSarasas.Add(studentas);
                }
            }

            using (StreamReader sr = File.OpenText("/Users/kamileeselinaite/Desktop/C#/Destytojai.txt"))
            {
                while ((temp = sr.ReadLine()) != null)
                {
                    tempA = temp.Split(' ');
                    Destytojas destytojas = new Destytojas(tempA[0], tempA[1], Convert.ToInt32(tempA[2]));
                    studentuSarasas.Add(destytojas);
                }
            }
        }

        static void UzpildytiKursus()
        {
            bool pasikartoja = false;

            foreach(Destytojas item in destytojuSarasas)
            {
                foreach(int k in kursuSarasas)
                {
                    if (item.Kursas == k)
                    {
                        pasikartoja = true;
                    }
                }
                if (!pasikartoja)
                {
                    kursuSarasas.Add(item.Kursas);
                }
            }
        }

        static void SugrupuotiSarasus()
        {
            foreach(int k in kursuSarasas)
            {
                Console.WriteLine($"Kursas: {k}");
                Console.WriteLine("Kurso destytojai:");
                foreach(Destytojas d in destytojuSarasas)
                {
                    if(d.Kursas == k)
                    {
                        Console.WriteLine(d);
                    }
                }
                Console.WriteLine("Kurso studentai:");
                foreach(Studentas s in studentuSarasas)
                {
                    if(s.Kursas == k)
                    {
                        Console.WriteLine(s);
                    }
                }
                Console.WriteLine();
            }
        }

        static void Suskaiciuoti()
        {
            int destSk = destytojuSarasas.Count;
            int studSk = studentuSarasas.Count;
            int kursSk = kursuSarasas.Count;

            Console.WriteLine($"Destytoju yra: {destSk}, studentu: {studSk}, o kursu: {kursSk}");
        }
    }
}
