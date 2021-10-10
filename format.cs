using System;
using System.Linq;

namespace Num_Format_CSharp
{
    class Program
    {
        static void Format()
        {
            Console.Write("Enter a number for formatting --> ");
            string input = Console.ReadLine();
            double num;
            Double.TryParse(input, out num);
            string place = "";
            
            if (num <= 999)
            {
                place = "";
            }
            else if (999 <= num && num < 99999)
            {
                double x = num / 10;
                num = x / 100;
                place = "Thousand";
            }
            else if (999999 <= num && num < 9999999999)
            {
                double x = num / 10000;
                num = x / 100;
                place = "Million";
            }
            else if (9999999999 <= num && num < 999999999999)
            {
                double x = num / 10000000;
                num = x / 100;
                place = "Billion";
            }

            Console.WriteLine($"\n{num} {place}");
        }
        static void Main(string[] args)
        {
            Console.Title = "C# Number Format Console";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Start Program. [Y]es or [N]o?");
            string ask = Console.ReadLine();
            
            if (ask == "Y")
            {
                Format();
            }
            else
            {
                Console.WriteLine("Exiting Program...");
            }
        }
    }
}
