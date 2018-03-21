using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол-во прошедших дней");
            double days = double.Parse(Console.ReadLine());
            Console.WriteLine(days / 7);
            Console.ReadLine();
        }
    }
}
