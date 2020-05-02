# Introduction to Mutation Testing

## Step 3

In Step 3, we have added an additional test to covert the missed logic branches. The missing case is `true && true` meaning that both the first and last characters of the word under test should match, but the next recursion of the function should also match the first and last characters. An example word is "streets", where "st" and "ts" are the reversals of each other. Please take a look at the new test [`MorePalindromeTest.java`](https://github.com/sualeh/introduction-to-mutation-testing/blob/step3/src/test/java/us/fatehi/palindrome/MorePalindromeTest.java). Now if you run with `mvn clean test`, all the tests will pass, including the new one. Not only that, the coverage report is clean. If you open up the test coverage report, which is in `./target/site/jacoco/index.html`, in a browser, and you will see that we have covered all the code, including missed branches.

So, we are done? Not so fast! This is where mutation testing comes in to show us if our tests are adequate. A mutation testing tool like [PIT](https://pitest.org/) will introduce random bugs in our code, and see if our tests catch them. The bugs are called mutations, and if the tests fail, the tests are successful in catching the bug, and so the mutation is killed. However, if the tests pass, it means that the mutation is not tested, and the mutation survives (which is not a good thing).

Let us run PIT, and check the results. Run `mvn clean test org.pitest:pitest-maven:mutationCoverage`. Then open the results in `./target/pit-reports/index.html` in a browser. PIT shows 100% test coverage, but only 89% mutation test coverage. Let us explore and fix this.

## Move to Step 4

In order to move to Step 4, checkout git branch `step4` by running `git checkout step4`.
