//https://leetcode.com/problems/sort-characters-by-frequency/

/*
+ To count the frequency of every character in dictionary
+ To sort based on that dictionary
    + If the frequeny of 2 elements is different => sort on that frequency
    + Otherwise => sort based on alphabet

Space complexity: O(N)
Time complexity: O(NlogN)  
*/

namespace Day0709
{
    public class Exercise1
    {
        public string FrequencySort(string str)
        {
            Dictionary<char, int> dict = new();
            foreach (char s in str)
            {
                if (dict.ContainsKey(s))
                    dict[s]++;
                else
                    dict[s] = 1;
            }

            char[] charArray = str.ToCharArray();

            Array.Sort(charArray, (x, y) =>
            {
                int val1 = dict[x];
                int val2 = dict[y];

                if (val1 != val2)
                    return val2.CompareTo(val1);

                return x.CompareTo(y);

            });
            return new string(charArray);
        }
    }
}