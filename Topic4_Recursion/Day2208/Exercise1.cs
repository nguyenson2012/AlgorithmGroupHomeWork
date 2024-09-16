//https://leetcode.com/problems/find-the-winner-of-the-circular-game/


namespace Day2208
{
    public class Exercise1
    {
        public class Solution1
        {
            /*
            + After removing element at k, the new idx will begin at: idx + 1 (idx + k)

            Space complexity: O(N)
            Time complexity: O(N)
            */
            public int FindTheWinner(int n, int k)
            {
                return _func(n, k) + 1;
            }

            private int _func(int n, int k)
            {
                if (n == 1)
                    return 0;

                return (_func(n - 1, k) + k) % n;
            }
        }


        public class Solution2
        {
            /*
            + After removing element at k, the new idx will begin at: idx + 1 (idx + k)

            Space complexity: O(N)
            Time complexity: O(1)
            */
            public int FindTheWinner(int n, int k)
            {
                int winner = 0;

                for (int i = 2; i <= n; ++i)
                    winner = (winner + k) % i;

                //to make 0 indexing become 1 indexing
                return winner + 1;
            }
        }
    }
}