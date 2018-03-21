using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("сколько игр ты успел сыграть");
            double games = double.Parse(Console.ReadLine());
            Console.WriteLine(" сколько из них ты выиграл");
            double gamesWin= double.Parse(Console.ReadLine());
            Console.WriteLine("твой винрейт="+gamesWin / games);
            Console.ReadLine();
        }
    }
}
