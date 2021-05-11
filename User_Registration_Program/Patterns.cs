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
            String pattern_Name = "^[A-Z]{1}[a-z]{2,}";
            return Regex.IsMatch(First_Name, pattern_Name);
        }
    }
}
