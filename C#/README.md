> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

## Step 4

Looking at the results in `target/stryker/reports/mutation-report.html` in a browser that you still have open from Step 3, you will find that not all mutations were killed by tests. We are not adequately testing `word.Length < 2`. We have already tested the lower end of the boundary condition by passing an empty string (of length 0), and a word with one character ("a"). Then we have additional tests that test with longer words, but none that test words that are exactly 2 characters long.

We can remedy that by testing words **at** the boundary - those that are two characters long. Let us add tests for "oo" and "ah", where one word is a palindrome, and the other one is not. Take a look at [`BetterPalindromeTest.cs`](TestPalindrome/BetterPalindromeTest.cs).

With the .NET 10 SDK installed, run this from the `C#` directory. All nine tests will pass.

```powershell
dotnet test Palindrome.sln
```

Using Stryker.NET 5.1.0 installed in Step 3, run this command. On Windows ARM64, first set `PlatformTarget` in the same PowerShell session. On macOS or Linux, use `/` instead of `\` in the command path.

```powershell
dotnet stryker `
  --solution Palindrome.sln `
  --output target\stryker
```

On Windows ARM64, run this in the same PowerShell session before running Stryker:

```powershell
$env:PlatformTarget = 'ARM64'
```

Open this branch's `target/stryker/reports/mutation-report.html` in a browser. All eight tested mutants are killed, and the mutation score is 100%. This means the tests catch all mutations tested in this run, not that they prove the absence of every possible bug.

Hopefully, this tutorial gave you an idea of how you can write well-constructed unit tests that will save you from bugs as you evolve your code base.
