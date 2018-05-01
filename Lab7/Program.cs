using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool NameSuccess = true;
            while (NameSuccess)
            {
                Console.WriteLine("Please enter a valid name: ");
                string Name = Console.ReadLine();

                if (IsName(Name))
                {
                    Console.WriteLine("Your name is valid!");
                    NameSuccess = false;
                }
                else
                {
                    Console.WriteLine("Sorry, your name is not valid");
                }
            }
            bool EmailSuccess = true;
            while (EmailSuccess)
            {
                Console.WriteLine("Please enter a valid email: ");
                string Email = Console.ReadLine();

                if (IsEmail(Email))
                {
                    Console.WriteLine("Your email is valid!");
                    EmailSuccess = false;
                }
                else
                {
                    Console.WriteLine("Sorry, your email is not valid!");
                }
            }
            bool PhoneSuccess = true;
            while (PhoneSuccess)
            {
                Console.WriteLine("Please enter a valid phone number: ");
                string Phone = Console.ReadLine();

                if (IsPhone(Phone))
                {
                    Console.WriteLine("Your phone number is valid!");
                    PhoneSuccess = false;
                }
                else
                {
                    Console.WriteLine("Sorry, your phone number is not valid");
                }
            }
            bool DateSuccess = true;
            while (DateSuccess)
            {
                Console.WriteLine("Please enter a valid date: ");
                string Date = Console.ReadLine();

                if (IsDate(Date))
                {
                    Console.WriteLine("Your date is valid!");
                    DateSuccess = false;
                }
                else
                {
                    Console.WriteLine("Sorry, your date is invalid");
                }
            }
        }
        static bool IsName(string input)
        {
            return Regex.IsMatch(input, @"[A-Z]\w{0,29}");
        }
        static bool IsEmail(string input)
        {
            return Regex.IsMatch(input, @"(\w{5,30})@(\w{5,10}).([A-Za-z]{2,3})");
        }
        static bool IsPhone(string input)
        {
            return Regex.IsMatch(input, @"^\d{3}[-]\d{3}[-]\d{4}$");
        }
        static bool IsDate(string input)
        {
            return Regex.IsMatch(input, @"^\d{2}[/]\d{2}[/]\d{4}$");
        }
    }
}
