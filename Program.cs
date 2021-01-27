using System;

namespace ConsoleApplication2
{
    class Power
    {
        public static int Do(int pow, int contor)
        {
            int number = pow;
            pow *= number;
            Console.WriteLine($"{pow}, {contor - 1} , {number}");
            return Do(pow,  contor - 1, number);
        }
        public static int Do(int pow, int contor, int number)
        {
            if (contor <= 1) return pow;
            pow *= number;
            Console.WriteLine(pow);
            Console.WriteLine($"{pow}, {contor - 1} , {number}");
            return Do(pow, contor - 1, number);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            int baza = 2;
            int exponent = 2;
            Console.WriteLine(Power.Do(baza, exponent));
            


        }
    }
}