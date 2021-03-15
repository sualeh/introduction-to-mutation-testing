> **Please support this project by putting a :star: on it**

# Introduction to Mutation Testing

> **Watch a [video of this tutorial on YouTube](https://youtu.be/1ljrGdXuv_g).**

Most developers are familiar with the concept of unit testing, and how this is useful to ensure validity of your code, and guard against bugs creeping up in the future. Java developers will typically use [JUnit](https://junit.org/junit5/) to write their unit tests. Many projects use test coverage tools such as [Jacoco](https://www.eclemma.org/jacoco/) to ensure that the code as written has tests to validate it. But how strong are the tests? Will they stand up against bugs introduced by future code changes? 

[Mutation testing](https://en.wikipedia.org/wiki/Mutation_testing) help ensure that that tests themselves are of high quality by introducing random bugs, or mutations, and checking if any of unit tests can catch the bug. While this concept has been around for a while, it is just recently that good tools are becoming available for this purpose. One such tool is [PIT](https://pitest.org/).

This tutorial explores how mutation testing works. We will do test-driven development of a simple palindrome function, and follow it through code coverage with Jacoco and mutation testing with PIT. Start by reading the [brief overview of mutation testing](mutation-testing.md) included in this tutorial. Read the README file for instructions at each step.

*Expected time to complete tutorial: 30 minutes*


## Getting Started

Follow along this tutorial. You will need to have at least [Java 8](https://www.oracle.com/java/technologies/javase/javase-jdk8-downloads.html) installed, and [Apache Maven](http://maven.apache.org/) on the PATH. Clone this repository, and fire up an IDE such as [IntelliJ IDEA](https://www.jetbrains.com/idea/) to follow along.

## Move to Step 1

In order to move to Step 1, checkout git branch `step1` by running `git checkout step1`.
