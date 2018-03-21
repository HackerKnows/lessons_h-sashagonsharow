using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите возраст Тани");
            double ageOfTania = double.Parse(Console.ReadLine());
            Console.WriteLine("введите возраст Мити");
            double ageOfMytia = double.Parse(Console.ReadLine());
            Console.WriteLine("средний возраст="+(ageOfTania+ageOfMytia)/2);
            Console.ReadLine();
        }
    }
}
