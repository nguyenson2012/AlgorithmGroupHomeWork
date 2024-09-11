//https://leetcode.com/problems/design-hashmap/

/*
+ Using map technique
+ Because value is -1 as can not find => we will add 1 value when adding key into map array
+ And remove 1 value when getting that value from array
Space complexity: O(10000000)
Time complexity: O(1)
*/
namespace Day1109
{
    public class Exercise1
    {
        public class MyHashMap
        {
            readonly int[] map;
            public MyHashMap()
            {
                map = new int[10000000];
            }

            public void Put(int key, int value)
            {
                map[key] = value + 1;
            }

            public int Get(int key)
            {
                return map[key] - 1;
            }

            public void Remove(int key)
            {
                //0 is treated as no key present
                map[key] = 0;
            }
        }
    }
}


