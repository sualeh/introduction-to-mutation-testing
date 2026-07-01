> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

## Step 2

In Step 2, the palindrome implementation is in place in [`Palindrome.cs`](https://github.com/sualeh/introduction-to-mutation-testing/blob/step2/C%23/Palindrome/Palindrome.cs), and the NUnit test suite in [`PalindromeTest.cs`](https://github.com/sualeh/introduction-to-mutation-testing/blob/step2/C%23/TestPalindrome/PalindromeTest.cs) now covers null input, empty strings, one-letter words, and both positive and negative examples.

From the `C#` directory, run:

```sh
dotnet test Palindrome.sln
```

All the tests should pass.

Next, generate a coverage report so that you can show the audience why line coverage is helpful, but not sufficient. If you do not already have ReportGenerator installed, install it once:

```sh
dotnet tool install --global dotnet-reportgenerator-globaltool
dotnet test Palindrome.sln --collect:"XPlat Code Coverage"
reportgenerator -reports:"TestPalindrome/TestResults/*/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```

Now open `./coveragereport/index.html` in a browser.

The report shows the code is well covered, but there is still a missing branch in the recursive return:

```csharp
return (firstChar == lastChar) && IsPalindrome(center);
```

At this point in the demo, explain that we already test the cases where the first and last letters do not match, and where the whole word is a palindrome. What we do not yet test is the case where the outer letters match, but the inner substring is not a palindrome.

## Move to Step 3

In order to move to Step 3, switch to git branch `step3` by running `git switch step3`. Then follow the instructions in `README.4.md`.
