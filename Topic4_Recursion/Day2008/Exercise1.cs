//https://leetcode.com/problems/powx-n/description/

/*
+ Base case: n = 1
  + To get current x * recursive function after minusing n 1 value
  + If n is even number => multiple x together to reduce time complexity

Space complexity: O(N)
Time complexity: O(N)
*/
namespace Day2008
{
    public class Exercise1
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;

            long nn = n;

            double ans = _backTracking(x, Math.Abs(nn));

            return n > 0 ? ans : (double)1 / ans;
        }

        private double _backTracking(double x, double n)
        {
            if (n == 1) return x;

            if (n % 2 == 0) return _backTracking(x * x, n / 2);

            return x * _backTracking(x, n - 1);
        }
    }
}