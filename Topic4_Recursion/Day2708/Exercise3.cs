//https://leetcode.com/problems/palindrome-partitioning/

/*
+ To run every element in string
    + To check whether string temp after being cut from previous idx to current i is palindrome or not
    + If palindrome, run on next idx
    + Otherwise => do nothing

Space complexity: O(N * N)
Time complexity: O(N * 2 ^ N)  (2 options whether we decide to choose that element or not)
*/
namespace Day2708
{
    public class Exercise3
    {
        public IList<IList<string>> Partition(string s)
        {
            List<IList<string>> result = [];
            List<string> temp = new();
            int Length = s.Length;

            _func(s, 0, temp, result);

            return result;
        }

        private void _func(string s, int idx, List<string> path, List<IList<string>> result)
        {
            if (idx == s.Length)
            {
                result.Add(path.ToArray());
                return;
            }
            for (int i = idx; i < s.Length; ++i)
            {
                string temp = s.Substring(idx, i - idx + 1);
                //run recursion on string which is palindrome
                if (_isPalindrome(temp))
                {
                    path.Add(temp);
                    _func(s, i + 1, path, result);
                    path.RemoveAt(path.Count - 1);
                }
            }
        }

        private bool _isPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left++] != s[right--])
                    return false;
            }
            return true;
        }
    }
}