//https://leetcode.com/problems/generate-parentheses/

/*
+ At every position, I will have 2 options but the number of
open parenthesis must be lower or equals than close parenthesis
    + Add "(" into string
    + Add ")" into string

Space complexity: O(N) (recursion stack)
Time complexity: O(2^(2 * N)): Every position can have 2 possible parenthesis (open or close)
*/

namespace Day2308
{
    public class Exercise2
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = [];
            string temp = "";

            _backTracking(n, n, temp, result);

            return result;
        }

        private void _backTracking(int open, int close, string temp, IList<string> result)
        {
            if (open == 0 && close == 0)
            {
                result.Add(temp);
                return;
            }

            if (open >= 0 && open <= close)
            {
                temp += "(";
                _backTracking(open - 1, close, temp, result);

                temp = temp.Substring(0, temp.Length - 1);

                temp += ")";
                _backTracking(open, close - 1, temp, result);

            }
        }
    }
}