//https://leetcode.com/problems/letter-combinations-of-a-phone-number/

/*
+ We will get value in strs[] based on value of current position
+ After that, we will add that to "temp" string
+ Run recursive function in the next idx
+ Remove the last element in temp string

Space complexity: O(N * 4^N): (4 is longest length in strs)
Time complexity: O(N * 4^N) (4 is longest length in strs)
*/

namespace Day2308
{
    public class Exercise1
    {
        private string[] strs = {
            "-1",
            "-1",
            "abc",
            "def",
            "ghi",
            "jkl",
            "mno",
            "pqrs",
            "tuv",
            "wxyz",
        };
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();

            if (digits.Length == 0)
                return result;

            string temp = "";
            _backTracking(0, digits, result, temp);

            return result;
        }

        private void _backTracking(int idx, string digits, IList<string> result, string temp)
        {
            if (temp.Length == digits.Length)
            {
                result.Add(temp);
                return;
            }

            for (int i = idx; i < digits.Length; ++i)
            {
                int digit = int.Parse(digits[i].ToString());
                for (int j = 0; j < strs[digit].Length; ++j)
                {
                    temp += strs[digit][j];

                    _backTracking(i + 1, digits, result, temp);

                    temp = temp.Substring(0, temp.Length - 1);
                }
            }
        }
    }
}