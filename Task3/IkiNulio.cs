using System;
using System.Collections.Generic;

namespace Task3
{
    public class IkiNulio
    {
        public IkiNulio()
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            List<int> skaiciai = new List<int>();

            while (skaicius != 0)
            {
                Console.WriteLine("Iveskite skaiciu");
                skaicius = Convert.ToInt32(Console.ReadLine());

                skaiciai.Add(skaicius); 
            }

            foreach (int i in skaiciai)
            {
                Console.Write(i);
            }
        }
    }
}
