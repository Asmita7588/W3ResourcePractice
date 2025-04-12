using System;
using System.Linq;

namespace LogicalPractice
{
    public class LinqExample
    {
        //Write a program in C# Sharp to show how the three parts of a query operation execute.
        public static void ShowThreePartQueryExcutecution()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("basic stucture of linq");

            var query = from num in arr
                        where (num % 2 == 0)
                        select num;

            Console.WriteLine("Number divide by zero :");
            foreach (int num in query)
            {
                Console.Write(num + " ");

            }
        }

    


   // Using multiple WHERE clause to find the positive numbers within the list

        public static void FindPositiveNummber()
        {
            int[] arr = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14  };

            Console.WriteLine("Only positive number from list.");
            var lQuery = from num in arr
                         where num > 0
                         where num < 12
                         select num;

            Console.WriteLine("Number within the range of 1 to 11");
            foreach(int num in lQuery)
            {
                Console.Write(num + " ");
            }

        }

        //Write a program in C# Sharp to display the number and frequency of a given number from an array.

        public static void DisplayFrequencyOfNumbers()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            Console.WriteLine("The numbers in the array are : ");
            Console.WriteLine(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2");

            var numbers = from num in arr1
                          group num by num into y
                          select y;

            Console.WriteLine("\nThe number and the Frequency are : ");
            foreach (var arrNo in numbers)
            {
                Console.WriteLine("number " + arrNo.Key + " found " + arrNo.Count() + " times");
            }



        }

        //Display the characters and frequency of character from giving string
        public static void DisplayFrequencyOfCharacter()
        {
            string str = "i am a java developer";

            var charFrequency = from x in str
                group x by x into y 
                select y;

            Console.WriteLine("The frequency of the characters are :");
            foreach (var ele in charFrequency)
            {
                Console.WriteLine("Character " + ele.Key + ": " + ele.Count() + " times");
            }

        }

        //Write a program in C# Sharp to display the name of the days of the week.

        public static void FindDayOfWeek()
        {
            string[] dayOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine(" display the name of the days of a week : ");

            var days = from DayOfWeek in dayOfWeek
                       select DayOfWeek;

            foreach (var WeekDay in days)
            {
                Console.WriteLine(WeekDay);
            }


        }
    }
}
