using System;

namespace NWD_Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a, b;

            // Gets a from user
            Console.Write("Podaj a: ");

            bool isSucces = uint.TryParse(Console.ReadLine(), out a);

            if (!isSucces || a < 1)
            {
                Console.WriteLine("Liczba a jest niepoprawna");
                return;
            }

            // Gets b from user
            Console.Write("Podaj b: ");

            isSucces = uint.TryParse(Console.ReadLine(), out b);

            if (!isSucces || b < 1)
            {
                Console.WriteLine("Liczba b jest niepoprawna");
                return;
            }

            Console.WriteLine($"NWD({a}, {b}) = {NWD(a, b)}"); 
        }

        /**********************************************
        nazwa funkcji: NWD
        opis funkcji: Calculates NWD using the Euclidean algorithm
        parametry: a – first integer (non-negative), b – second integer (non-negative)
        zwracany typ i opis: uint, calculated NWD
        autor: Bartosz Kulesza 4TF
        ***********************************************/


        private static uint NWD(uint a, uint b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
    }
}
