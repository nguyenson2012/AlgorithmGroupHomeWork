
//https://leetcode.com/problems/find-common-characters/


/*
+To use character array technique
+ For every word, I will loop every character and increase one value based on current character in charCount array
+ After that, I will compare charCount array with original arr to get min value between these values
+ To loop original array and add valid character in result list
+ Return result

Space complexity: O(26)
Time complexity: O(n * m)
*/


namespace Day2507
{
    public class Exercise3
    {
        public IList<string> CommonChars(string[] words) {
            List<string> result = new();

            int[] arr = new int[26];
            Array.Fill(arr, int.MaxValue);

            foreach(string word in words)
            {
                int[] charCount = new int[26];
                
                foreach(char character in word)
                    charCount[character - 'a'] += 1;

                for (int i = 0; i < 26; i++)
                    arr[i] = Math.Min(arr[i], charCount[i]);
            }

            for (int i = 0; i < 26; i++) {
                for (int j = 0; j < arr[i]; j++) {
                    result.Add(((char)(i + 'a')).ToString());
                }
            }
            return result;
        }
    }
}