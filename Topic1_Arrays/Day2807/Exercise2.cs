//https://leetcode.com/problems/continuous-subarray-sum/

/*
Using hashmap technique
+ Adding remainder 0 at idx -1
+ In hashmap, I will store [remainder, index]
    + Store remainder: if remainder already exists => there's definintely good array
        For example: 
        23,2,4,6,7      k = 6
        i = 0 => 23 % 6 = 5
        i = 0 => 25 % 6 = 1
        i = 0 => 29 % 6 = 5
        => This remainder already exists => good array [2, 4]
    + Store index: to ensure that there are at least 2 elements

Space complexity: O(n)
Time complexity: O(n)
*/
namespace Day2807
{
    public class Exercise2
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> myDictionary = new();
            myDictionary[0] = -1;

            int length = nums.Length;

            int sum = 0;
            for (int i = 0; i < length; ++i)
            {
                sum += nums[i];
                int count = sum % k;

                if (!myDictionary.ContainsKey(count))
                    myDictionary[count] = i;
                else if (i - myDictionary[count] >= 2)
                    return true;

            }

            return false;
        }
    }
}