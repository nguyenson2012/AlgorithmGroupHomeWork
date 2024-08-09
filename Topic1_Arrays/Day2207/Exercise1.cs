//https://leetcode.com/problems/two-sum/submissions/1340665663/

/*
+ To use Dictionary
    + Key: current value
    + Value: idx of its
+ When looping every single element, I need to get target minus current value to find
whether that value exists in dictionary or not
    + If it doesn't exist => add to dictionary
    + If it exists => add to result array to return

Space complexity: O(n)
Time complexity: O(n)
*/

namespace Day2207
{
    public class Exercise1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> myDict = new();

            int[] result = new int[2];

            for (int i = 0; i < nums.Length; ++i)
            {
                int calc = target - nums[i];
                if (myDict.ContainsKey(calc))
                {
                    result[0] = myDict[calc];
                    result[1] = i;
                    break;

                }
                else
                    myDict[nums[i]] = i;
            }

            return result;
        }
    }
}