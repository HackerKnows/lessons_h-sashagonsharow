using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите колл-во очков за игру");
            double point=double.Parse(Console.ReadLine());
            if (point == 3)
            {
                Console.WriteLine("победа");
            }
            else if (point == 1)
            {
                Console.WriteLine("ничья");
            }
            else
            {
                Console.WriteLine("проигрыш");
            }
            Console.ReadLine();
        }
    }
}
