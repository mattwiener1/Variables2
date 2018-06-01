using System;

namespace Variables2
{
    public class Person
    {
            public string firstName;
            public string lastName;

            public void Introduce()
            {
                Console.WriteLine("My name is " + firstName + " " + lastName);
            }
    }
}
