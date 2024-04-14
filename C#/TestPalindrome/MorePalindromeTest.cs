using NUnit.Framework;
using us.fatehi.palindrome;

namespace us.fatehi.palindrome.test
{

    [TestFixture]
    public class MorePalindromeTest
    {
        private readonly Palindrome _p = new Palindrome();

        [Test]
        public void AlmostPalindrome()
        {
            Assert.That(_p.IsPalindrome("polyp"), Is.False);
        }
    }
}