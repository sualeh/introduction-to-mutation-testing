# Introduction to Mutation Testing

**Disclaimer:** This code is deliberately contrived to demonstrate mutation testing. Special cases, such as Unicode text handling and stack overflows from deep recursion, are intentionally excluded from the tests to keep the examples easy to understand.

With JDK 25 installed, run Maven commands from the repository root using the wrapper. On Windows, use `.\mvnw.cmd` instead of `./mvnw`.

## Step 3

In Step 3, we have added a test for the missing branch. The missing case is where `(firstChar == lastChar) && isPalindrome(center)` is `true && false`: the first and last characters match, but the middle is not a palindrome. An example word is "streets". Please take a look at the new test [`MorePalindromeTest.java`](src/test/java/us/fatehi/palindrome/MorePalindromeTest.java).

Run this from the repository root, and all the tests will pass, including the new one. Not only that, the coverage report is clean. If you open up the test coverage report, which is in `./target/site/jacoco/index.html`, in a browser, and you will see that we have covered all the code, including missed branches.

```shell
./mvnw clean test
```

So, we are done? Not so fast! This is where mutation testing comes in to show us if our tests are adequate. A mutation testing tool like [PIT](https://pitest.org/) will introduce random bugs in our code, and see if our tests catch them. The bugs are called mutations, and if the tests fail, the tests are successful in catching the bug, and so the mutation is killed. However, if the tests pass, it means that the mutation is not tested, and the mutation survives (which is not a good thing).

Let us run PIT, and check the results. Run this from the repository root. Then open the results in `./target/pit-reports/index.html` in a browser. PIT shows 100% test coverage, but only 89% mutation test coverage. Let us explore and fix this.

```shell
./mvnw clean test org.pitest:pitest-maven:mutationCoverage
```

If you dig further, you will find that not all mutations were killed by tests. We are clearly missing a test condition. If you look at the report for line #9, you will see that when the conditional boundary was changed, no tests failed.

Leave your browser with the mutation testing results up, and move to Step 4.

## Move to Step 4

In order to move to Step 4, switch to git branch "java/step4" by running `git switch java/step4`. Then follow instructions in the README.
