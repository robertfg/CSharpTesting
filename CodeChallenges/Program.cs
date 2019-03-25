using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = new Calculator(1.1);
            Console.WriteLine(target.Result);
            target.Add(2.2);
            Console.WriteLine(target.Result);

            Console.ReadKey();
        }
    }
}
