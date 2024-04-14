> **:star: Star it :arrow_heading_up: if you love it!**

# Introduction to Mutation Testing

> **Watch a [video of this tutorial on YouTube](https://youtu.be/1ljrGdXuv_g).**

Most developers are familiar with the concept of unit testing, and how this is useful to ensure validity of your code, and guard against bugs creeping up in the future. Java developers will typically use [JUnit](https://junit.org/junit5/) to write their unit tests, while C# developers would use [NUnit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit). Many projects use test coverage tools such as [Jacoco](https://www.eclemma.org/jacoco/) to ensure that the code as written has tests to validate it. But how strong are the tests? Will they stand up against bugs introduced by future code changes? 

[Mutation testing](https://en.wikipedia.org/wiki/Mutation_testing) helps ensure that that tests themselves are of high quality by introducing random bugs, or mutations, and checking if any of unit tests can catch the bug. While this concept has been around for a while, it is just recently that good tools are becoming available for this purpose. Examples of such tools are [PIT](https://pitest.org/) for Java and [Stryker](https://stryker-mutator.io/docs/stryker-net/introduction/) for C#.

This tutorial explores how mutation testing works. We will do test-driven development of a simple palindrome function, and follow it through code coverage and mutation testing. A Java project with Apache Maven is provided with instructions for Java developers, and a C# solution too. Start by reading the [brief overview of mutation testing](https://sualeh.github.io/introduction-to-mutation-testing/mutation-testing.pdf) included in this tutorial. Read the README file in the corresponding Java or C# for instructions at each step.

*Expected time to complete tutorial: 30 minutes*

## Step 3

In **Step 3** we will run mutation testing. Please refer to the README files in the C# or the Java folders.
