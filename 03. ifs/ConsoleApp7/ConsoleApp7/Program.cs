using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВЕДИТЕ СТОРОНУ КАВАДРАТА");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine(side * 4);
            Console.ReadLine();
        }
    }
}
