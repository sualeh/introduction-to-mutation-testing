> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

> **Watch a [video of this tutorial on YouTube](https://youtu.be/1ljrGdXuv_g).**

How strong are your unit tests? Mutation testing introduces small changes to your code and checks whether the tests catch them. This tutorial follows a palindrome implementation through unit testing, code coverage, and mutation testing with [PIT](https://pitest.org/) for Java and [Stryker.NET](https://stryker-mutator.io/docs/stryker-net/introduction/) for C#.

**Disclaimer:** This code is deliberately contrived to demonstrate mutation testing. Special cases, such as Unicode text handling and stack overflows from deep recursion, are intentionally excluded from the tests to keep the examples easy to understand.

*Expected time to complete the tutorial: 30 minutes.*

## Slides

The `main` branch contains the [slide source](mutation-testing.md), not the example projects. View the [published slides](https://sualeh.github.io/introduction-to-mutation-testing/) or download the [PDF](https://sualeh.github.io/introduction-to-mutation-testing/mutation-testing.pdf).

## Choose a language

Clone the repository once, then switch between the branches for your chosen language. Each example branch has its project and step-specific README in the repository root; there are no `Java` or `C#` subdirectories.

```shell
git clone https://github.com/sualeh/introduction-to-mutation-testing.git
cd introduction-to-mutation-testing
```

| Tutorial stage | Java branch | C# branch | What to expect |
| --- | --- | --- | --- |
| Starting point | `java/main` | `dotnet/main` | One test and an unimplemented function; the test intentionally fails. |
| Step 1 | `java/step1` | `dotnet/step1` | Six tests for an unimplemented function; they intentionally fail. |
| Step 2 | `java/step2` | `dotnet/step2` | The implementation passes six tests, but coverage exposes a missing case. |
| Step 3 | `java/step3` | `dotnet/step3` | Seven tests give full coverage, but mutation testing exposes a boundary case. |
| Step 4 | `java/step4` | `dotnet/step4` | Nine tests kill all tested mutants. |

### Java

Install JDK 25. The checked-in Maven wrapper selects the Maven version. Run commands from the repository root; on Windows, use `.\mvnw.cmd` instead of `./mvnw`.

```shell
git switch java/main
./mvnw clean test
```

The starting test intentionally fails. Continue through the branches below, following the root README on each branch for test, coverage, and mutation-testing commands:

```shell
git switch java/step1
git switch java/step2
git switch java/step3
git switch java/step4
```

### C# / .NET

Install the .NET 10 SDK. Run commands from the repository root:

```powershell
git switch dotnet/main
dotnet test Palindrome.sln
```

The starting test intentionally fails. Continue through the branches below, following the root README on each branch. From Step 2 onward, one test run also collects coverage. The READMEs include ReportGenerator and Stryker.NET setup, output paths, and the Windows ARM64 setting.

```powershell
git switch dotnet/step1
git switch dotnet/step2
git switch dotnet/step3
git switch dotnet/step4
```

Keep local edits committed or stashed before switching branches. If a branch is checked out in another worktree, open that worktree instead. Return to the slides with `git switch main`.

## Build the slides locally

With Node.js 24 installed, run these commands from `main`. PDF generation also requires Chrome, Edge, or Firefox:

```powershell
npx --yes @marp-team/marp-cli@latest --html mutation-testing.md --output artifacts\slides\index.html
npx --yes @marp-team/marp-cli@latest --html mutation-testing.md --pdf --output artifacts\slides\mutation-testing.pdf
```

GitHub Actions builds every tutorial branch, respecting the intentionally incomplete starting stages. Language branches also validate their own changes. Slides are published to GitHub Pages only from `main`.
