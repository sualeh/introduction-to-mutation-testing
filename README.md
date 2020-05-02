# Introduction to Mutation Testing

## Step 1

Let us start by writing a simple palindrome test. A palindrome is a word or sentence that reads the same backawards and forwards, for example, "noon". Let us do test driven development, and follow industry best practices. 

We will start by writing the unit tests first. Please take a look at [`PalindromeTest.java`](https://github.com/sualeh/introduction-to-mutation-testing/blob/master/src/test/java/us/fatehi/palindrome/PalindromeTest.java). There are tests for edge cases, and we consider null to be a palindrome for this purpose. There are edge condition tests for an empty string, and a word with a single letter. There is a happy path test for "noon", and a negative test for "morning" which is not a palindrome.

Download the code, and run it with `mvn clean test`. You will notice that all our tests are failing because the code has not been implemented yet. In the next step, we will implement the code, and get the tests to pass.

## Move to Step 2

In order to move to Step 2, checkout git branch `step2` by running `git checkout step2`.
