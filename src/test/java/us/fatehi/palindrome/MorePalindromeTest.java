package us.fatehi.palindrome;

import static org.junit.jupiter.api.Assertions.assertFalse;

import org.junit.jupiter.api.Test;

public class MorePalindromeTest {

  private final Palindrome p = new Palindrome();

  @Test
  public void almostPalindrome() {
    assertFalse(p.isPalindrome("polyp"));
  }

}
