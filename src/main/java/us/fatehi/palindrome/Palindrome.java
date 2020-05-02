package us.fatehi.palindrome;


public class Palindrome
{

  public boolean isPalindrome(final String word)
  {
    if (word == null || word.length() < 2)
    {
      return true;
    }
    else
    {
      final char firstChar = word.charAt(0);
      final char lastChar = word.charAt(word.length() - 1);
      final String center = word.substring(1, word.length() - 1);
      return (firstChar == lastChar) && isPalindrome(center);
    }
  }

}
