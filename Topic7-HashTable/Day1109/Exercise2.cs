//https://leetcode.com/problems/max-number-of-k-sum-pairs/

/*
+ Using dictionary technique

+ when iterating one element in array, I can check after substracting k with that element
+ If result is contained in array => answer and substract one value of that key in dictionary
+ Otherwise => add element into dictionary

Space complexity: O(N)
Time complexity: O(N)
*/

namespace Day1109
{
    public class Exercise2
    {
        public int MaxOperations(int[] nums, int k)
        {
            Dictionary<int, int> dict = new();
            int result = 0;

            foreach (int num in nums)
            {
                int count = k - num;
                if (dict.TryGetValue(count, out int value1))
                {
                    ++result;
                    dict[count] = --value1;

                    if (value1 == 0)
                        dict.Remove(count);
                }
                else
                {
                    if (dict.TryGetValue(num, out int value2))
                        dict[num] = ++value2;
                    else
                        dict[num] = 1;
                }
            }
            return result;
        }
    }
}