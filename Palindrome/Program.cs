using System;
using Palindrome.Models;

namespace Palindrome
{
    public class Program
    {
      public static void Main()
      {
        Console.WriteLine("Enter a text to see if its a palindrome.");
        PalindromeCheck yourCheck = new PalindromeCheck();
        string yourText = Console.ReadLine();
        Console.WriteLine(yourCheck.IsPalindrome(yourText));
      }
    }
}