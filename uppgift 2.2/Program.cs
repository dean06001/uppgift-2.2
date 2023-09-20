using System;
using System.Diagnostics.Metrics;

namespace uppgift_2_2
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            double Elin = double.Parse(Console.ReadLine());
            Console.WriteLine("hur långt hoppade Alma i meter?");
            string höjdText = Console.ReadLine();
            double Alma = double.Parse(höjdText);
            double skillnad = 1.45 - Elin;
            Console.WriteLine("Elin hoppade" + skillnad + "meter längre");
            Console.ReadLine();
        }
    }
}