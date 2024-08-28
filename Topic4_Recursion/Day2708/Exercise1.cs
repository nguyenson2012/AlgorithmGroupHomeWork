//https://leetcode.com/problems/path-with-maximum-gold/description/

/*
+ At every position which has gold value
    => We will run dfs on that position from top, left, down to right
    => Find maximum between these 4 values

Space complexity: O(4 ^ (M * N)): (4 is four paths which each position can go)
Time complexity: O(M * N * 4 ^ (M * N)) (4 is four paths which each position can go)
*/

namespace Day2708
{
    public class Exercise1
    {
        public int GetMaximumGold(int[][] grid)
        {
            int result = 0;

            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] != 0)
                    {
                        int calc = _dfs(grid, m, n, i, j);

                        result = Math.Max(result, calc);
                    }

                }
            }

            return result;
        }

        private int _dfs(int[][] grid, int m, int n, int i, int j)
        {
            if (i < 0 || j < 0 || i == m || j == n || grid[i][j] == 0)
                return 0;

            int maxGold = 0;

            int curVal = grid[i][j];

            grid[i][j] = 0; // to mark this cell as visited

            maxGold =
                FindMax(maxGold,
                    curVal + _dfs(grid, m, n, i - 1, j),
                    curVal + _dfs(grid, m, n, i, j - 1),
                    curVal + _dfs(grid, m, n, i + 1, j),
                    curVal + _dfs(grid, m, n, i, j + 1));

            grid[i][j] = curVal; // to return back value of this cell

            return maxGold;
        }

        static int FindMax(params int[] numbers)
        {
            return numbers.Max();
        }
    }
}