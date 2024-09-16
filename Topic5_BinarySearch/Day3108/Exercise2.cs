//https://leetcode.com/problems/koko-eating-bananas/

/*
+ Using binary search technique (range from [1, Max])
+ To access middle position of that range
    + After calculating how many bananas can eat within a hour
        => If that value is smaller than h => move to left to search 
        => Otherwise => move to right to search 

Space complexity: O(1)
Time complexity: O(log(maxi) * N)  
*/


namespace Day3108
{
    public class Exercise2
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1;
            int right = piles.Max();

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long calc = _countBananaWithInHours(piles, mid);

                if (calc <= h)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return left;
        }

        private long _countBananaWithInHours(int[] piles, int k)
        {
            long result = 0;
            foreach (int pile in piles)
                result += pile % k == 0 ? pile / k : (pile / k) + 1;

            return result;
        }
    }
}