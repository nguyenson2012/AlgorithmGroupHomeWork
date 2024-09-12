//https://leetcode.com/problems/continuous-subarray-sum/

/*
+ Using dictionary technique
    + Key: int type to store value that get total % k 
    + Value: idx coresponds to that key (idx is farthest)
Space complexity: O(N)
Time complexity: O(N)
*/

namespace Day1209
{
    public class Exercise2
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            int total = 0;
            Dictionary<int, int> dict = [];

            dict[0] = -1;
            int Length = nums.Length;
            for (int i = 0; i < Length; ++i)
            {
                total += nums[i];

                int count = total % k;

                if (!dict.ContainsKey(count))
                    dict[count] = i;
                else if (i - dict[count] >= 2)
                    return true;
            }
            return false;
        }
    }
}