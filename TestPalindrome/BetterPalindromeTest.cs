using NUnit.Framework;
using us.fatehi.palindrome;

namespace us.fatehi.palindrome.test
{

    [TestFixture]
    public class BetterPalindromeTest
    {
        private readonly Palindrome _p = new Palindrome();

        [Test]
        public void BoundaryConditionHappy()
        {
            Assert.That(_p.IsPalindrome("oo"));
        }

        [Test]
        public void BoundaryConditionNegative()
        {
            Assert.That(_p.IsPalindrome("ah"), Is.False);
        }
    }
}