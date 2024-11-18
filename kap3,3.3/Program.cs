using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kap3_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många timmar vill du hyra ut bilen?");
            int timmar = int.Parse(Console.ReadLine());

            int kostnad = timmar * 80;

            if (kostnad > 950)

            {
                kostnad = 950;
            }

            Console.WriteLine($"kostnaden för att hyra bilen är {kostnad} kr");


        }
    }
}
