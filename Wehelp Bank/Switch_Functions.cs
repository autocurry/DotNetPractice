using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wehelp_Bank
{
    public class Switch_Functions
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public double acc_no { get; set; }
        public int age { get; set; }

        public void Register()
        {

            Console.WriteLine("Please enter your first name");
            first_name = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            last_name = Console.ReadLine();
            Console.WriteLine("Please enter your age");

            age = Convert.ToInt32(Console.ReadLine());
   
            Console.WriteLine("You are successfully registered!");
            Console.WriteLine("Name:" + first_name + " " + last_name);
            Console.WriteLine("Age:" + age);
        }

        public void View_Details()
        {


            Console.WriteLine("Name:" + first_name + last_name);
            // Console.WriteLine("Age:" + age);

        }

    }
}
