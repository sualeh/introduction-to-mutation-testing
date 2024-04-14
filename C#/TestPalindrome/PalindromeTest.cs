using NUnit.Framework;
using us.fatehi.palindrome;

namespace us.fatehi.palindrome.test
{

    [TestFixture]
    public class PalindromeTests
    {
        private readonly Palindrome _p = new Palindrome();

        [Test]
        public void EdgeCaseNull()
        {
            Assert.IsTrue(_p.IsPalindrome(null));
        }

        [Test]
        public void EdgeCaseEmptyString()
        {
            Assert.IsTrue(_p.IsPalindrome(""));
        }

        [Test]
        public void HappyPathSingleLetter()
        {
            Assert.IsTrue(_p.IsPalindrome("a"));
        }

        [Test]
        public void HappyPathEvenLetters()
        {
            Assert.IsTrue(_p.IsPalindrome("noon"));
        }

        [Test]
        public void HappyPathOddLetters()
        {
            Assert.IsTrue(_p.IsPalindrome("racecar"));
        }

        [Test]
        public void NegativeCase()
        {
            Assert.IsFalse(_p.IsPalindrome("burning"));
        }
    }
}