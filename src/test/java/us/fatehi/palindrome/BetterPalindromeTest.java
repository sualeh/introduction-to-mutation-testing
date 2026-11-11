package us.fatehi.palindrome;


import static org.junit.jupiter.api.Assertions.assertFalse;
import static org.junit.jupiter.api.Assertions.assertTrue;

import org.junit.jupiter.api.Test;

public class BetterPalindromeTest
{

  private final Palindrome p = new Palindrome();

  @Test
  public void boundaryConditionHappy()
  {
    assertTrue(p.isPalindrome("oo"));
  }

  @Test
  public void boundaryConditionNegative()
  {
    assertFalse(p.isPalindrome("ah"));
  }

}
