//https://leetcode.com/problems/happy-number/

/*
+ To use slow and fast pointer technique in Linked List
    + slow: to count number at slow position
    + fasst: to count number at fast position
+ If slow and fast pointers meet together and it doesn't meet at 1 value => a cycle => return false
+ return true;

Space complexity: O(1)
Time complexity: O(n): 
*/

namespace Day0908
{
    public class Exercise1
    {
        public bool IsHappy(int n)
        {
            if (n == 1)
                return true;

            int slow = n;
            int fast = n;

            while (fast != 1)
            {
                slow = _countNumber(slow);
                fast = _countNumber(_countNumber(fast));

                //if there is a cycle not at 1
                if (slow == fast && fast != 1)
                    return false;

            }

            return true;
        }

        private int _countNumber(int n)
        {
            int result = 0;
            while (n != 0)
            {
                result += (int)Math.Pow(n % 10, 2.0);
                n /= 10;
            }

            return result;
        }
    }
}