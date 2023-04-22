# InterviewSolutions


![Nuget](https://img.shields.io/nuget/v/InterviewSolutions?label=NuGet)

A collection of common interview questions implemented in C#.

## Installation

You can install this package using NuGet package manager.

```
nuget install InterviewSolutions
```

## Usage
### FizzBuzz

The FizzBuzz method takes two integer arguments `start` and `end`, and prints the numbers from start to end. If a number is divisible by 3, it prints `Fizz`. If a number is divisible by 5, it prints `Buzz`. If a number is divisible by both 3 and 5, it prints `FizzBuzz`.

Usage:

```
InterviewSolutions.Problems.FizzBuzz(1, 15);
```

Output:
```
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
```
---
### ReverseString

The ReverseString method takes a string argument `str` and an optional boolean argument `returnString`. If `returnString` is true, it returns the reversed string. Otherwise, it prints the reversed string to the console.

Usage:

```
string reversed = InterviewSolutions.Problems.ReverseString("Hello, world!", true);
Console.WriteLine(reversed);
```

Output:
```
!dlrow ,olleH
```
---
### ReverseSentence

The ReverseSentence method takes a string argument `sent` and an optional boolean argument `returnString`. If `returnString` is true, it returns the reversed sentence. Otherwise, it prints the reversed sentence to the console.

Usage:

```
string reversed = InterviewSolutions.Problems.ReverseSentence("The quick brown fox jumps over the lazy dog.", true);
Console.WriteLine(reversed);
```

Output:

```
dog. lazy the over jumps fox brown quick The
```
---
### MinMaxLists

The MinMaxLists method takes a list of integers `inputList` and an optional boolean argument `returnString`. If `returnString` is true, it returns a string with the maximum and minimum sums of the list. Otherwise, it prints the maximum and minimum sums of the list to the console.

Usage:

```
string result = InterviewSolutions.Problems.MinMaxLists(new List<int> { 1, 2, 3, 4, 5 }, true);
Console.WriteLine(result);
```

Output:

```
Maximum Sum: 14; Minimum Sum: 10
```
---
### FibonacciMethod

The FibonacciMethod method takes an integer argument `ResultLength` and returns a list of the first `ResultLength` numbers in the Fibonacci sequence.

Usage:

```
List<int> fibList = InterviewSolutions.Fibonacci.FibonacciMethod(10);
foreach (int num in fibList)
{
    Console.WriteLine(num);
}
```

Output:
```
0
1
1
2
3
5
8
13
21
34
```
---
### DetectPalindrome

The DetectPalindrome method takes a string argument `palindromeTest` and returns a bool indictating the palindromicity of the input string.

Usage:

```
string palindromeTestString = "racecar";
Console.WriteLine(InterviewSolutions.Problems.DetectPalindrome(palindromeTestString));
```

Output:
```
true
```

---
### License

This project is licensed under the MIT License.
