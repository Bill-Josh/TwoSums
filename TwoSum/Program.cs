using System;
/*
 * @author Billy Bedon Pacheco
 */

namespace TwoSum
{
    public class Program : TwoSum
    {
        public static void Main()
        {
            //{2,7,11,15} Target: 9     Expectation: 0,1
            //{2,7,11,15} Target: 18     Expectation: 1,2
            //{2,7,11,15} Target: 22     Expectation: 2,3
            //{3,2,4}     Target: 6     Expectation: 1,2
            //{3,3}       Target: 6     Expectation: 0,1
            int[] numberArray = new int[] { 2, 7, 11, 15 };
            int target = 18;
            int[] result = SumTwoNumTarget(numberArray, target); //return the indices of the 2 numbers such that they add up to the target value.
            Console.WriteLine("The index of each number that they add up to the target value are:");
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }
    }
}