//https://leetcode.com/problems/word-search/

/*
+ At every position which starts with the first character as word string
    => We will run dfs on that position from top, left, down to right
    => To check whether from that position we can find word in board or not

Space complexity: O(4 ^ (M * N)): (4 is four paths which each position can go)
Time complexity: O(M * N * 4 ^ (M * N)) (4 is four paths which each position can go)
*/

namespace Day2708
{
    public class Exercise2
    {
        public bool Exist(char[][] board, string word)
        {
            int m = board.Length;
            int n = board[0].Length;

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (board[i][j].Equals(word[0]))
                    {
                        bool check = _dfs(board, m, n, i, j, 0, word);

                        if (check == true)
                            return true;
                    }

                }
            }

            return false;
        }

        private bool _dfs(char[][] board, int m, int n, int i, int j, int idx, string word)
        {
            if (idx == word.Length)
                return true;

            if (i < 0 || j < 0 || i == m || j == n || board[i][j] == '0' || word[idx] != board[i][j])
                return false;

            char curVal = board[i][j];

            board[i][j] = '0'; // to mark this cell as visited

            bool top = _dfs(board, m, n, i - 1, j, idx + 1, word);
            bool left = _dfs(board, m, n, i, j - 1, idx + 1, word);
            bool down = _dfs(board, m, n, i + 1, j, idx + 1, word);
            bool right = _dfs(board, m, n, i, j + 1, idx + 1, word);

            board[i][j] = curVal; // to return back value of this cell

            return top || left || down || right;
        }
    }
}