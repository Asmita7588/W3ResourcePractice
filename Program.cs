using System;
using static System.Net.Mime.MediaTypeNames;

namespace LogicalPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("number from 1 to 100 : ");
            // LogicalPracticeProgram.PrintNumFrom(1, 100);

            // int num = 13467;
            // Console.WriteLine($"sum of digit of {num}");
            // int sumResult = LogicalPracticeProgram.SumOfDigit(num);

            // Console.WriteLine($"Sum =" + sumResult);

            // string palindromStr = "nayan";

            // bool isPalindrom = LogicalPracticeProgram.IsPalindromeString(palindromStr);

            // if (isPalindrom) {
            //     Console.WriteLine($"{palindromStr} is palindrome");
            // }
            // else
            // {
            //     Console.WriteLine($"{palindromStr} is not palindrome");
            // }



            // string str = "hello";
            // string reverseResult = LogicalPracticeProgram.ReverseString(str);

            // Console.WriteLine("Reverse result = " +reverseResult);


            // LogicalPracticeProgram.FizzBuzzProgram(1);
            // int num1 = 8;
            //bool result  = LogicalPracticeProgram.checkPowerOfTwoNum(num1);
            // if (result)
            // {
            //     Console.WriteLine(num1 + " power of two");
            // }
            // else
            // {
            //     Console.WriteLine(num1 + " not power of two");
            // }



            // //Write a C# Sharp program in to count duplicate elements in an array.

            // int[] arr =  { 10, 20, 30, 40, 70, 30, 70, 10 };

            //int count=   ArrayProgramPractice.CountDuplicateArrayElement(arr);

            // Console.WriteLine("Duplicate array element :" +count);


            // Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
            //Test Data : 21

            int age = ArrayProgramPractice.CheckEligibleCandidate("2001-11-03");
            Console.WriteLine(age + "age");
            if (age <= 21)
            {
                Console.WriteLine("candidate is eligible");
            }

            //count speical character
            ArrayProgramPractice.CaluclateSpecialChar();

            //copy string by method 

            ArrayProgramPractice.CopyString();

            //copy string another way 
            ArrayProgramPractice.CopyStringProgram();

            //linq retuen number divide by zero
            LinqExample.ShowThreePartQueryExcutecution();

            LinqExample.FindPositiveNummber();

            LinqExample.DisplayFrequencyOfNumbers();

            LinqExample.DisplayFrequencyOfCharacter();

            LinqExample.FindDayOfWeek();
        }


            

    }
}
