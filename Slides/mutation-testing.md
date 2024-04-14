---
marp: true
draft: true
theme: uncover
headingDivider: 2
paginate: true
style: |
  section {
    text-align: left;
  }
  ul, ol, li {
    margin-left: 0;
  }
  h2 {
    font-size: 1.5rem;
    color: #0000DD;
  }
  pre {
    font-size: 1.0rem;
  }
_class:
 - lead
 - invert
---

# Mutation Testing

**Sualeh Fatehi**


## What Software Testing Does

- *Unit and functional testing* validates software **works as designed**
- *Regression testing* validates that software **still works after changes**

But how do we ensure that our tests are sufficient?


## Ensuring That Tests are Sufficient

- Creating test plans with the team
- Measuring code coverage 
  to see how much of the source code is executed during test runs
- Mutation testing


## What is Mutation Testing?

- Measures the quality of the software tests themselves
- Idea proposed by Richard Lipton in 1971
- Requires computational power, and is catching on in recent times


## Theory

- *Competent programmer hypothesis*
  software faults are due to small syntactic errors
- *Coupling effect*
  simple faults can cascade to form other emergent faults


## How Does it Work?

- Introduce small random code changes called mutants
- Run all the tests that cover that area of code
- If any test fails, the mutant is killed
- If all tests pass, the mutant lives
- If a mutant lives, you have insufficient testing


## Types of Mutations

- **Value Mutations**: Change values of constants to detect errors
- **Decision Mutations**: Change decisions or conditions (Boolean and arithmetic operations) to check for design errors
- **Statement Mutations**: Delete or duplicate statements, like copied and pasted code


## Tools

[Awesome Mutation Testing](https://github.com/theofidry/awesome-mutation-testing) has a list of resources

- [Stryker Mutator](https://stryker-mutator.io/) for C# and JavaScript
- [PIT](https://pitest.org/) for Java
