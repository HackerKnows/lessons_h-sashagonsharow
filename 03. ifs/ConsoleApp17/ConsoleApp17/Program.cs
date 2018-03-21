using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите сторону a");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("введите сторону b");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("введите сторону c");
            double sideC = double.Parse(Console.ReadLine());
            if (sideA * sideA + sideB * sideB == sideC * sideC)
            {
                Console.WriteLine("ТРЕУГОЛЬНИК ПРЯМОУГОЛЬНЫЙ");
            }
            else {
                Console.WriteLine("ТРЕУГОЛЬНИК НЕ ПРЯМОУГОЛЬНЫЙ");
            }
            Console.ReadLine();
        }
    }
}
