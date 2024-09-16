//https://leetcode.com/problems/fibonacci-number/description/

/*
+ base case: n = 0 or n = 1

Space complexity: O(1)
Time complexity: O(n)
*/
namespace Day1908
{
    public class Exercise1
    {
        public int Fib(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}