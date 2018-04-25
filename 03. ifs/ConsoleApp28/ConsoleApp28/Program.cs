using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите свой возраст");
            double age = double.Parse(Console.ReadLine());
            if(age>= 10 && age <= 20)
            {
                Console.WriteLine("вы подросток");
            }
            else
            {
                Console.WriteLine("вы взрослый");
            }
               

          Console.ReadLine();
        }
    }
}
