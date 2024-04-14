using NUnit.Framework;
using us.fatehi.palindrome;

namespace us.fatehi.palindrome.test
{

    [TestFixture]
    public class PalindromeTests
    {
        private readonly Palindrome _p = new Palindrome();

        [Test]
        public void HappyPath()
        {
            Assert.That(_p.IsPalindrome("noon"));
        }
    }
}
