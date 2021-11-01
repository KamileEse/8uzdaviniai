using System;
using System.IO;

namespace Task7
{
    public class Registracija : VartotojuDuomenuBaze
    {
        public static bool Registruotis()
        {
            bool salyga = true;
            string tempVardas = null;
            string tempSlaptazodis = null;

            while (salyga)
            {
                Console.WriteLine("Iveskite nauja prisijungimo varda:");
                tempVardas = Console.ReadLine();
                if (!VartotojuSarasas.ContainsKey(tempVardas))
                {
                    salyga = false;
                }
                else
                {
                    Console.WriteLine("Toks vardas jau yra, bandykite dar karta:");
                }
            }
            salyga = true;

            while (salyga)
            {
                Console.WriteLine("Iveskite slaptazodi:");
                tempSlaptazodis = Console.ReadLine();
                if(tempSlaptazodis.Length <= 6)
                {
                    Console.WriteLine("Slaptazodis turi buti ilgesnis nei 6 simboliai");
                }
                else
                {
                    salyga = false;
                }
            }

            using (StreamWriter sw = File.AppendText("/Users/kamileeselinaite/Desktop/C#/task7.txt"))
            {
                sw.WriteLine($"{tempVardas} {tempSlaptazodis}");
            }

            return true;
        }
    }
}
