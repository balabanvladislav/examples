using System;
using System.Linq;
using System.Security.Cryptography;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car();
            audi["marca"] = "Audi";
            audi["anul"] = "2001";
            audi["kilometraj"] = "100000";
            Console.WriteLine($"{audi["marca"]}, anul {audi["anul"]}, {audi["kilometraj"]} km.");
        }

        class Car
        {
            private string marca;
            private string anul;
            private string kilometraj;

            public string this[string val]
            {
                set
                {
                    switch (val)
                    {
                        case "marca":
                            marca = value;
                            break;
                        case "anul":
                            anul = value;
                            break;
                        case "kilometraj":
                            kilometraj = value;
                            break;
                    }
                }
                get { 
                    switch (val)
                    {
                        case "marca":
                            return marca;
                            break;
                        case "anul":
                            return anul;
                            break;
                        case "kilometraj":
                            return kilometraj;
                            break;
                        default:
                            return null;
                    } }
            }
        }
    }
}