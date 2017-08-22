using System;

namespace OperatorsAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine(a / b);

            var person = new Person();
            person.FirstName = "Carl";
            person.LastName = "Peters";
            person.Introduce();
        }
    }
}
