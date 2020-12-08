using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
    [TestClass]
    public class  PalindromeCheckTests
    {
        [TestMethod]
        public void IsPalindrome_ReturnsString_True()
        {
            PalindromeCheck testCase = new PalindromeCheck();
            Assert.AreEqual(true, testCase.IsPalindrome("abcde"));
        }
    }
}