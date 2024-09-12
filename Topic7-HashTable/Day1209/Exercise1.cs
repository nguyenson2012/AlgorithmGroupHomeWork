using System.Text;

//https://leetcode.com/problems/group-anagrams/

/*
+ Using dictionary technique
    + Key: string to store element and a number of its frequency in array
    + Value: string corresponds to that key
Space complexity: O(N)
Time complexity: O(N * (M + 26))
*/

namespace Day1209
{
    public class Exercise1
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = [];

            foreach (string str in strs)
            {
                int[] charArr = new int[26];

                foreach (char c in str)
                    charArr[c - 'a']++;

                StringBuilder temp = new();

                for (int i = 0; i < 26; ++i)
                {
                    char letter = (char)('a' + i);

                    if (charArr[i] != 0)
                    {
                        temp.Append(charArr[i]);
                        temp.Append(letter);
                    }

                }
                if (!dict.ContainsKey(temp.ToString()))
                    dict[temp.ToString()] = [];

                dict[temp.ToString()].Add(str);

            }

            return new List<IList<string>>(dict.Values);
        }
    }
}