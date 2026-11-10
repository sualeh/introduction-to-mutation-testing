> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

## Step 3

In Step 3, we have added an additional test for the missing truth-table case. The missing case is where `(firstChar == lastChar) && IsPalindrome(center)` is `true && false`: the first and last characters match, but the middle is not a palindrome. An example word is "polyp", whose middle is "oly". Please take a look at the new test [`MorePalindromeTest.cs`](TestPalindrome/MorePalindromeTest.cs).

With the .NET 10 SDK installed, run `dotnet test Palindrome.sln` from the `C#` directory. All seven tests will pass, including the new one. To regenerate the coverage report, use ReportGenerator installed in Step 2:

```powershell
dotnet test Palindrome.sln --collect:"XPlat Code Coverage" --results-directory target\TestResults
reportgenerator "-reports:target\TestResults\*\coverage.cobertura.xml" "-targetdir:target\coverage" "-reporttypes:Html"
```

Open `target/coverage/index.html` in a browser. Coverlet still reports 100% line and branch coverage; it already reported those percentages in Step 2.

So, we are done? Not so fast! This is where mutation testing comes in to show us if our tests are adequate. A mutation testing tool like [Stryker.NET](https://stryker-mutator.io/docs/stryker-net/introduction/) will introduce bugs in our code, and see if our tests catch them. The bugs are called mutations, and if the tests fail, the tests are successful in catching the bug, and so the mutation is killed. However, if the tests pass, the mutation survives (which is not a good thing).

If Stryker.NET is not already installed, install it once with `dotnet tool install --global dotnet-stryker --version 5.1.0`. On Windows ARM64, first run `$env:PlatformTarget = 'ARM64'` in the same PowerShell session to avoid Stryker requesting an x64 test host. This setting is not needed on x64 machines. From the `C#` directory, run `dotnet stryker --solution Palindrome.sln --output target\stryker`. On macOS or Linux, use `/` instead of `\` in the command paths.

Open `target/stryker/reports/mutation-report.html` in a browser. Stryker.NET 5.1.0 tests eight mutants, kills seven, and reports a mutation score of 87.5%. Let us explore and fix this.

If you dig further, you will find that not all mutations were killed by tests. We are clearly missing a test condition. When `word.Length < 2` is changed to `word.Length <= 2`, no tests fail. We have not tested the exact boundary at length 2.

Leave your browser with the mutation testing results up, and move to Step 4.

## Move to Step 4

In order to move to Step 4, switch to git branch "step4" by running `git switch step4`, or open its worktree if it is already checked out there. Then follow instructions in the C# README.
