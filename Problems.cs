namespace InterviewSolutions
{
    public class Problems
    {
        public static void FizzBuzz(int start, int end)
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

        public static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string result =  new string(charArray);
            Console.WriteLine(result);
        }
    }
}