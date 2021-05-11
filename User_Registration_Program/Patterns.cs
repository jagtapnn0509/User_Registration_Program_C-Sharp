using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Program
{
    class Patterns
    {
        public bool Check_FirstName(String First_Name)
        {
            String Pattern_Name = "^[A-Z]{1}[a-z]{2,}";
            return Regex.IsMatch(First_Name, Pattern_Name);
        }

        public bool Check_LastName(String Last_Name)
        {
            String Pattern_Name = "^[A-Z]{1}[a-z]{2,}";
            return Regex.IsMatch(Last_Name, Pattern_Name);
        }
        public bool Check_Email(String Email)
        {
            String Pattern_Name = "^([A-Za-z0-9]+([._+-]?[A-Za-z0-9]?)*[A-Za-z0-9]?)@(([A-Za-z0-9]+)([.-_]?([A-Za-z0-9]+)+)*)+.([A-Za-z]{2,})+$";
            return Regex.IsMatch(Email, Pattern_Name);
        }
    }
}
