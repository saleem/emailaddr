using System;
using System.Text.RegularExpressions;

namespace emailaddr
{
    public class EmailValidator
    {
        public Boolean IsValid(String str) 
        {
            string local = "([a-z]|[A-Z]|[0-9]|[!#$%&'*+\\-/=?^_`{\\|}~])*";
            string domain = "([a-z]|[A-Z]|[0-9]|\\-)*";
            string suffix = "([a-z]|[A-Z]|[0-9])*";

            string pattern = $"{local}@{domain}\\.{suffix}";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(str);
        }
    }
}