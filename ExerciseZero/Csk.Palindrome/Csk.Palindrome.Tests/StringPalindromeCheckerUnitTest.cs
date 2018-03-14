using System;
using Xunit;

namespace Csk.Palindrome.Tests
{
    public class StringPalindromeCheckerUnitTest
    {
        [Fact]
        public void PalindromeChecker_OneCharacterString()
        {
            var checker = new StringPalindromeChecker();

            var result = checker.IsPalindrome("a");
            Assert.True(result);
        }
    }
}
