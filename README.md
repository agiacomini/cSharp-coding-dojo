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
- [Spiders Kata](#spiders-kata) 

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

## Spiders Kata

### Intro

Spiders are amazing creatures, their ability to put traps to catch their prey is famous, but what happens when they try to hunt their own species? Let's create a scenario to see if we can trap a spider while being a spider!

### Requirements

Create a turn-based application where our spider will chase another spider.
We have 10 moves to catch our prey, if we fail, our spider dies.

On each turn we will control the spider and pass it a command that orders it where to move to, out of bound moves are not allowed as we should only move within the map.

The map should be printed at each turn so we can see how the game is developing.

### Rules

* The starting distance between our spider and our prey is 2 spaces.
* The starting positions can be random.
* Each spider can only move on their turn.
* Each spider has to follow the existing paths, no new paths can be created.
* We have 10 turns to play.
* If our spider catches its prey, the game ends and we win. Multiplication/Division, Addition/Subtraction)
* If our spider fails to catch its prey, the game ends and we lose.

Link: https://www.codurance.com/katas/spiders