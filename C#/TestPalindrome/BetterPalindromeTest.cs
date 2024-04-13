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
            Assert.IsTrue(_p.IsPalindrome("oo"));
        }

        [Test]
        public void BoundaryConditionNegative()
        {
            Assert.IsFalse(_p.IsPalindrome("ah"));
        }
    }
}