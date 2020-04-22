using System;

namespace PalindromeExercise
{
    public class Palindrome
    {
        public bool IsAPalindrome(string str1)
        {
            string str2;
            char[] ch = str1.ToCharArray();

            Array.Reverse(ch);
            str2 = new string (ch);

            bool b = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
            if(b == true)
            {
                 return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
