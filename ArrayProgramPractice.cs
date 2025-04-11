using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace LogicalPractice
{
    internal class ArrayProgramPractice
    {
        //Write a C# Sharp program in to count duplicate elements in an array.


        public static int CountDuplicateArrayElement(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i +1; j < array.Length; j++) { 

                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        // Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
        //Test Data : 21

        public static int CheckEligibleCandidate(string DOB) { 

            DateTime dob = DateTime.Parse(DOB);

            int dobYear = dob.Year;

            int currentYear = DateTime.Now.Year;

            int  age = currentYear - dobYear;

            if (dob > dob.AddYears(-age))
            {
                age--;
            }
            return age; 
        }

        //calculate special char seplarately

        public static void CaluclateSpecialChar()
        {
            string input = "W3resource.com Is very good website.";

            int  alphabetCount = 0;

            int digitCount = 0;

            int specialCharCount = 0;

            foreach (char ch in  input )
            {
                if (char.IsLetter(ch))
                {
                    alphabetCount++;

                }
                 else if (char.IsDigit(ch))
                {
                    digitCount++;
                }
                else if (char.IsWhiteSpace(ch) || !char.IsWhiteSpace(ch)) 
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine("\n Alphabets count in the string is : " + alphabetCount);

            Console.WriteLine("Digits in the string   " + digitCount);

            Console.WriteLine(" Special characters in the string is : " + specialCharCount);
        }


        // copy string and count 

       
        public static void CopyString()
        {
            string str1 = "This is first copied string";

           
            string copystr = string.Copy(str1); 

            int length = str1.Length;

            Console.WriteLine(" First string is : " + str1);
            Console.WriteLine("Second copied string is : " + copystr);
            Console.WriteLine("count of characters copied : " + length);
        }


        //another way to copy

        public static void CopyStringProgram()
        {
            string str1 = "This is first copied string";

            string emptyStr = "";

            for (int i = 0; i < str1.Length; i++) {
                emptyStr += str1[i];
            }
            Console.WriteLine("original string :" + str1);
            Console.WriteLine("Copied string " + emptyStr);
        }

        // Write a C# Sharp program to find the maximum number of characters in a string.

        public static void FinfHighestFrequencyChar()
        {
            string str = "this is book for reading";

        }
    }
}
