namespace us.fatehi.palindrome
{
    public class Palindrome
    {
        public bool IsPalindrome(string word)
        {
            // Exit early for trivial cases, such as null,
            // empty string, and a word with a single letter
            if (word == null || word.Length < 2)
            {
                return true;
            }

            var firstChar = word[0];
            var lastChar = word[^1];
            var center = word[1..^1];
            return (firstChar == lastChar) && IsPalindrome(center);
        }
    }
}
