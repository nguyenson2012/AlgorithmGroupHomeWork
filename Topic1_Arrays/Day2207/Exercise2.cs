//https://leetcode.com/problems/number-of-islands/description/

/*
+ To use recursion technique
+ I will loop every single element in 2d arrays
+ If current value is '1' => not visited => backtracking that position and plus 1 value of result
+ When backtracking current position, mark its neightbor values as '2' (islands but visited)

Space complexity: O(n^2)
Time complexity: O(1)
*/

namespace Day2207
{
    public class Exercise2
    {
        public int NumIslands(char[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;

            int result = 0;

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    if (grid[i][j] == '1')
                    {
                        ++result;
                        Backtrack(grid, i, j, row, col);
                    }
                }
            }

            return result;
        }

        private void Backtrack(char[][] grid, int i, int j, int m, int n)
        {
            if (i < 0 || i == m || j < 0 || j == n || grid[i][j] != '1')
                return;

            grid[i][j] = '2'; // visited

            Backtrack(grid, i - 1, j, m, n);
            Backtrack(grid, i, j - 1, m, n);
            Backtrack(grid, i + 1, j, m, n);
            Backtrack(grid, i, j + 1, m, n);
        }
    }
}