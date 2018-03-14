# Exercise Zero:

Welcome. You are tasked to write a class with a single method to determine if a string is a palindrome and write a set of tests for that method. 

A palindrome is a string that reads the same backwards and forwards. So, "abba" is a palindrome, "abbb" is not. 

There are hints at the bottom. If you are struggling, review the basics of classes and unit tests online. XUnit is used here, a basic review of the documentation should help. 

## Warmup 

The current solution does not build. Determine the cause and fix it. No, this should never happen. One must move on anyway.

# Tasks

By default, the exercise tasks are for beginners, except where noted. 

## Task Zero.0

Write a set of unit tests that should capture all the common cases for testing if a string is a palindrome. Run the tests, they should all fail (or pass by coincidence).

## Task Zero.1

Implement the method and make sure the unit tests pass.

## Task Zero.2

The string parameter in the method should be non null. 

- What is the exception that should be thrown? Modify the code to check for a null string.
- Did you write a unit test for this? If not, add one and make sure it passes. 

## Task Zero.3 (Intermediate)

If you didn't already, use recursion to implement the method. 

## Task Zero.4 (Intermediate)

Refactor the class and method to be an extension method, so the following code works:

    string aString = "abba";
    var isPalindrome = aString.IsPalindrome();

Modify your unit tests. You have been updated and running those tests all along, of course.

## Task Zero.5 (Advanced)

Add an overload to the method that takes a IComparer<char> instance and use it to see if two characters are equal, instead of the default method. 

## Task Zero.6 (Advanced)

Add an overload to the method  that can take a lambda expression so the following code works.

    aString.IsPalindrome(
        (c1,c2) => c1 == c2 || c1 == '*' || c2 == '*');

## Task Zero.7 (Expert)

Is the version you wrote for Task Zero.3 tail-end recursive?   

## Task Zero.8 (Expert)

While it is not efficient in this case, write a version that uses a recursive divide and conquer strategy. Compare the performance to a simple recursive or loop based strategy. Try to find the string size where there is a notable difference in performance. You many need to create a helper function to create very large palindrome strings to do so. 

## Task Zero.9 (Master)

Numbers can be palindromes as well. For example, 1001 is, so is 4004. Is there a faster method for determining if a integer and/or long is a palindrome versus converting the number to a string and running the methods you just made?

What about if the number is in binary (base two)? For example, 1001 is still a palindrome, as is 110011. Note, a base ten palindrome is not a base two palindrome. Find a example that proves that. 

## Task Zero.10 (Master)

Create a related function that determines the least number of characters that would have to be changed in a string to make it a palindrome and returns that as a value. Note, this is a generalization of the original method, as if the number of characters that are changed to make a string a palindrome is zero, the string is a palindrome. 

Note, the method should have overloads for char comparison and use those in the calculations as the previous exercises did. 

Note, this is indeed harder that it first seems. 

# Hints

The unit test solution is missing a reference to the library. Add that reference, and the solution should compile. 

