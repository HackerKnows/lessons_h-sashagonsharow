using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace три_целых_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число 1");
            double one = double.Parse(Console.ReadLine());
            Console.WriteLine("введите число 2");
            double two = double.Parse(Console.ReadLine());
            Console.WriteLine("введите число 3");
            double three = double.Parse(Console.ReadLine());
            if (one > two&&one>three)
            {
                Console.WriteLine("число one больше");
            }
            else if (two > one && two > three)
            {
                Console.WriteLine("число two больше");
            }
            else
            {
                Console.WriteLine("число three больше");
            }
            Console.ReadLine();
        }
    }
}
