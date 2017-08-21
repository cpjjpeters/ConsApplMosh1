

using System;

namespace ConsApplMosh1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(a + b * c);
            Console.WriteLine("'/' " + b-- / a);
            Console.WriteLine("'%' " + ++b % a);
            Console.WriteLine("{0} {1} {2} {3} ","a", a, b,c);
            Console.WriteLine(a > a || c > b);
            Console.Beep();
        }
    }
}
