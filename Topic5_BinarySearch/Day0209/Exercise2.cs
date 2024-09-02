//https://leetcode.com/problems/time-based-key-value-store/

/*
+ Because when wet set a new element based on key, the timestamp will be larger than the last one
+ Using binary search technique to search

+ Find the element at the middle of list based on key
    + If that element is smaller than or equals to target 
        => assign current key to result
        => that element on right side
    + If that element is smaller than target => that element on left side

Space complexity: O(1)
Time complexity: O(logN)  
*/

namespace Day0209
{
    public class Exercise2
    {
        public class TimeMap
        {
            Dictionary<string, List<KeyValuePair<string, int>>> dictionary;
            public TimeMap()
            {
                dictionary = new();
            }

            public void Set(string key, string value, int timestamp)
            {
                if (dictionary.ContainsKey(key))
                    dictionary[key].Add(new KeyValuePair<string, int>(value, timestamp));
                else
                {
                    dictionary[key] = new List<KeyValuePair<string, int>>();
                    dictionary[key].Add(new KeyValuePair<string, int>(value, timestamp));
                }
            }

            public string Get(string key, int timestamp)
            {
                if (!dictionary.ContainsKey(key))
                    return "";
                else
                {
                    List<KeyValuePair<string, int>> temp = dictionary[key];

                    //run binary search
                    int left = 0;
                    int right = temp.Count - 1;

                    string result = "";

                    while (left <= right)
                    {
                        int mid = left + (right - left) / 2;

                        if (temp[mid].Value <= timestamp)
                        {
                            result = temp[mid].Key;
                            left = mid + 1;
                        }
                        else
                            right = mid - 1;
                    }

                    return result;
                }
            }
        }
    }
}