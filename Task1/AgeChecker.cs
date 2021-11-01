using System;
namespace Task1
{
    public class AgeChecker
    {
        public int Nuskaitymas()
        {
            Console.WriteLine("Iveskite savo amziu:");
            int amzius = Convert.ToInt32(Console.ReadLine());
            return amzius;
        }

        public Possibilities ageEvaluate(int amzius)
        {
            if (amzius < 18)
            {
                return Possibilities.nieko;
            }
            else if (amzius >= 18 && amzius < 20)
            {
                return Possibilities.vairuoti;
            }
            else
            {
                return Possibilities.vairuotiGerti;
            }
        }        
    }
}
