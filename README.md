# Introduction to Mutation Testing

**Disclaimer:** This code is deliberately contrived to demonstrate mutation testing. Special cases, such as Unicode text handling and stack overflows from deep recursion, are intentionally excluded from the tests to keep the examples easy to understand.

With JDK 25 installed, run Maven commands from the repository root using the wrapper. On Windows, use `.\mvnw.cmd` instead of `./mvnw`.

## Step 2

In Step 2, we have implemented the palindrome function. Please take a look at [`Palindrome.java`](src/main/java/us/fatehi/palindrome/Palindrome.java). Run this from the repository root, and all the tests will pass.

```shell
./mvnw clean test
```

In fact, we have done a pretty good job of covering edge cases, and so let us confirm that we have 100% test coverage. Open up the test coverage report, which is in `./target/site/jacoco/index.html`, in a browser, and you will see that we have covered all the code.

However, do you notice a problem? The test coverage report shows some missed logic branches. If you dig deeper, you will find we have not covered the full truth table for `&&` on line #18. It is time to add some more tests.

## Move to Step 3

In order to move to Step 3, switch to git branch "java/step3" by running `git switch java/step3`. Then follow instructions in the README.
