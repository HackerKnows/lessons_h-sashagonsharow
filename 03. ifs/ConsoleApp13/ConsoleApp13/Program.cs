using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол-во жителейи в государстве ");
            double cityzens = double.Parse(Console.ReadLine());
            Console.WriteLine("введите площадь государства");
            double town = double.Parse(Console.ReadLine());
            Console.WriteLine(cityzens / town);
            Console.ReadLine();
        }
    }
}
