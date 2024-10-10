// Time complexity: O(n)
// Space complexity: O(n) - vector<long long> result(arr.size());
// Explanation: Using hash map(store frequency and index) and prefixSum
//		Using sum, prefixSum, len to find the result[idx] where idx: index in vector<int> arr 
//		Because, It will take time if you calculate diff of index of identical element

class Solution {
public:
    vector<long long> getDistances(vector<int>& arr) {
	// freqMp stores <freq, vector<int> index of identical element>> pairs
        unordered_map<int, vector<int>> freqMp;
        for(int i = 0; i < arr.size(); i++){
            vector<int>& freqVec = freqMp[arr[i]];
            freqVec.push_back(i);
        }

        vector<long long> result(arr.size());
        for(auto entry : freqMp){
            int len = entry.second.size();
            long long sum = 0;
            for(int idx : entry.second)
                sum += idx;
            
            long long prefixSum = 0;
	    // i: index in vector<int> index of identical element corresponding to frequency of  
            for(long long i = 0; i < len; i++){
		// idx: index in vector<int> arr
                int idx = entry.second[i];
		
		// result = idx * i - left side (prefix sum) + 
		// right side (sum - prefixSum - idx) - - (len - i - 1) * idx
                result[idx] = idx * i - prefixSum + 
                    (sum - prefixSum - idx) - (len - i - 1) * idx; 
                prefixSum += idx;
            }
        }
        return result;
    }
};