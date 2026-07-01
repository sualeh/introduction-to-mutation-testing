> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

## Step 4

Step 4 closes the last mutation testing gap by adding two boundary tests in [`BetterPalindromeTest.cs`](https://github.com/sualeh/introduction-to-mutation-testing/blob/step4/C%23/TestPalindrome/BetterPalindromeTest.cs):

- `"oo"` should be a palindrome
- `"ah"` should not be a palindrome

These are the exact two-character cases that were missing from the earlier branches.

From the `C#` directory, run:

```sh
dotnet test Palindrome.sln
cd TestPalindrome
dotnet-stryker --solution ../Palindrome.sln -O ../StrykerOutput
```

Now open `../StrykerOutput/reports/mutation-report.html` in a browser again. This time every mutant should be killed, and the mutation score should be 100%.

That gives you a clean ending for the demo: ordinary tests caught the obvious bugs, coverage highlighted a missing path, and mutation testing exposed one last weak spot at the boundary.
