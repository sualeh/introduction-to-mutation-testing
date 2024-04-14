> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

## Step 2

In Step 2, we have implemented the palindrome function. Please take a look at [`Palindrome.java`](https://github.com/sualeh/introduction-to-mutation-testing/blob/step2/src/main/java/us/fatehi/palindrome/Palindrome.java). Now if you run with `mvn clean test`, all the tests will pass. 

In fact, we have done a pretty good job of covering edge cases, and so let us confirm that we have 100% test coverage. Open up the test coverage report, which is in `./target/site/jacoco/index.html`, in a browser, and you will see that we have covered all the code.

However, do you notice a problem? The test coverage report shows some missed logic branches. If you dig deeper, you will find we have not covered the full truth table for `&&` on line #18. It is time to add some more tests.

## Move to Step 3

In order to move to Step 3, switch to git branch "step3" by running `git switch step3`. Then follow instructions in the README.
