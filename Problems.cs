using System.Linq.Expressions;

namespace InterviewSolutions
{
    public class Problems
    {

        /// <summary>
        /// This method prints out the numbers from start to end and replaces the numbers divisible by 3 with "Fizz", 
        /// divisible by 5 with "Buzz" and divisible by both 3 and 5 with "FizzBuzz".
        /// </summary>
        /// <param name="start">The starting number of the sequence.</param>
        /// <param name="end">The end number of the sequence.</param>
        public static void FizzBuzz(int start, int end)
        {
            try
            {
                for (int i = start; i <= end; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        /// <summary>
        /// Reverses a given string and returns it as a new string.
        /// </summary>
        /// <param name="str">The string to be reversed</param>
        /// <param name="returnString">Optional boolean parameter to specify if the reversed string should be returned or printed to the console (default is false)</param>
        /// <returns>A new reversed string if 'returnString' is set to true, an empty string if 'returnString' is set to false, or an exception if the string cannot be reversed</returns>
        public static string ReverseString(string str, bool returnString = false)
        {
            try
            {
                if (!returnString)
                {
                    char[] charArray = str.ToCharArray();
                    Array.Reverse(charArray);
                    string result = new string(charArray);
                    Console.WriteLine(result);
                    return String.Empty;
                }
                else
                {
                    char[] charArray = str.ToCharArray();
                    Array.Reverse(charArray);
                    string result = new string(charArray);
                    return result;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        /// <summary>
        /// Reverses the order of words in a sentence.
        /// </summary>
        /// <param name="sent">The sentence to be reversed.</param>
        /// <param name="returnString">Optional parameter to determine whether to print the reversed sentence to the console or return it as a string. Default is false (print to console).</param>
        /// <returns>If returnString is true, returns the reversed sentence as a string. Otherwise, returns an empty string.</returns>
        public static string ReverseSentence(string sent, bool returnString = false)
        {
            try
            {
                if (!returnString)
                {
                    string reversedString = String.Join(" ", sent.Split(' ').Reverse().ToArray());
                    Console.WriteLine(reversedString);
                    return String.Empty;
                }
                else
                {
                    string reversedString = String.Join(" ", sent.Split(' ').Reverse().ToArray());
                    return reversedString;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        /// <summary>
        /// This method returns the maximum and minimum sums of a given list of integers.
        /// </summary>
        /// <param name="inputList">The list of integers</param>
        /// <param name="returnString">A boolean parameter to indicate whether the results should be returned as a string or printed to the console</param>
        /// <returns>A string containing the maximum and minimum sums</returns>
        public static string MinMaxLists(List<int> inputList, bool returnString = false)
        {
            try
            {
                if (!returnString)
                {
                    List<long> listSums = new List<long>();

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        List<long> longList = inputList.ConvertAll(x => (long)x);
                        longList.RemoveAt(i);
                        listSums.Add(longList.Sum());
                    }

                    Console.WriteLine("Maximum Sum: " + listSums.Max().ToString() + "; Minimum Sum: " + listSums.Min().ToString());
                    return String.Empty;
                }
                else
                {
                    List<long> listSums = new List<long>();

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        List<long> longList = inputList.ConvertAll(x => (long)x);
                        longList.RemoveAt(i);
                        listSums.Add(longList.Sum());
                    }

                    return ("Maximum Sum: " + listSums.Max().ToString() + "; Minimum Sum: " + listSums.Min().ToString());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        /// <summary>
        /// Generates a Fibonacci sequence of a given length from 0 and 1 and returns it in a list.
        /// </summary>
        /// <param name="ResultLength">The number of items in the Fibonacci sequence, starting from 0 and 1.</param>
        /// <returns>A list containing the Fibonacci sequence of the given length.</returns>
        public static List<int> FibonacciMethod(int ResultLength)
        {
            List<int> resultList = new List<int>();

            int secondNum = 1;
            int fibSum = 0;
            resultList.Add(0);
            resultList.Add(secondNum);

            for (int startNum = 0; startNum < ResultLength; startNum++)
            {
                fibSum = startNum + secondNum;
                resultList.Add(fibSum);
                startNum = secondNum;
                secondNum = fibSum;
            }
            return resultList;
        }

        /// <summary>
        /// Detects whether the given string is a palindrome.
        /// </summary>
        /// <param name="palindromeTest">The string to check for palindromicity.</param>
        /// <returns>True if the given string is a palindrome, false otherwise.</returns>
        public static bool DetectPalindrome(string palindromeTest)
        {
            try
            {
                List<char> forward = palindromeTest.ToList();
                List<char> backwards = palindromeTest.ToList();
                backwards.Reverse();

                if (forward.SequenceEqual(backwards))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}