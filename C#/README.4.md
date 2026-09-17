> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

## Step 3

In Step 3, we add the missing short-circuit test in [`MorePalindromeTest.cs`](https://github.com/sualeh/introduction-to-mutation-testing/blob/step3/C%23/TestPalindrome/MorePalindromeTest.cs). The example word is `"polyp"`: the first and last letters match, but the middle of the word is not a palindrome.

From the `C#` directory, run:

```sh
dotnet test Palindrome.sln
```

All the tests should pass, including the new one.

Now move from line coverage to mutation testing. If you do not already have Stryker.NET installed, install it once:

```sh
dotnet tool install --global dotnet-stryker
cd TestPalindrome
dotnet-stryker --solution ../Palindrome.sln -O ../StrykerOutput
```

Open `../StrykerOutput/reports/mutation-report.html` in a browser.

This is the key teaching moment in the demo: even after we fixed the missing branch, one mutant still survives. The surviving mutation comes from the boundary condition `word.Length < 2`. We have tests for words of length 0 and 1, and tests for longer words, but we still do not test the exact boundary at length 2.

Leave the mutation report open, because Step 4 fixes that last gap.

## Move to Step 4

In order to move to Step 4, switch to git branch `step4` by running `git switch step4`. Then follow the instructions in `README.5.md`.
