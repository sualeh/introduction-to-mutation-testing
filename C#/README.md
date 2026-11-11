> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

**Disclaimer:** This code is deliberately contrived to demonstrate mutation testing. Special cases, such as Unicode text handling and stack overflows from deep recursion, are intentionally excluded from the tests to keep the examples easy to understand.

## Step 1

Let us start by writing a simple palindrome test. A palindrome is a word or sentence that reads the same backwards and forwards, for example, "noon". Let us do test driven development, and follow industry best practices. 

We will start by writing the unit tests first. Please take a look at [`PalindromeTest.cs`](TestPalindrome/PalindromeTest.cs). There are tests for edge cases, and we consider *null* to be a palindrome for this purpose. There are edge condition tests for an empty string, and a word with a single letter. There are happy path tests for "noon" and "racecar", and a negative test for "burning" which is not a palindrome.

With the .NET 10 SDK installed, run this from the `C#` directory. You will notice that all six tests fail with `NotImplementedException` because the code has not been implemented yet. In the next step, we will implement the code, and get the tests to pass.

Before every run, clear the previous test results in `artifacts/TestResults`. Other reports are left untouched.

```powershell
if (Test-Path -LiteralPath 'artifacts\TestResults') {
  Remove-Item -LiteralPath 'artifacts\TestResults' -Recurse -Force -ErrorAction Stop
}
dotnet test Palindrome.sln --results-directory artifacts\TestResults
```

## Move to Step 2

In order to move to Step 2, switch to git branch "step2" by running `git switch step2`, or open its worktree if it is already checked out there. Then follow instructions in the C# README.
