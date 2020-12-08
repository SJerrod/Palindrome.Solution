using System;

namespace Palindrome
{
    public class PalindromeCheck
    {
        public bool IsPalindrome(string query)
        {
            if (query is string) 
            {
                if (query == query.FlipString())
                {
                    return true;
                }
            }
            else 
            {
                return false;
            }
        }

        public string FlipString(string query)
        {
            char[] charArray = query.ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }
    }
}