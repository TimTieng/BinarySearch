/*
Write a function that takes in a sorted array of integers and a target integer
The Function should only use the Binary Search Algorithm to determing if
target integer is present in the array, if so, return the index. 
*/

using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test - should return 3
            int[] testArr1 = {1,3,4,5,6};
            int target1 = 5;
            BinarySearchAlgorithm(testArr1, target1);
        }   
        public static void BinarySearchAlgorithm(int[] array, int targetValue)
        {
            // Declare and Init. low, high and middle index values
            int low = 0;
            int high = array.Length - 1; // Due to index 0, length will be -1 of overall length
            int middle = (low + high) / 2;

            // Iterate through the provided array, Do so while certain condition remains true
            while (low <= high)
            {
                // Compare and Evaluate the values to move indices
                if (targetValue == array[middle])
                {
                    // return middleIndex
                    Console.WriteLine($"The {targetValue} is located at index {middle}");
                }
                // Move low if target is > middle
                else if (targetValue > array[middle])
                {
                    // Reassign low index value to be 1 spot ahead of middle
                    low = middle + 1 ;                   
                }
                else 
                {
                    high = middle - 1;
                }
            }
            Console.WriteLine("Target is not present in the array");
        }
    }
}
