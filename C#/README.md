> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

## Step 4

Looking at the results in `target/stryker/reports/mutation-report.html` in a browser that you still have open from Step 3, you will find that not all mutations were killed by tests. We are not adequately testing `word.Length < 2`. We have already tested the lower end of the boundary condition by passing an empty string (of length 0), and a word with one character ("a"). Then we have additional tests that test with longer words, but none that test words that are exactly 2 characters long.

We can remedy that by testing words **at** the boundary - those that are two characters long. Let us add tests for "oo" and "ah", where one word is a palindrome, and the other one is not. Take a look at [`BetterPalindromeTest.cs`](TestPalindrome/BetterPalindromeTest.cs).

With the .NET 10 SDK and ReportGenerator from Step 2 installed, run the following in PowerShell from the `C#` directory. Clear the generated results in `target` before every run. This runs all nine tests and generates the coverage report:

```powershell
if (Test-Path -LiteralPath 'target') {
  Remove-Item -LiteralPath 'target' -Recurse -Force -ErrorAction Stop
}
dotnet test `
  Palindrome.sln `
  --collect:"XPlat Code Coverage" `
  --results-directory target\TestResults
reportgenerator `
  "-reports:target\TestResults\*\coverage.cobertura.xml" `
  "-targetdir:target\coverage" `
  "-reporttypes:Html"
```

All nine tests pass. Open `target/coverage/index.html` in a browser to see 100% line and branch coverage.

Using Stryker.NET 5.1.0 installed in Step 3, clear the previous mutation results and run it again. On Windows ARM64 only, first run `$env:PlatformTarget = 'ARM64'` in the same PowerShell session. On macOS or Linux, use PowerShell and `/` instead of `\` in the command paths.

```powershell
if (Test-Path -LiteralPath 'target\stryker') {
  Remove-Item -LiteralPath 'target\stryker' -Recurse -Force -ErrorAction Stop
}
dotnet stryker `
  --solution Palindrome.sln `
  --output target\stryker
```

Open this branch's `target/stryker/reports/mutation-report.html` in a browser. All ten tested mutants are killed, and the mutation score is 100%. This means the tests catch all mutations tested in this run, not that they prove the absence of every possible bug.

Hopefully, this tutorial gave you an idea of how you can write well-constructed unit tests that will save you from bugs as you evolve your code base.
