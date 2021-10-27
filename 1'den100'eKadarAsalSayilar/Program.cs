using System;
using System.Collections.Generic;

namespace _1_den100_eKadarAsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int count;
            List<int> asalSayilar = new List<int>();

            Console.WriteLine("Birden yüze kadar asal sayılar:");
            for (number = 1; number <= 100; number++)
            {
                count = 0;

                for (int i = 2 ; i < number-1; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 0 && number != 1)
                {

                    asalSayilar.Add(number);
                }
            }
            foreach (var asalsayi in asalSayilar)
            {
                Console.WriteLine(asalsayi);
            }
        }
    }
}
