using System;


namespace NWD_Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gets a from user
            Console.Write("Podaj a: ");
            uint a = uint.Parse(Console.ReadLine());

            // Gets b from user
            Console.Write("Podaj b: ");
            uint b = uint.Parse(Console.ReadLine());

            // Check if number is grater than 1
            if (a < 1 || b < 1)
                Console.WriteLine("Liczby powinny być dodatnie!");
            else
                Console.WriteLine($"NWD({a}, {b}) = {NWD(a, b)}"); 
        }

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
