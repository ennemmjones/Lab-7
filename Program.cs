using System;
using System.Text.RegularExpressions;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                IsAName();  // Call method to validate name
                IsAnEmail();  // Call method to validate email address
                IsAPhoneNumber(); // Call method to validate phone number
                IsADate();  // Call method to validate date
                IsAnElement();  // Call method to validate HTML element
            } while (WillContinue()); // Call method to continue or exit - continue if true.
        }


        public static void IsAName()
        {
            Console.Write("Please enter a valid Name:");
            string inputName = Console.ReadLine();
            Regex regex = new Regex(@"^[A-Z]([a-z]{1,29})$");  // matches starts with capital letter, 30 char max

            if (regex.IsMatch(inputName))
            {
                Console.WriteLine("Name is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid!");
            }
        }

        public static void IsAnEmail()
        {
            Console.Write("Please enter a valid email:");
            string inputEmail = Console.ReadLine();
            Regex regex = new Regex(@"^[A-Za-z0-9]{5,30}@[A-Za-z0-9]{5,10}.[A-Za-z0-9]{2,3}$");  // Matches 5 - 30 alpahnumeric, '@', 5 -10 alphanumeric, '.', 2 - 3 alphanumeric

            if (regex.IsMatch(inputEmail))
            {
                Console.WriteLine("Email is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, Email is not valid!");
            }
        }

        public static void IsAPhoneNumber()
        {
            Console.Write("Please enter a valid phone number:");
            string inputPhone = Console.ReadLine();
            Regex regex = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");  // Matches 3 numerals, '-', 3 numerals, '-', 4 numerals

            if (regex.IsMatch(inputPhone))
            {
                Console.WriteLine("Phone number is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, phone number is not valid!");
            }
        }

        public static void IsADate()
        {
            Console.Write("Please enter a valid Date:");
            string inputDate = Console.ReadLine();
            Regex regex = new Regex(@"^[0-9]{2}\/[0-9]{2}\/[0-9]{4}$"); // Matches 2 numerals, '/', 2 numerals, '/', 4 numerals

            if (regex.IsMatch(inputDate))
            {
                Console.WriteLine("Date is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, date is not valid!");
            }
        }

        public static void IsAnElement()
        {
            Console.Write("Please enter a valid HTML element:");
            string inputElement = Console.ReadLine();
            Regex regex = new Regex(@"^<.+>\s*<\/.+>$");  // Matches '<', any characters, '>', any number spaces, '<', '/', any characters, '>'

            if (regex.IsMatch(inputElement))
            {
                Console.WriteLine("HTML element is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, HTML element is not valid!");
            }
        }




        public static bool WillContinue()
        {
            Console.Write("Would you like to continue (y/n)?"); // prompt user to continue or exit
           
            if (Console.ReadLine().ToLower() == "y") // user input to continue or exit
            {
                return true;
            }

            else
            {
                Console.WriteLine("Goodbye!");
                return false;
            } 
        }
    }
}
