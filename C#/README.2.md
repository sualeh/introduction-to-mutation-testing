> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

## Step 1

The `step1` branch is the same starting point as `main`, but it lets you stay on numbered branches for the full walkthrough. Begin by showing the single NUnit test in [`PalindromeTest.cs`](https://github.com/sualeh/introduction-to-mutation-testing/blob/step1/C%23/TestPalindrome/PalindromeTest.cs). It checks one simple happy path: `"noon"` should be a palindrome.

Now show the unfinished implementation in [`Palindrome.cs`](https://github.com/sualeh/introduction-to-mutation-testing/blob/step1/C%23/Palindrome/Palindrome.cs). The method still throws `NotImplementedException`, so the test is expected to fail.

From the `C#` directory, run:

```sh
dotnet test Palindrome.sln
```

For the demo, point out that this is a good test-driven starting point: one clear test, one obvious failure, and a tiny amount of code to discuss.

## Move to Step 2

In order to move to Step 2, switch to git branch `step2` by running `git switch step2`. Then follow the instructions in `README.3.md`.
