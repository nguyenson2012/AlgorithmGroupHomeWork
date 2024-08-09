//https://leetcode.com/problems/longest-consecutive-sequence/

/*
+ I will add every element into set
+ For every single element in array, I will check whether it has the previous value or not
+ If there exists that value, I will loop by increasing one value of current value in array.
Every loop, I will continue to check if value after increasing exists in set or not.
If it exists, plus one value. Otherwise, break that loop
+ To get maximum value between that count value and result value

+ Return the result

Space complexity: O(n)
Time complexity: O(n)
*/

namespace Day2707
{
    public class Exercise1
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new();
            int result = 0;

            foreach (int num in nums)
                set.Add(num);

            foreach (int num in nums)
            {
                int candidate = num;
                int before = candidate - 1;

                //the start of sequence or this has been already looped before
                if (!set.Contains(before))
                {
                    int count = 0;

                    while (set.Contains(candidate++))
                        ++count;

                    result = Math.Max(result, count);

                }
            }
            return result;
        }
    }
}