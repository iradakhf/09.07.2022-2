using System;
namespace arrays
{
    class Program
    {
        public static void Main (string [] args)
        {
            int[] numbers = { 1, 2, 5, 8 };

            int[] reverNumbers = ReverseArray(numbers);
            for (int i = 0; i < reverNumbers.Length; i++)
            {

                Console.WriteLine(reverNumbers[i]);

            }
            
        }
        public static int[] ReverseArray(int[] numbers)
        {
            int[] reverseArray = new int[numbers.Length]; 
            int number = 0;
            for (int i = numbers.Length-1, j = 0; i >=0&& j < numbers.Length; i--, j++)
            {
                
                    reverseArray[j] = numbers[i];
                
            }
            return reverseArray;
        }
    }
}