namespace InterviewSolutions
{
    public class Problems
    {
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
    }
}