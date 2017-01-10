using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashingCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            string admin_username = "jcraig4803";
            string admin_password = "12345";
            string admin_log = "";
            string user_input = "";
            string user_name = "";
            string user_age = "";
            string user_phonenumber = "";

            string pick_number = "";
            const int winning_num = 2;
            const int winning_num2 = 4;
            string user_data = Console.ReadLine();
            int user_value;
            Console.WriteLine("Pick a Number 1 Throught 5");
            pick_number = Console.ReadLine();
            int.TryParse(pick_number, out user_value);
            switch (user_value) {
                case winning_num:
                    Console.WriteLine("Fizz");
                    break;
                case winning_num2:
                    Console.WriteLine("Buzz");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;

            }
            Console.Read();
            {

                Console.WriteLine("Input Admin username");
                user_input = Console.ReadLine();
                Console.WriteLine("Input Admin password");
                admin_log = Console.ReadLine();
                if (user_input == admin_username && admin_log == admin_password)
                {
                    Console.WriteLine("Tell me your name.");
                    user_name = Console.ReadLine();

                    Console.WriteLine("Hello, " + user_name + " Tell me your age, ");
                    user_age = Console.ReadLine();

                    Console.WriteLine("Tell me your phone number " + user_name);
                    user_phonenumber = Console.ReadLine();

                    Console.WriteLine("So your name is " + user_name + " you are " + user_age + " years old " + " and your phone number is " + user_phonenumber);


                    Console.ReadLine();
                }
               
                
                
            
            else {
                    Console.WriteLine("You Lose");
                    Console.ReadLine();
                }
            }
        }
    }
}

