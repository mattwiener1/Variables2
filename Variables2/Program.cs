using System;
using System.Security.Principal;

namespace Variables2
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            var methodId = 3;

            //Console.WriteLine((ShippingMethod)methodId);

            //Console.WriteLine(method);

            var matt = new Person
            {
                firstName = "Matt",
                lastName = "Wiener"
            };

            matt.Introduce();
            
            var total = new Calculator();
            Console.WriteLine(total.Add(12,13));


        }
    }
}
