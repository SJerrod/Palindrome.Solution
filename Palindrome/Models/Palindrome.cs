namespace Palindrome
{
    public class PalindromeCheck
    {
        public bool IsPalindrome(string query)
        {
            if (query is string) 
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