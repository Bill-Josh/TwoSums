using System.Collections.Generic;
/*
 * @author Billy Bedon Pacheco
 */

namespace TwoSum
{
    public class TwoSum
    {
        public static int[] SumTwoNumTarget(int[] nums, int target)
        {
            Dictionary<int, int> numDictionary = new Dictionary<int, int>(); //Using Dictionary every value gets a key so it wont read an item twice.

            int[] indicesResult = new int[2]; //We store result here

            for (int index = 0; index < nums.Length; index++)
            {
                int indexValue = target - nums[index];

                if (numDictionary.ContainsKey(indexValue) && index != numDictionary[indexValue])//if keyValue is already in Dictionary and index is distinct than the indexValue in Dictionary then return saved indices.
                {
                    indicesResult[0] = numDictionary[indexValue]; //indexValue would return numDictionary selected item index.
                    indicesResult[1] = index;   //If Index is different than the value of the selected item in numDirectory, it saves the second index value.
                    return indicesResult;
                }
                numDictionary[nums[index]] = index;
            }
            return indicesResult;
        }
    }
}