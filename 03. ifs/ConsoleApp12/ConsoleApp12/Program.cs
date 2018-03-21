using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое чичло");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе чичло");
            int b = int.Parse(Console.ReadLine());
            int c;
            c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
