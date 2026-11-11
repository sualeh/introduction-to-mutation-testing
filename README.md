# Introduction to Mutation Testing

**Disclaimer:** This code is deliberately contrived to demonstrate mutation testing. Special cases, such as Unicode text handling and stack overflows from deep recursion, are intentionally excluded from the tests to keep the examples easy to understand.

With JDK 25 installed, run Maven commands from the repository root using the wrapper. On Windows, use `.\mvnw.cmd` instead of `./mvnw`.

## Starting Point

Let us start by writing a simple palindrome test. A palindrome is a word or sentence that reads the same backwards and forwards, for example, "noon". Let us do test driven development, and follow industry best practices.

We will start by writing the unit test first. Please take a look at [`PalindromeTest.java`](src/test/java/us/fatehi/palindrome/PalindromeTest.java). On `java/main`, there is a single happy path test for "noon". The `java/step1` branch adds tests for edge cases.

Run the test with Maven. It fails because the code has not been implemented yet. In Step 1, we will add the edge-case tests before implementing the code in Step 2.

```shell
./mvnw clean test
```

## Move to Step 1

In order to move to Step 1, switch to git branch "java/step1" by running `git switch java/step1`. Then follow instructions in the README.
