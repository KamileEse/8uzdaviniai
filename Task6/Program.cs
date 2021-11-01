using System;

namespace Task6
{
    //1. Sukurti klasę kuri turėtų du metodus
    //2. Metodas 1 turėtų patikrinti ar faile egzistuoja įrašas ir gražinti "taip" arba "ne"
    //3. Metodas 2 turėtų pridėti įrašą į failą
    //4. Nutikus klaidai, klaida išsaugoma į atskirą failą.

    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = @"/Users/kamileeselinaite/Desktop/C#/test6.txt";
            string tekstas;
            tekstas = Console.ReadLine();

            Klase6 naujasIrasas = new Klase6();

            naujasIrasas.PatikrintiArEgzistuoja(path, "lalala");
            naujasIrasas.PridetiIrasa(path);

            Console.ReadLine();
        }
    }
}
