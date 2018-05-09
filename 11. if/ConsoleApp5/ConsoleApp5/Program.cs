using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5 { 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число 1");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите число 2");
            double number2 = double.Parse(Console.ReadLine());
            if (number1 > number2&&0<number1&&0<number2)
            {
                Console.WriteLine(number1/2);
            }
            else if((number1/-1) > (number2 / -1) && 0 > number1 && 0 > number2)
            {
                Console.WriteLine(number1 / 2);
            }
            Console.ReadLine();
        }
    }
}
