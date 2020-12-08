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

        [TestMethod]
        public void FlipString_ReverseString_string()
        {
            PalindromeCheck testReverse = new PalindromeCheck();
            Assert.AreEqual("edcba", testReverse.FlipString("abcde"));
        }

        [TestMethod]
        public void IsPalindrome_OriginalStringEqualFlippedString_True()
        {
            PalindromeCheck testcase = new PalindromeCheck();
            Assert.AreEqual(true, testcase.IsPalindrome("tacocat"));
        }
    }
}