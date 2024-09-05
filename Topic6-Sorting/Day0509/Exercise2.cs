//https://leetcode.com/problems/largest-number/

/*
+ To sort array based on adding 2 strings

Space complexity: O(N)
Time complexity: O(N logN)  
*/

namespace Day0509
{
    public class Exercise2
    {
        public string LargestNumber(int[] nums)
        {
            if (nums.All(num => num == 0)) return "0";

            Array.Sort(nums, (a, b) =>
            {
                string strA = a.ToString();
                string strB = b.ToString();

                return -(strA + strB).CompareTo(strB + strA);

            });
            return string.Concat(nums);
        }
    }
}