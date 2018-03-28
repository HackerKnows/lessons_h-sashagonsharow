using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вычесление_роста_и_веса
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите рост!");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("введите весс!");
            double weight = double.Parse(Console.ReadLine());
            if (height - 100 < weight)
            {
                Console.WriteLine("вам нужно похудеть");
            }
            else { 
                Console.WriteLine("вам нужно поправится");
            }   
                Console.ReadLine();
        }
    }
}
