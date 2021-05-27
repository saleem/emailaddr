using System;
using System.Text.RegularExpressions;

namespace emailaddr
{
    public class EmailValidator
    {
        public Boolean IsValid(String str) 
        {
            string local = "([a-z]|[A-Z]|[0-9]|[!#$%&'\\*\\+\\-/=?\\^_`{\\|}~])*";
            string sep1 = "@{1}";
            string domain = "([a-z]|[A-Z]|[0-9]|\\-)*";
            string sep2 = "\\.{1}";
            string suffix = "([a-z]|[A-Z]|[0-9])*";

            string pattern = $"{local}{sep1}{domain}{sep2}{suffix}"; 

            Regex regex = new Regex(pattern);

            return regex.IsMatch(str);
        }
    }
}