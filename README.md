> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

**Disclaimer:** This code is deliberately contrived to demonstrate mutation testing. Special cases, such as Unicode text handling and stack overflows from deep recursion, are intentionally excluded from the tests to keep the examples easy to understand.

## Step 4

Looking at the results in `artifacts/stryker/reports/mutation-report.html` in a browser that you still have open from Step 3, you will find that not all mutations were killed by tests. We are not adequately testing `word.Length < 2`. We have already tested the lower end of the boundary condition by passing an empty string (of length 0), and a word with one character ("a"). Then we have additional tests that test with longer words, but none that test words that are exactly 2 characters long.

We can remedy that by testing words **at** the boundary - those that are two characters long. Let us add tests for "oo" and "ah", where one word is a palindrome, and the other one is not. Take a look at [`BetterPalindromeTest.cs`](TestPalindrome/BetterPalindromeTest.cs).

With the .NET 10 SDK and ReportGenerator from Step 2 installed, run the following in PowerShell from the repository root. Clear only the previous test results and coverage report, leaving mutation reports untouched. This runs all nine tests and generates the coverage report:

```powershell
foreach ($directory in 'artifacts\TestResults', 'artifacts\coverage') {
  if (Test-Path -LiteralPath $directory) {
    Remove-Item -LiteralPath $directory -Recurse -Force -ErrorAction Stop
  }
}
dotnet test `
  Palindrome.sln `
  --collect:"XPlat Code Coverage" `
  --results-directory artifacts\TestResults
reportgenerator `
  "-reports:artifacts\TestResults\*\coverage.cobertura.xml" `
  "-targetdir:artifacts\coverage" `
  "-reporttypes:Html"
```

All nine tests pass. Open `artifacts/coverage/index.html` in a browser to see 100% line and branch coverage.

Using Stryker.NET 5.1.0 installed in Step 3, clear only the previous mutation results and run it again, leaving the coverage report untouched. On Windows ARM64 only, first run `$env:PlatformTarget = 'ARM64'` in the same PowerShell session. On macOS or Linux, use PowerShell and `/` instead of `\` in the command paths.

```powershell
if (Test-Path -LiteralPath 'artifacts\stryker') {
  Remove-Item -LiteralPath 'artifacts\stryker' -Recurse -Force -ErrorAction Stop
}
dotnet stryker `
  --solution Palindrome.sln `
  --output artifacts\stryker
```

Open this branch's `artifacts/stryker/reports/mutation-report.html` in a browser. All ten tested mutants are killed, and the mutation score is 100%. This means the tests catch all mutations tested in this run, not that they prove the absence of every possible bug.

Hopefully, this tutorial gave you an idea of how you can write well-constructed unit tests that will save you from bugs as you evolve your code base.
