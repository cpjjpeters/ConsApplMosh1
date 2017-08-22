using System;

namespace OperatorsAndMore
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Mijn name is "+FirstName +" "+LastName);

        }
    }
}