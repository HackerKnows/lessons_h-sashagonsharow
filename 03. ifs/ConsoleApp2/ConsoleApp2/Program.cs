using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            int c = 0;
          
                for (int i = 0; i < 10; i++)
                {
                    result = i.ToString() + i.ToString();
                    Console.WriteLine(result);
                c += int.Parse(result);
                for (int g = 0; g < 10; g++)
                {
                    result = i.ToString()+ i.ToString()+ g.ToString();
                    Console.WriteLine(result);
                    c += int.Parse(result); ;
                    for (int f = 0; f < 10; f++)
                    {
                        result = i.ToString() + i.ToString() + g.ToString() + f.ToString();
                        Console.WriteLine(result);
                        c += int.Parse(result); ;
                    }
                }
                }

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
