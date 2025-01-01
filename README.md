# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been initialized.  This can lead to unpredictable results, such as exceptions or incorrect calculations. The bug and its solution are provided to showcase the problem and its resolution.

## Bug

The `bug.cs` file contains a C# class with a property that is accessed within a method before it's given a value.  This is problematic because the property will hold a default value, which may not be what is intended. 

## Solution

The `bugSolution.cs` file provides the solution.  This involves initializing the property either in the constructor or directly before accessing it in the method. 