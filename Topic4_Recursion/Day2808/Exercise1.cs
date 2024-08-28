//https://leetcode.com/problems/combinations

/*
+ To run every idx based on n
    + With every idx => push it to temp array and continue to run recursion
    on the next idx
    + Push to result array when length of temp array equals to k
    + Must remember to remove the last idx in temp array for the next iteration

Space complexity: O(K)
Time complexity: O(N * K)  
    => The backtrack function is called n times, because there are n possible starting points for the subset. 
    For each starting point, the backtrack function iterates through all k elements
*/
namespace Day2808
{
    public class Exercise1
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            List<IList<int>> result = [];
            List<int> temp = [];

            _backTracking(n, k, 1, temp, result);

            return result;
        }

        private void _backTracking(int n, int k, int idx, List<int> temp, List<IList<int>> result)
        {
            if (temp.Count == k)
            {
                result.Add(temp.ToArray());
                return;
            }
            for (int i = idx; i <= n; ++i)
            {
                temp.Add(i);
                _backTracking(n, k, i + 1, temp, result);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}