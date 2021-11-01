using System;
namespace Task8
{
    public class Zmogus
    {
        public String Vardas;
        public String Pavarde;
        public int Kursas;

        public Zmogus(string vardas, string pavarde, int kursas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Kursas = kursas;
        }

        public override string ToString()
        {
            return $"{Vardas} {Pavarde}";
        }
    }
}
