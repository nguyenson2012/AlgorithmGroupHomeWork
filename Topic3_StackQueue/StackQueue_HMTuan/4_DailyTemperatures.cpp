// Time complexity: O(n) 
// Space complexity: O(n) - Using stack 
// Explanation: Using stack to store previous temperature that lower. 
//		If meet temperature higher pop until the top of stack < current temperature.
//		Else, push the temperature in stack.

class Solution {
public:
    vector<int> dailyTemperatures(vector<int>& temperatures) {
        int len = temperatures.size();
        vector<int> ans(len);
        stack<int> st;
        for(int i = 0; i < len; i++){
            while(!st.empty() && temperatures[st.top()] < temperatures[i]){
                ans[st.top()] = i - st.top(); 
                st.pop();
            }
            st.push(i);
        }
        while(!st.empty()){
            ans[st.top()] = 0;
            st.pop();
        }
        return ans;
    }
};