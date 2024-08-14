// Time complexity: O(n) 
// Space complexity: O(n) - using stack to store char
// Explanation: Iterate through given string. 
// 		Push open bracket and pop the corresponding closing one.

class Solution {
public:
    bool isValid(string s) {
        stack<char> st;
        for(char c : s){
           if(st.empty()){
            st.push(c);
           }
            else{
                if(st.top() == '(' && c == ')'){
                    st.pop();
                }else if(st.top() == '{' && c == '}'){
                    st.pop();
                }else if(st.top() == '[' && c == ']'){
                    st.pop();
                }else{
                    st.push(c);
                }
            }
        }
        if(st.empty()) return true;
        return false;
    }
};