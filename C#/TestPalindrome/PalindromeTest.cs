using NUnit.Framework;
using us.fatehi.palindrome;

namespace us.fatehi.palindrome.test
{

    [TestFixture]
    public class PalindromeTest
    {
        private readonly Palindrome _p = new Palindrome();

        [Test]
        public void EdgeCaseNull()
        {
            Assert.That(_p.IsPalindrome(null));
        }

        [Test]
        public void EdgeCaseEmptyString()
        {
            Assert.That(_p.IsPalindrome(""));
        }

        [Test]
        public void HappyPathSingleLetter()
        {
            Assert.That(_p.IsPalindrome("a"));
        }

        [Test]
        public void HappyPathEvenLetters()
        {
            Assert.That(_p.IsPalindrome("noon"));
        }

        [Test]
        public void HappyPathOddLetters()
        {
            Assert.That(_p.IsPalindrome("racecar"));
        }

        [Test]
        public void NegativeCase()
        {
            Assert.That(_p.IsPalindrome("burning"), Is.False);
        }
    }
}