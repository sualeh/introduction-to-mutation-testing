# Introduction to Mutation Testing

**Disclaimer:** This code is deliberately contrived to demonstrate mutation testing. Special cases, such as Unicode text handling and stack overflows from deep recursion, are intentionally excluded from the tests to keep the examples easy to understand.

## Starting Point

Let us start by writing a simple palindrome test. A palindrome is a word or sentence that reads the same backwards and forwards, for example, "noon". Let us do test driven development, and follow industry best practices.

We will start by writing the unit test first. Please take a look at [`PalindromeTest.cs`](TestPalindrome/PalindromeTest.cs). On the dotnet/main branch, there is a single happy path test for "noon". The dotnet/step1 branch adds tests for edge cases.

With the .NET 10 SDK installed, run this from the repository root. You will notice that the test fails with `NotImplementedException` because the code has not been implemented yet. In Step 1, we will add the edge-case tests before implementing the code in Step 2.

Before every run, clear the previous test results in `artifacts/TestResults`. Other reports are left untouched.

```powershell
if (Test-Path -LiteralPath 'artifacts\TestResults') {
  Remove-Item -LiteralPath 'artifacts\TestResults' -Recurse -Force -ErrorAction Stop
}
dotnet test Palindrome.sln --results-directory artifacts\TestResults
```

## Move to Step 1

In order to move to Step 1, switch to git branch "dotnet/step1" by running `git switch dotnet/step1`, or open its worktree if it is already checked out there. Then follow instructions in the README.
