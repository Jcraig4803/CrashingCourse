﻿using System;
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
            Console.WriteLine("Hello, world");
            Console.Read();
            string admin_username = "jcraig4803";
            string admin_password = "12345";
            string admin_log = "";
            string user_input = "";
            string user_name = "";
            string user_age = "";
            string user_phonenumber = "";
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
            else
            {
                Console.ReadLine();
            }
        }
    }
}