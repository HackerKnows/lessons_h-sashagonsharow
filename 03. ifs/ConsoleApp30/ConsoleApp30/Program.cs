using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите проценты кислорода на планете марс");
            double o = double.Parse(Console.ReadLine());
            Console.WriteLine("введите градусы на планете марс");
            double c = double.Parse(Console.ReadLine());
            if(o>20 && c > 15)
            {
                Console.WriteLine("планета пригодна для жизни!");
            }
            else
            {
                Console.WriteLine("планета не пригодна для жизни!");
            }
            Console.ReadLine();
        }
    }
}
