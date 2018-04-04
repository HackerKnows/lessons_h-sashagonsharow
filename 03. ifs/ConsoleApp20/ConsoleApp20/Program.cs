using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
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
            double sideС = double.Parse(Console.ReadLine());
            if (sideA + sideB>sideС)
            {
                Console.WriteLine("треугольник существует");
            }
            else
            {
                Console.WriteLine("треугольник не существует");
            }
            Console.ReadLine();
        }
    }
}
