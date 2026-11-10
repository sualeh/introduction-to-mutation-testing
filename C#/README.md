> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

## Step 2

In Step 2, we have implemented the palindrome function. Please take a look at [`Palindrome.cs`](Palindrome/Palindrome.cs). With the .NET 10 SDK installed, run `dotnet test Palindrome.sln` from the `C#` directory. All six tests will pass.

In fact, we have done a pretty good job of covering edge cases, and so let us check our test coverage. If ReportGenerator is not already installed, install it once with `dotnet tool install --global dotnet-reportgenerator-globaltool --version 5.6.0`. From the `C#` directory, collect coverage with Coverlet and generate an HTML report:

```powershell
dotnet test Palindrome.sln --collect:"XPlat Code Coverage" --results-directory target\TestResults
reportgenerator "-reports:target\TestResults\*\coverage.cobertura.xml" "-targetdir:target\coverage" "-reporttypes:Html"
```

Open `target/coverage/index.html` in a browser. Coverlet reports 100% line and branch coverage, unlike the Java coverage report at this step. On macOS or Linux, use `/` instead of `\` in the command paths.

However, do you notice a problem? We have not covered the full truth table for `(firstChar == lastChar) && IsPalindrome(center)`. We are missing the case where the outer letters match, but the middle is not a palindrome: `true && false`. The coverage percentage does not reveal this gap. It is time to add another test.

## Move to Step 3

In order to move to Step 3, switch to git branch "step3" by running `git switch step3`, or open its worktree if it is already checked out there. Then follow instructions in the C# README.
