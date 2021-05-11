using System;
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
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            Program program = new Program();
            program.Valid_FirstName();
           

           
        }
    }
}
