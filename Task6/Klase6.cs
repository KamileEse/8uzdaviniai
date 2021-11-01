using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task6
{
    public class Klase6
    {
        public void PatikrintiArEgzistuoja(string tekstas, string path)
        {
            List<string> irasas = new List<string>();
            irasas = File.ReadAllLines(path).ToList();

            if (irasas.Contains(tekstas))
            {
                    Console.WriteLine("Taip");
            }
            else
            {
                Console.WriteLine("Ne");
            }
        }

        public void PridetiIrasa(string tekstas)
        {
            try
            {
                string path = @"/Users/kamileeselinaite/Desktop/C#/test6.txt";
                File.WriteAllText(path, tekstas);
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Ivyko klaida, tokia vieta neegzistuoja");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("ERROR 404");
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("Jums nesuteikta teise pasiekti faila");
            }
            catch(Exception)
            {
                Console.WriteLine("Klaida");
            }
        }

    }
}
