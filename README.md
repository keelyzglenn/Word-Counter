# Word Counter Webpage
## by Keely Silva-Glenn

## Description

This webpage demonstrates my ability to combine the last two weeks of learning at Epicodus in C#. The webpage will search through the users inputted sentence and return the number of times the inputted word is in the sentence, similar to a "Find" command.

## Setup and Installation

* Clone repository
* Open index.html in browser of your choice

## Technologies Used

* HTML
* Bootstrap
* CSS
* CS#
* Nancy

# Link

https://github.com/keelyzglenn/Word-Counter.git

## Specs

* User inputs a sentence and the program returns the sentence.
Input: "this is a sentence."
Output: "this is a sentence."
Reason: The easiest behavior to test is if the program can take an input and return the exact same input with no changes.

* User inputs a single word. The program returns the word.
Input: Word: "sentence"
Output: Word: "sentence"
Reason: The second easiest behavior to test is if the program can take an input and return the exact same input with no changes.

* User inputs a single word and sentence. The program returns true or false if sentence contains the word
Input: "this is a sentence.", Word: "sentence"
Output: true
Reason: This behavior sets up the program to recognize a connection between the to inputs and sees if it can identify that one input contains another.

* The program will search through the inputted sentence and using the inputted word the program will return the number of times the sentence contains the inputted word.
Input: Sentence: "this is a sentence.", Word: "sentence"
Output: Your sentence contains the word 1 time
Reason: The third easiest behavior to test is if the program can take the TWO inputs and using one method return the number of times input1 contains input2. If we already know the program can return the inputs, then the program should be able to run a method using those inputs.

* The program will return word matches regardless of capitalization
Input: Sentence: "this is a sentence.", Word: "Sentence"
Output: Your sentence contains the word 1 time
Reason: The fourth behavior to test is if the program can appropriately run the method with different variations of the same process.

## Legal
MIT License

Copyright (c) 2017 Keely Silva-Glenn
