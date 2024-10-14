// Time complexity: O(n)
// Space complexity: O(n) 
// Explanation: Using hash map to store frequency
//		Then, check if 2 map is the same

class Solution {
public:
    bool isAnagram(string s, string t) {
        if(s.size() != t.size())
            return false;
        unordered_map<char, int> sMap;
        unordered_map<char, int> tMap;

        for(int i = 0; i < s.size(); i++){
            sMap[s[i]]++;
            tMap[t[i]]++;
        }
        if(sMap == tMap)
            return true;
        return false;
    }
};