using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите координаты x");
            double coordinatesX = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координаты y");
            double coordinatesY = double.Parse(Console.ReadLine());
            if (coordinatesX < 4)
            {
                Console.WriteLine("координата лежит на стороне 1");
            }
            else
            {
                Console.WriteLine("координата лежит на стороне 2");
            }
            Console.ReadLine();
        }
    }
}
