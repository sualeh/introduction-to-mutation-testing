> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

**Disclaimer:** This code is deliberately contrived to demonstrate mutation testing. Special cases, such as Unicode text handling and stack overflows from deep recursion, are intentionally excluded from the tests to keep the examples easy to understand.

## Step 2

In Step 2, we have implemented the palindrome function. Please take a look at [`Palindrome.cs`](Palindrome/Palindrome.cs). Let us run the tests and check our coverage at the same time.

With the .NET 10 SDK installed, install ReportGenerator once if it is not already installed:

```powershell
dotnet tool install --global dotnet-reportgenerator-globaltool --version 5.6.0
```

From the repository root, run the following in PowerShell. Clear only the previous test results and coverage report before every run, leaving mutation reports untouched. All six tests will pass, and the same test run collects coverage:

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

Open `artifacts/coverage/index.html` in a browser. Coverlet shows incomplete line and branch coverage. On macOS or Linux, use PowerShell and `/` instead of `\` in the command paths.

If you dig deeper, you will find that the nested checks have not covered the case where the outer letters match, but the middle is not a palindrome: `true && false`. The inner `if (IsPalindrome(center))` has never taken its false branch. It is time to add another test.

## Move to Step 3

In order to move to Step 3, switch to git branch "dotnet/step3" by running `git switch dotnet/step3`, or open its worktree if it is already checked out there. Then follow instructions in the README.
