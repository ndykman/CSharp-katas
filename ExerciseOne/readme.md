# Exercise One:

Welcome. Today, we are pondering winning or losing streaks. 

A streak is the longest set of consecutive wins or losses (as a common example) for a given period. 

The goal is to write a method that returns the length of the longest streak given a record.

A record will be an array of booleans. An example:

[0,1,1,0] 

In this case, it is a streak of two wins that is the longest. 

## Warmup 

There is no solution here. Add a solution like the one in Exercise Zero, but use the namespace Csk.Streak. So, you will have two projects in the solution, one a .Net Core class library (Csk.Streak) and one a XUnit project (Csk.Streak.Tests)

# Tasks

By default, the exercise tasks are for beginners, except where noted. 

## Task One.0

Write a set of unit tests that should capture some common cases for longest streaks.

## Task One.1

Implement the class and the method in the tests above and make sure the unit tests pass. 

Did you handle a null array properly?

## Task One.2
 
Add an overload that has an out integer parameter called opposingStreakLength, and modify the method so that this parameter is the longest streak that is not the same kind of the longest streak in the record. 

For example, given [0,1,1,1,0,0] the longest streak is a winning streak of three. Therefore, the longest losing streak is two and that should be the value of opposingStreakLength.

## Task One.3 (Intermediate)

Generalize this method so that it takes an array of a generic type, and still works. Assume equality is correct for the type.

The following code should work. You can rename the class to match the name you used, of course.

    var streakChecker = new StreakChecker()
    int opposingStreakLength;
    streakChecker.LongestStreak(new [] {'a','b','b','b','c','a','a'}, out opposingStreakLength)
 
This would return three and opposingStreakLength would be two. 

## Task One.4 (Intermediate)

Now that we can use a generic type for the record, let's generalize the method so it returns a dictionary of all the streaks. 

So, the prototype changes to be 

    IDictionary<T, int> CreateStreakDictionary(T[] record);

And for the array:

    ['1','2','2','1','1','3'] 

The value returned is:

    { '1'=2, '2'=2, '3'=1 }

## Task One.4 (Intermediate)

Create a modified version of the above that takes a parameter that is an array of values that should be ignored when determining streaks. The could be used to ignore draws, for example. 

## Task One.5 (Advanced)

Create a version that takes a parameter that is a function of that returns true if a value can be used to maintain any streak. This could be used to allow draws to count as a streak. For example

    streakChecker.StreakIncludeValueFunction(new [] {'W', 'W', 'D', 'L', 'D'}, v => v == 'D')

would return:

    { 'W' = 3, 'L' = 2, 'D' = 1}

## Task One.6 (Advanced)

Modify the previous version to pass the previous value and the current value in the record to the function. Modify the above example code to only use 'D' values to extend a streak if the streak is 'W' value (in other terms: draws only extend winning streaks, they break losing streaks). What is the return value in this modified case.

## Task One.7 (Master)

Let us reverse a simple version of this function, one that doesn't exclude values nor have functions to extend a streak. Create a method that given a IDictionary<T,int> parameter returns an collection of every possible smallest record that would have those streak values. 

So, given an input of 

{'W' = 2, 'L' = 1}

The output would be 

['L','W','W'], ['W','W','L']

Note, this can explode very quickly, so be aware of larger test cases. 