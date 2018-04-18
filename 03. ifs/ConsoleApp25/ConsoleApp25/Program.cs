using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите км");
            double kM = double.Parse(Console.ReadLine());
            Console.WriteLine("введите футы");
            double foot = double.Parse(Console.ReadLine());
            double foots = foot*0.305;
            if (kM < foots)
            {
                Console.WriteLine(kM);
            }
            else
            {
                Console.WriteLine(foot);
            }
            Console.ReadLine();
        }
    }
}
