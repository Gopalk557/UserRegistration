using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration");
            Registration registration = new Registration();
            registration.UserData();
            Console.ReadKey();
        }
    }
}
