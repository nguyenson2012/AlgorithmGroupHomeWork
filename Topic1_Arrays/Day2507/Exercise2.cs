//https://leetcode.com/problems/subarray-sum-equals-k/description/


/*
+ To store [key, value] ([currentSum, occurence]) in dictionary
+ I will have sum variable to sum all the elements from the beginning to current position
+ At every position, I will find whether key: currentSum - k exists in dictionary or not. If it exists, it means that 
there's definetely an subarray equals to sum => plus the occurence of that sum into result
+ To add current sum with occurence equals to 1 into dictionary if current sum doesn't exist. Otherwise, plus the occurence of
that sum one value
+ Return the result


Space complexity: O(n)
Time complexity: O(n)
*/

namespace Day2507
{
    public class Exercise2
    {
        public int SubarraySum(int[] nums, int k) {
            int result = 0;

            Dictionary<int, int> myDict = new();
            myDict[0] = 1;

            int sum = 0;
            
            foreach(int num in nums)
            {
                sum += num;

                if (myDict.ContainsKey(sum - k))
                    result += myDict[sum - k];

                if (!myDict.ContainsKey(sum))
                    myDict[sum] = 1;
                else
                    myDict[sum] += 1;
            }
            return result;
        }
    }
}