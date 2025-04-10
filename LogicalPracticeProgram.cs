using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPractice
{
    internal class LogicalPracticeProgram
    {
        public static void PrintNumFrom(int startNum, int endNum)
        {
            
            if (startNum <= endNum)
            {
                Console.WriteLine(startNum);
                PrintNumFrom(startNum + 1, endNum);
            }
        }

        //Sum of Digits Without Loop
        public static int SumOfDigit(int num) {                 //13467  = 21

            if (num == 0)
            {
                return 0; 
            }

            return (num % 10) + SumOfDigit(num / 10);
        }

        //Check for Palindrome Without Loop or String Reverse Function

        public static bool IsPalindromeString(string str) {

            if (str.Length <= 1)
            {
                return true;
            }
            else
            {

                if (str[0] == str[str.Length - 1])
                {
                    return IsPalindromeString(str.Substring(1, str.Length - 2));
                }
                else
                {
                    return false;
                }


            }
        }


        public static string ReverseString(string str ) { 

            int start = 0;
            int end = str.Length - 1;

            //StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(str) )
            {
                //sb.Append(str[end]);
                //end--;
                //start++;
                return str;
                
            }
            else {
                return ReverseString(str.Substring(1)) + str[0];

            }


           
        }

        //FizzBuzz Without Using Loop or If-Else
       // Print 1 to 100 where:

       //If divisible by 3: print "Fizz"

     //If divisible by 5: print "Buzz"

      //If both: "FizzBuzz"


        public static void FizzBuzzProgram (int num)
        {
            if (num > 100)
            {
                return; 
            }

            string FizzBuzzResult = "";
            FizzBuzzResult += (num % 3 == 0 ? "Fizz" : "");

            FizzBuzzResult += (num % 5 == 0 ? "Buzz" : "");

            Console.WriteLine(string.IsNullOrEmpty(FizzBuzzResult) ? num.ToString() : FizzBuzzResult);

            FizzBuzzProgram(num + 1);
        }


        //Find If a Number is a Power of Two Without Using Loop 
        // Example: 8 → true, 6 → false

        public static bool checkPowerOfTwoNum(int num) {
            if (num <= 0)
            {
                return false; 
            }
            return (num & (num - 1)) == 0;  // if result 0000 then return true
        }
    }
}
