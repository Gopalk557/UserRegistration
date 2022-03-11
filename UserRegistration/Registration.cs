using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Registration
    {
        public void UserData()
        {
            Regex reg = new Regex("^[A-Z]{1}[a-z]{2,12}$");

            Console.WriteLine("Enter FirstName");
            string fname = Console.ReadLine();

            if (reg.IsMatch(fname))
            {
                Console.WriteLine("Your Name is: " + fname);
            }
            else
            {
                Console.WriteLine("Please Enter valid Name!");
            }


        }
    }
}
