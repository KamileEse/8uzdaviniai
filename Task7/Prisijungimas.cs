using System;
namespace Task7
{
    public class Prisijungimas : VartotojuDuomenuBaze
    {
        public static bool Prisijungti()
        {
            string Vardas;
            string Slaptazodis;

            while (true)
            {
                Console.WriteLine("Iveskite prisijungimo varda:");
                Vardas = Console.ReadLine();
                if (VartotojuSarasas.ContainsKey(Vardas))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tokio vartotojo nera");
                }
            }

            VartotojuSarasas.TryGetValue(Vardas, out string tempS);
            while (true)
            {
                Console.WriteLine("Iveskite slaptazodi:");
                Slaptazodis = Console.ReadLine();

                if (Slaptazodis == tempS)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
