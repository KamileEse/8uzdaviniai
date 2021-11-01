using System;
using System.Collections.Generic;
using System.IO;

namespace Task7
{
    public class VartotojuDuomenuBaze
    {
        static protected Dictionary<string, string> VartotojuSarasas = new Dictionary<string, string>();

        public static bool PatikrintiDuomenis()
        {
            string temp;
            string[] tempA;
            try
            {
                using (StreamReader sr = File.OpenText("/Users/kamileeselinaite/Desktop/C#/task7.txt"))
                {
                    while ((temp = sr.ReadLine()) != null)
                    {
                        tempA = temp.Split(' ');
                        VartotojuSarasas.Add(tempA[0], tempA[1]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Klaida!" + e.Message);
                return false;
            }

            return true;
        }
    }
}
