using System;

namespace metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 1, 4, 3, 2, 5 };
            string[] wordArray = { "fortnite", "destiny", "CSGO", "Fall guys", "popcorn", "discord" };


            Console.WriteLine(AddArray(numArr));

            Console.WriteLine(Reverse_array(wordArray));

            FindBounds(numArr);
        }

        public static int AddArray(int[] numArray)
        {
            int sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sum += numArray[i];
            }
            return sum;
        }

        public static string Reverse_array(string[] strArray)
        {
            string reversedArray = "";

            for (int i = strArray.Length - 1; i >= 0; i--)
            {
                reversedArray += strArray[i];
                reversedArray += " ";
            }
            return reversedArray;
        }

       
        public static void FindBounds(int[] numArray)
        {
            int smallestNum = numArray[0];
            int greatestNum = numArray[0];

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < smallestNum)
                {
                    smallestNum = numArray[i];
                }
                else if (numArray[i] > greatestNum)
                {
                    greatestNum = numArray[i];
                }
            }
            Console.WriteLine("The Greatest number in the list is: " + greatestNum);
            Console.WriteLine("The smallest number in the list is: " + smallestNum);
        }
    }
}