using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите имя первого игрока");
            string nameOfFirstPlayer = Console.ReadLine();
            Console.WriteLine("введите имя второго игрока");
            string nameOfSecondPlayer = Console.ReadLine();
            Console.WriteLine("введите рейтинг первого игрока");
            int ratingOfFirstPlayer =int.Parse(Console.ReadLine());
            Console.WriteLine("введите рейтинг второго игрока");
            int ratingOfSecondPlayer =int.Parse(Console.ReadLine());
            if(ratingOfFirstPlayer> ratingOfSecondPlayer)
            {
                Console.WriteLine(nameOfSecondPlayer +"                              "+nameOfFirstPlayer); 
            }
            else
            {
                Console.WriteLine(nameOfFirstPlayer + "                              " + nameOfSecondPlayer);
            }
            Console.ReadLine();
        }
    }
}
