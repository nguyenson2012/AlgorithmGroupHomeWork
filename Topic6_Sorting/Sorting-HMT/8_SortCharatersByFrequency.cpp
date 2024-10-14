// Time complexity: O(n)
// Space complexity: O(n) - frequency vector
// Explanation: Using map to count frequency. 
//		Then, copy map into vector and sort vector.

class Solution {
public:
    static bool cmp(pair<char, int>& a, pair<char, int>& b){
        return a.second > b.second;
    }

    string frequencySort(string s) {
        map<char, int> freqMp;
        for(char c : s){
            freqMp[c]++;
        }

        vector<pair<char, int>> freqVec(freqMp.begin(), freqMp.end());
        sort(freqVec.begin(), freqVec.end(), cmp);

        string res;
        for (auto i : freqVec) {
            for (int j = 1; j <= i.second; j++) {
                res += i.first;
            }
        }
        return res;
    }
};