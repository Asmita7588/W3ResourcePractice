using System;

namespace LogicalPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number from 1 to 100 : ");
            LogicalPracticeProgram.PrintNumFrom(1, 100);

            int num = 13467;
            Console.WriteLine($"sum of digit of {num}");
            int sumResult = LogicalPracticeProgram.SumOfDigit(num);

            Console.WriteLine($"Sum =" + sumResult);

            string palindromStr = "nayan";

            bool isPalindrom = LogicalPracticeProgram.IsPalindromeString(palindromStr);

            if (isPalindrom) {
                Console.WriteLine($"{palindromStr} is palindrome");
            }
            else
            {
                Console.WriteLine($"{palindromStr} is not palindrome");
            }



            string str = "hello";
            string reverseResult = LogicalPracticeProgram.ReverseString(str);

            Console.WriteLine("Reverse result = " +reverseResult);


            LogicalPracticeProgram.FizzBuzzProgram(1);
            int num1 = 8;
           bool result  = LogicalPracticeProgram.checkPowerOfTwoNum(num1);
            if (result)
            {
                Console.WriteLine(num1 + " power of two");
            }
            else
            {
                Console.WriteLine(num1 + " not power of two");
            }


        }

    }
}
