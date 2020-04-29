using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wehelp_Bank
{
    class Program
    {
        
        static string message = "Press 1.Register , 2.View details, 3.Add Balance ,4.Reduce Balance ,5.Check Balance, 6.Deregister";

        static void Main(string[] args)
        {
            Boolean process = true;
            Console.WriteLine("Welcome to WeHelp online banking services..");
            while (process){
                start();
                Console.WriteLine("Action Successfull, Press Y to continue, any other key to exit");
                var temp = Console.ReadLine();
                if(!temp.ToUpper().Equals("Y"))
                {
                    process = false;
                }
            }
            
            
        }

        public static void start()
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            ActionOnInput(input);
            
        }

        private static void ActionOnInput(string input)
        {
            Switch_Functions _switch = new Switch_Functions();
            switch (input)
            {
                case "1":
                    _switch.Register();
                    break;

                case "2":
                    _switch.View_Details();
                    break;

                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;

            }
        }
    }
}
