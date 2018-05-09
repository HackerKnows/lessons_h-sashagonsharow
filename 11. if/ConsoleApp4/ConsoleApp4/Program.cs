 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            double number=double.Parse(Console.ReadLine());
            if (0 > number)
            {
                Console.WriteLine(number*(-1));
            }
            else
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
