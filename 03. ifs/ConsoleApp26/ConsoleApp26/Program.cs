using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите цену pc в прошлом году");
            double lastPc = double.Parse(Console.ReadLine());
            Console.WriteLine("введите цену pc в этом году");
            double pc = double.Parse(Console.ReadLine());
            Console.WriteLine("введите цену консоли в прошлом году");
            double lastСonsole = double.Parse(Console.ReadLine());
            Console.WriteLine("введите цену консоли в этом году");
            double console = double.Parse(Console.ReadLine());
            if (pc / lastPc < console / lastСonsole)
            {
                Console.WriteLine("консоль подоражала больше");
            }
            else
            {
                Console.WriteLine("компьютр подорожал");
            }
            Console.ReadLine();
        }
    }
}
