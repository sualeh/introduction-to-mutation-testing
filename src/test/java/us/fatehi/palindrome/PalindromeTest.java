package us.fatehi.palindrome;


import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

import org.junit.jupiter.api.Test;

public class PalindromeTest
{

  private final Palindrome p = new Palindrome();

  @Test
  public void happyPath()
  {
    assertTrue(p.isPalindrome("noon"));
  }

}
