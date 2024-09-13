//https://leetcode.com/problems/subarray-sum-equals-k/

/*
+ Using dictionary technique
    + Key: to store sum of elements at idx i
    + Value: to store frequency of that sum at idx i
Space complexity: O(N)
Time complexity: O(N)
*/

namespace Day1309
{
    public class Exercise1
    {
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> dict = [];
            int result = 0;
            int total = 0;

            dict[0] = 1;

            foreach (int num in nums)
            {
                total += num;
                int count = total - k;

                if (dict.ContainsKey(count))
                    result += dict[count];

                if (dict.ContainsKey(total))
                    dict[total]++;
                else
                    dict[total] = 1;

            }

            return result;
        }
    }
}