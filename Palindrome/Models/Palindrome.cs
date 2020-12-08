using System;

namespace Palindrome
{
    public class PalindromeCheck
    {
        public bool IsPalindrome(string query)
        {
            if (query is string) 
            {
                string flippedQuery = FlipString(query);
                if (query == flippedQuery)
                {
                    return true;
                }
                return false;
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

        public string FlipStringHardMode(string query)
        {
            char[] stringQuery = query.ToCharArray();
            string reverse = String.Empty;
            
            for (int i = stringQuery.Length - 1; i >= 0; i--)
            {
                reverse += stringQuery[i];
            }

            return reverse;
        }
    }
}