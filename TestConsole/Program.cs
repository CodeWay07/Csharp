using System;
using Csharp.Calclib;

namespace Csharp.TestConsole
{
    class Program
    {         
        static void Main(string[] args)
        {
            int x = 6;
            int y = ++x;
            Console.WriteLine("x + y = {0}", Calc.Sum(x, y));
        }
    }
}


























