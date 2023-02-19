using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Pattern
    {
        public static string Name = "^[A-Z][a-z]{2,}$";
        public static string LastName = "^[A-Z][a-z]{2,}$";

        public static string Email = @"^(?=[a-z])[a-z 0-9.!#+$%&_-]{3,}[@][a-z 0-9]{1,6}.(com|com.com|io|com.au|net|org)$";

        public static string MobileNumber = @"^[+]91[ ][6-9]{1}[0-9]{9}$";
        public static string PassWord = @"^((?=.*[A-Z])(?=.*[0-9])(?=.*[a-z])(?=.*[!#@*+&%_-]))[a-z A-Z 0-9 !@#*+%&_-]{8,}$";

    }
    public class Form
    {
        public void form()
        {
            Regex name = new Regex(Pattern.Name);
            bool check = false;
            Console.WriteLine("\nFirst name starts with Cap and has minimum 3 characters");
            while (!check)
            {
                Console.Write("\nEnter your Name :");
                string userName = Console.ReadLine();
                check = name.IsMatch(userName);

                if (check == false)
                {
                    Console.WriteLine("\nplease follow - First name starts with Cap and has minimum 3 characters ");
                }
                else
                {
                    Console.WriteLine("******done");
                }

            }
            Regex lastname = new Regex(Pattern.LastName);
            check = false;
            Console.WriteLine("\nLast name starts with Cap and has minimum 3 characters");
            while (!check)
            {
                Console.Write("\nEnter your Last Name :");
                string userLastName = Console.ReadLine();
                check = lastname.IsMatch(userLastName);

                if (check == false)
                {
                    Console.WriteLine("\nplease follow - Last name starts with Cap and has minimum 3 characters ");
                }
                else
                {
                    Console.WriteLine("*****done");
                }

            }

            Regex email = new Regex(Pattern.Email);
            check = false;

            while (!check)
            {
                Console.Write("Enter your email :");
                string userEmail = Console.ReadLine();
                check = email.IsMatch(userEmail);

                if (check == false)
                {
                    Console.WriteLine("\nplease follow - please enter right email ");
                }
                else
                {
                    Console.WriteLine("*****done");
                }

            }

            Regex mobileNumber = new Regex(Pattern.MobileNumber);
            check = false;
            Console.WriteLine("\nplease enter country code +91 and a space betweeen code and number");

            while (!check)
            {
                Console.Write("\nEnter your Mobile No. : ");
                string number = Console.ReadLine();
                check = mobileNumber.IsMatch(number);

                if (check == false)
                {
                    Console.WriteLine("\nplease follow - please enter country code +91 and a space betweeen code and number");
                }
                else
                {
                    Console.WriteLine("******done");
                }

            }
            Regex password = new Regex(Pattern.PassWord);
            check = false;
            Console.WriteLine("\nMake Password minimum 8  minimum 1Uppercase, 1 lowercase, 1 numeric, 1 special characters required  ");

            while (!check)
            {
                Console.Write("Enter password :");
                string passKey = Console.ReadLine();
                check = password.IsMatch(passKey);
                if (check == false)
                {
                    Console.WriteLine("\nPlease follow -  Password must have minimum 8 ,1 upper case, 1 lower case, 1 numeric, 1 special characters ");

                }
                else
                {
                    Console.WriteLine("*****done");
                }

            }
        }

    }
}