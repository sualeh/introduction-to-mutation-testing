package us.fatehi.palindrome;


import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

import org.junit.jupiter.api.Test;

public class PalindromeTest
{

  private final Palindrome p = new Palindrome();

  @Test
  public void edgeCaseNull()
  {
    assertTrue(p.isPalindrome(null));
  }

  @Test
  public void edgeCaseEmptyString()
  {
    assertTrue(p.isPalindrome(""));
  }

  @Test
  public void happyPathSingleLetter()
  {
    assertTrue(p.isPalindrome("a"));
  }

  @Test
  public void happyPathEvenLetters()
  {
    assertTrue(p.isPalindrome("noon"));
  }

  @Test
  public void happyPathOddLetters()
  {
    assertTrue(p.isPalindrome("racecar"));
  }

  @Test
  public void negativeCase()
  {
    assertFalse(p.isPalindrome("burning"));
  }

}
