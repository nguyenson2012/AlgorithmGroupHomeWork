//https://leetcode.com/problems/group-anagrams/

/*
+ To store dictionary
    + Key: character and its occurence in array
    + Value: string with the same group anagram

+ To loop every string in list string
    + for every string, we will build string with every character in string of array and its occurence
    + After building string
        + If string already exists in dictionary => add into dictionary with that key
        + If string doesn't exist in dictionary => add new key and value in dictionary

Space complexity: O(n)
Time complexity: O(n * (m + 26))
*/

namespace Day2407
{
    public class Exercise1
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> myDict = new();

            foreach (string str in strs)
            {
                int[] countChar = new int[26];
                foreach (char c in str)
                    countChar[c - 'a']++;

                string temp = "";
                for (int i = 0; i < 26; ++i)
                {
                    if (countChar[i] != 0)
                    {
                        temp += countChar[i];
                        temp += (char)('a' + i);
                    }
                }

                if (myDict.ContainsKey(temp))
                    myDict[temp].Add(str);
                else
                    myDict[temp] = new List<string> { str };
            }

            return new List<IList<string>>(myDict.Values);
        }
    }
}