<p align="center"> 
    <img src="./img/xLogo.png" alt="csharp" width="200" height="200"/>
    <img src="./img/MSTest.png" alt="csharp" width="200" height="200"/> 
</p>

<!-- ![xUnitLogo](/img/xUnitLogo.png) -->

# Project Description

TDD Project implementing:

1. xUnit Framework (Coding Dojo)
2. Microsoft UnitTesting Framework (NinjaDojo)

# KATAs

- [Leap Year Kata](#leap-year-kata) 
- [Password Validation Kata](#password-validation-kata) 
- [Text Processing Kata](#text-processing-kata) 

## Leap Year Kata

### Introduction

This is another classic, usually attempted as a follow-on from FizzBuzz and normally considered a slight step up in difficulty because of the slightly more complicated rules. In practice, most developers can hold an entire solution to FizzBuzz in their working memory, but the Leap Year algorithm is a greater cognitive load, so it's normally not possible in one go.

This starts to reveal the power of baby-steps TDD. An algorithm that by itself feels like a bit of a challenge can be split into small, easy steps. As a bonus, since you're test-driving, you'll have living documentation and a full suite of regression tests once you've finished!

Carefully choosing the next test is essential - if you find yourself doing too large a step at any point, ask yourself: have you picked the right test case? You might need to wind back more than one step before you find an easier route. Like with other katas, success on this kata doesn't just mean that "it works": you can do it again and again to refine your approach (see Defining "Done" below).

### Instruction

Implement a method that checks if a year is a leap year.

All the following rules must be satisfied:

- A year is not a leap year if not divisible by 4
- A year is a leap year if divisible by 4
- A year is a leap year if divisible by 400
- A year is not a leap year if divisible by 100 but not by 400

Examples:

- 1997 is not a leap year (not divisible by 4)
- 1996 is a leap year (divisible by 4)
- 1600 is a leap year (divisible by 400)
- 1800 is not a leap year (divisible by 4, divisible by 100, NOT divisible by 400)

The method should return true if a year is a leap year, and false if it is not.

### Defining "Done"

How do you know when a kata is finished?

Firstly, it's not a one-shot thing. Some developers practice the same kata hundreds of times, each time trying a slightly new route, or a different technique.

Something that is important but sometimes overlooked is internalising the process of TDD. Try to always follow the principles while implementing the kata, even if it feels unnatural at first. If you get stuck and find you need to break one of the principles to get going again, that's fine, but make a note; it's an area for improvement. The next time you do the kata with more experience, you might find that it has taken care of itself.

Link: https://www.codurance.com/katas/leap-year

## Password Validation Kata

### Iteration 1 - Basic password validation

### Goal

Design and implement a software that validates a password applying TDD.

The password will be introduced by the user (as an argument of the method) and should return if the password is valid or not.

A valid password should meet the following requirements:

- Have more than 8 characters
- Contains a capital letter
- Contains a lowercase
- Contains a number
- Contains an underscore

### Technical requirements:

* We want a method that answers if the password is valid or not.
* We don't want to know the reason when the password is invalid (the return value is a boolean)

### Iteration 2 - Rules abstraction

### Goal
Design and implement software that can adapt to different password validation rules TDD and focus on the OOP principles.

Let's pretend that now we want to create another type of password validations because on our app we need different type of passwords, such as:

Validation 2:

- Have more than 6 characters
- Contains a capital letter
- Contains a lowercase
- Contains a number

Validation 3:

- Have more than 16 characters
- Contains a capital letter
- Contains a lowercase
- Contains an underscore

### Things to practice

In this iteration, we should try to identify a good abstraction and try to work on OOP principles as well as on design patterns like Builder and Factory

### Interesting restrictions

Use object calisthenics.

### Iteration 3 - Multiple errors

### Goal
Now we can know if a password is valid or not, but we cannot understand why, in this iteration, we should be able to return a list of errors for each invalid password, so we could know why the password it's not valid.

### Things to practice

Identify how maintainable it's the code that you've built so far, and how it adapts to change, this iteration could change depending on the programming language that you use.

### Iteration 4 - Validation strategy

### Goal

Up untill this point we've been able to create a list of validation rules and validate the password passes all the validation rules, but now we want a new password with the same rules but allowing to fail only one of them.

Validation 4

- Have more than 8 characters
- Contains a capital letter
- Contains a number
- Contains an underscore

Examples:

- Have more than 8 characters ✅
- Contains a capital letter ✅
- Contains a number ✅
- Contains an underscore ❌

This password it's a valid password

### Things to practice

This will help to enforce encapsulation for the lists of rules and have a better design for validation strategies [preventing us from using inheritance], this also could help us work on the Strategy pattern.

Link: https://www.codurance.com/katas/password-validation

## Text Processing Kata

### Introduction

As a developer that writes blog posts I want a tool that helps me to understand better the text I am writing. For that I need a way to know the following:

1. What are the most common words used in the text?
2. How many characters does the text have?

```bash
interface Processor {
   analyse(text: string);
}
```
The usage of such interface is not required.

### First Challenge

Given the following text:

```bash
Hello, this is an example for you to practice. You should grab this text and make it as your test case.
```

The output should be:

```bash
Those are the top 10 words used:

1. you
2. this
3. your
4. to
5. text
6. test
7. should
8. practice
9. make
10. it

The text has in total 21 words
```

### Some side notes:

* As you may have noticed, the example assumes that You and you are the same, in other words, it's not case sensitive.
* There is no order in which the words that have the same number are listed. For example, this and it, appear once, and they are not alphabetically ordered.

Next up, the kata starts to be a bit more complex. Make sure to complete this challenge first before going on into the second.

### Second Challenge

Now I would like to know how much time would it take the user to read my post, for that I should apply the following formula:

(The average reading rate is actually 238, according to this study, but 200 is a nice compromise and is easier to remember.)

Here's the formula:

* Get your total word count (including the headline and subhead).
* Divide total word count by 200. The number before the decimal is your minutes.
* Take the decimal points and multiply that number by .60. That will give you your seconds.

Example:

```bash
783 words ÷ 200 = 3.915 (3 = 3 minutes)
.915 × .60 = .549 (a little over 54 seconds, so I'd bump it up to 60 seconds, or a full minute)
reading time for this example article is 4 minutes.
```

### Third challenge

Besides the previous features, the text processing also should have:

* A way to ignore a given piece of text to analyse (For example, a code snippets - the code snippet is in between javascript anything inside should be ignored)
* A way to offer stop words and remove them from the analysis

Given the example for 1, this would be a text with code snippets:

```bash
Hello, this is an example for you to practice. You should grab
this text and make it as your test case:

if (true) {
  console.log('should should should')
}
```

The text processing output should ignore the code snippet. Meaning, that the output should be:

```bash
Those are the top 10 words used:

1. you
2. this
3. your
4. to
5. text
6. test
7. should
8. practice
9. make
10. it

The text has in total 21 words
```
Note that, the word should is the same, and it does not goes up in the list as should appears four times (more than the word you).


Link: https://www.codurance.com/katas/text-processing