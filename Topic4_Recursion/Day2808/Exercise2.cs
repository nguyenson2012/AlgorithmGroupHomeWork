//https://leetcode.com/problems/combination-sum-ii/

/*
+ To run every element of input array
    + With every idx => push it to temp array and continue to run recursion
    on the next idx
    + Push to result array when target equals to 0
    + Must remember to remove the last idx in temp array for the next iteration
    + Remove duplicate combinations by sorting array first and then move the new element in array

Space complexity: O(K * N)
    => k is the number of valid combinations
    => n is the length of each combination
Time complexity: O(N logn + (K ∗ (2 ^ N))
    => k is number of valid combinations
    => The DFS algorithm has a worst-case time complexity of O(2^n)
*/

namespace Day2808
{
    public class Exercise2
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<IList<int>> result = [];
            List<int> temp = [];

            Array.Sort(candidates);

            _backTracking(candidates, target, 0, temp, result);

            return result;
        }

        private void _backTracking(int[] candidates, int target, int idx, List<int> temp, List<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(temp.ToArray());
                return;
            }

            if (target < 0 || idx == candidates.Length)
                return;

            for (int i = idx; i < candidates.Length; ++i)
            {
                temp.Add(candidates[i]);

                _backTracking(candidates, target - candidates[i], i + 1, temp, result);

                temp.RemoveAt(temp.Count - 1);

                while ((i + 1) < candidates.Length && candidates[i] == candidates[i + 1])
                    ++i;
            }
        }
    }
}