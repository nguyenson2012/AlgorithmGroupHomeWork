//https://leetcode.com/problems/valid-anagram/

/*
+ Using array containing 26 lowercase English character
    + First loop: to count the frequency of string s
    + Second loop: to count the frequency of string t
    + Third loop: To check to know that there is difference between 2 strings
Space complexity: O(26)
Time complexity: O(N)
*/

namespace Day1309
{
    public class Exercise2
    {
        public bool IsAnagram(string s, string t)
        {
            int[] charArr = new int[26];

            int Length1 = s.Length;
            int Length2 = t.Length;

            if (Length1 != Length2) return false;

            for (int i = 0; i < Length1; ++i)
                ++charArr[s[i] - 'a'];

            for (int i = 0; i < Length2; ++i)
                --charArr[t[i] - 'a'];

            for (int i = 0; i < 26; ++i)
            {
                if (charArr[i] != 0)
                    return false;
            }

            return true;
        }
    }
}