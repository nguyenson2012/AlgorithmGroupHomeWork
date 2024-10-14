// Time complexity: O(n) 
// Space complexity: O(n) 
// Explanation: The codes explain itself =))

class Solution {
public:
    string decodeString(string s) {
        stack<char> st;
        for(char c : s){
            if(c != ']'){
                st.push(c);
                continue;
            }

            // Extract the encoded string
            string encodedStr = "";
            while(!st.empty() && st.top() != '[') {
                encodedStr = st.top() + encodedStr;
                st.pop();
            }
            // Pop '['
            st.pop(); 

            // Get the multiplier (number before '[')
            string multiplierStr = "";
            while(!st.empty() && isdigit(st.top())) {
                multiplierStr = st.top() + multiplierStr;
                st.pop();
            }

            // Repeat the encoded string and push back to the stack
            int multiplier = stoi(multiplierStr);
            string repeatedStr = "";
            for(int i = 0; i < multiplier; ++i) {
                repeatedStr += encodedStr;
            } 

            for(char c : repeatedStr) {
                st.push(c);
            }
        }

        string result = "";
        while(!st.empty()) {
            result = st.top() + result;
            st.pop();
        }
        
        return result;
    }
};