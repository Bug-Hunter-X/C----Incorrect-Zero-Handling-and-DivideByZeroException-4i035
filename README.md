# C# Code Bug: Incorrect Zero Handling and DivideByZeroException

This repository demonstrates a common error in C# code: improper handling of zero values and a potential `DivideByZeroException`. The `BuggyCalculation.cs` file contains the buggy code, while `CorrectedCalculation.cs` provides a corrected version. 

## Bug Description

The original code attempts to perform division without properly checking for zero divisors.  If the denominator (`b`) is zero, a `DivideByZeroException` will be thrown. Additionally, the code incorrectly returns 0 if either input is 0.

## Solution

The corrected code in `CorrectedCalculation.cs` addresses these issues by adding appropriate checks for zero values before performing the division. It returns an appropriate value or throws a more informative exception when necessary.