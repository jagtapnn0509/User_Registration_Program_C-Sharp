﻿using System;
using System.Text.RegularExpressions;

namespace User_Registration_Program
{
    class Program
    {
        public void Valid_FirstName()
        {
            Patterns pattern = new Patterns();
            Console.Write("Enter The First Name : ");
            String First_Name = (Console.ReadLine());
            Boolean Regex_Name = pattern.Check_FirstName(First_Name);
           
            if(Regex_Name)
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
            Console.WriteLine("----------------------------------------------------");
        }
        public void valid_LastName()
        {
            Patterns pattern = new Patterns();
            Console.Write("Enter The Last Name : ");
            String Last_Name = (Console.ReadLine());
            Boolean Regex_Name = pattern.Check_LastName(Last_Name);

            if (Regex_Name)
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Last Name is Invalid");
            }
            Console.WriteLine("----------------------------------------------------");
        }
        public void valid_Email()
        {
            Patterns pattern = new Patterns();
            Console.Write("Enter The Email ID : ");
            String Email = (Console.ReadLine());
            Boolean Regex_Name = pattern.Check_Email(Email);

            if (Regex_Name)
            {
                Console.WriteLine("Email id is valid");
            }
            else
            {
                Console.WriteLine("Email id is Invalid");
            }
            Console.WriteLine("----------------------------------------------------");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            Console.WriteLine("----------------------------------------------------");
            Program program = new Program();
            program.Valid_FirstName();
            program.valid_LastName();
            program.valid_Email();
        }
    }
}
