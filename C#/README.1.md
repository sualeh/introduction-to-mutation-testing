> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

## Main Branch

The `main` branch is the starting point for the C# demo. Begin by showing the single NUnit test in [`PalindromeTest.cs`](https://github.com/sualeh/introduction-to-mutation-testing/blob/main/C%23/TestPalindrome/PalindromeTest.cs). It checks one simple happy path: `"noon"` should be a palindrome.

Now show the unfinished implementation in [`Palindrome.cs`](https://github.com/sualeh/introduction-to-mutation-testing/blob/main/C%23/Palindrome/Palindrome.cs). The method still throws `NotImplementedException`, so the test is expected to fail.

From the `C#` directory, run:

```sh
dotnet test Palindrome.sln
```

For the demo, point out that this is a good test-driven starting point: one clear test, one obvious failure, and a tiny amount of code to discuss.

## Move to Step 1 or Step 2

If you want to stay on the numbered walkthrough, switch to git branch `step1` by running `git switch step1`, and then follow the instructions in `README.2.md`.

If you want to move straight to the next branch with new code, switch to git branch `step2` by running `git switch step2`, and then follow the instructions in `README.3.md`.
