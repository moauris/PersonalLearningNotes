
[toc]

# Overview: Today's tasks and fulfillment

- [ ] Task 1 Break-in JavaScript Cookbook 2nd Edition
- [ ] Task 2 Initialize an repos for calculating the possible sum matches in two double arrays
- [ ] Task 3 LeetCode 3+2+1

# Topic 1: JavaScript Cookbook 2nd Edition

## Summary

I have been reading JavaScript definitive guide for a while, now it's time to put it into practice.

By reading cookbook and learning example, deepen understanding of JS.

The long term goal is to create a JS project that can potentially earn the JavaScript badge

## Problem

## Solution

## Extra

# Topic 2: Initialize an repos for calculating the possible sum matches in two double arrays

## Summary

We are trying to consolidate company side ledger and bank side ledger. 

A ledger is a dictionary<string, double> object.

From each side, there might be 1 - multiple items that can be combined to match a 1 - multiple item combination on the other side.

Return a `dictionary<string, string>` object, where the key is a company row address, and the value is the consolidated bank side address.

Constraints:

10 < n < 100

10.00 < Double < 1,000,000.00



## Problem

The most straight forward way is to calculate the combination of all possibilities, but then the list size would be astronomical. The formula for combination a subset size of r and a total size of n is:
$$
rCn = \frac{n!}{r!\times(n-r)!}
$$
To get all the possible combinations of size n, the formula is
$$
\begin{align}
	R&=\sum_{k=1}^n kCn\\
	R&=\sum_{k=1}^n \frac{n!}{k!\times(n-k)!}

\end{align}
$$
To calculate the relationship for all possible combinations versus size, I wrote

```vb
Sub Cacl()
    Dim rng As Range
    Dim result As Long
    Dim i As Integer
    Dim n As Integer
    
    Set rng = Me.[A2]
    
    Do While rng.Value <> ""
        n = rng.Value
        result = 0
        For i = 1 To n
            result = result + Single_rCn(i, n)
        
        
        Next i
        rng.Offset(0, 1).Value = result
    
    
        Set rng = rng.Offset(1, 0)
    Loop




End Sub

Function Single_rCn(CombiSize As Integer, TotalSize As Integer) As Long
    Single_rCn = WorksheetFunction.Fact(TotalSize) / _
        (WorksheetFunction.Fact(CombiSize) * _
        WorksheetFunction.Fact(TotalSize - CombiSize))

End Function
```

Here is the result:

| Size | All Combinations |
| ---- | ---------------- |
| 1    | 1                |
| 2    | 3                |
| 3    | 7                |
| 4    | 15               |
| 5    | 31               |
| 6    | 63               |
| 7    | 127              |
| 8    | 255              |
| 9    | 511              |
| 10   | 1023             |
| 11   | 2047             |
| 12   | 4095             |
| 13   | 8191             |
| 14   | 16383            |
| 15   | 32767            |
| 16   | 65535            |
| 17   | 131071           |
| 18   | 262143           |
| 19   | 524287           |
| 20   | 1048575          |
| 21   | 2097151          |
| 22   | 4194303          |
| 23   | 8388607          |
| 24   | 16777215         |
| 25   | 33554431         |
| 26   | 67108863         |
| 27   | 134217727        |
| 28   | 268435455        |
| 29   | 536870911        |
| 30   | 1073741823       |
| 31   | 2147483647       |
| 32   | OVERFLOW!        |
| 33   | OVERFLOW!        |
| 34   | OVERFLOW!        |

Now, we know somehow the combination cannot exceed 15, so modifying the code to be:



## Solution

## Extra

# Topic 3:

## Summary

## Problem

## Solution

## Extra