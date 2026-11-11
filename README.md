# Introduction to Mutation Testing

**Disclaimer:** This code is deliberately contrived to demonstrate mutation testing. Special cases, such as Unicode text handling and stack overflows from deep recursion, are intentionally excluded from the tests to keep the examples easy to understand.

With JDK 25 installed, run Maven commands from the repository root using the wrapper. On Windows, use `.\mvnw.cmd` instead of `./mvnw`.

## Step 4

Looking at the results in `./target/pit-reports/index.html` in a browser that you still have open from Step 3, you will find that not all mutations were killed by tests. We are not adequately testing `word.length() < 2`. We have already tested the lower end of the boundary condition by passing an empty string (of length 0), and a word with one character ("a"). Then we have additional tests that test with longer words, but none that  test words that are exactly 2 characters long.

We can remedy that by testing words **at** the boundary - those that are two characters long. Let us add tests for "oo" and "ah", where one word is a palindrome, and the other one is not. Take a look at [BetterPalindromeTest.java](src/test/java/us/fatehi/palindrome/BetterPalindromeTest.java).

Run PIT again from the repository root, and look at the results in `./target/pit-reports/index.html` in a browser. All tested mutants are killed. This does not prove the absence of every possible bug.

```shell
./mvnw clean test org.pitest:pitest-maven:mutationCoverage
```

Hopefully, this tutorial gave you an idea of how you can write well-constructed unit tests that will save you from bugs as you evolve your code base.
