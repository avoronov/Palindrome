using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    internal class Program
    {
        private static bool debug = true;

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter line, please (or 'quit' for exit)");
                var raw_str = Console.ReadLine();

                _log("Raw string is '" + raw_str + "'");

                if (raw_str.Equals("quit")) break;

                var str = Regex.Replace(raw_str.ToLower(), "[^a-za-я]", String.Empty);

                _log("Sanitized string is '" + str + "'");

                if (isPalindrome(str))
                {
                    Console.WriteLine(String.Format("String '{0}' is a palindrome", str));
                }
                else
                {
                    Console.WriteLine(String.Format("String '{0}' is not a palindrome", str));
                }
            }
        }

        private static bool isPalindrome(string str)
        {
            if (str.Length < 1) return false;

            var i = 0;
            var j = str.Length - 1;
            while (i <= j)
            {
                _log("str[" + j + "] = " + str[j]);
                _log("str[" + i + "] = " + str[i]);

                if (str[i] != str[j]) return false;

                i++;
                j--;
            }
            return true;
        }

        private static void _log(string str)
        {
            if (debug) Console.WriteLine("DEBUG: " + str);
        }
    }
}