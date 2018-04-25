using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите жизни дракона");
            double hp = double.Parse(Console.ReadLine());
            Console.WriteLine("введите возраст дракона");
            double age = double.Parse(Console.ReadLine());
            if (hp < 50 || age < 150)
            {
                Console.WriteLine("ннннннннннааааааааааппппппппппааааааааааддддддддддаааааааааай!");
            }
            else
            {
                Console.WriteLine("ннннннннннееееееееее ннннннннннааааааааааппппппппппааааааааааддддддддддаааааааааай!");
            }
            Console.ReadLine();
        }
    }
}
