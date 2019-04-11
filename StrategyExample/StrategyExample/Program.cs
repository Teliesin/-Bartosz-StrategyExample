using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();

            man.Work();

            // masa linijek kodu

            Console.WriteLine(man.IntroduceYourself());

            man.Home();

            // masa linijek kodu

            Console.WriteLine(man.IntroduceYourself());

            Console.ReadKey();
        }
    }
}
