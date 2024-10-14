// Time complexity: O(n) 
// Space complexity: O(1) 
// Explanation: Using stack to store operand. 
//		If meet operator pop 2 latest operands out of stack for calculation.
//		Then, push the result of calculation to the stack.

class Solution {
public:
    bool isOperator(string tok){
        return tok == "+" || tok == "-" || tok == "*" || tok == "/";
    }
    
    int calc(int operand1, int operand2, string tok){
        if(tok == "+")
            return operand1 + operand2;
        else if(tok == "-")
            return operand1 - operand2;
        else if(tok == "*")
            return operand1 * operand2;
        else if(tok == "/")
            return operand1 / operand2;
        
        return 0; 
    }
    int evalRPN(vector<string>& tokens) {
        stack<int> st;
        for(string tok : tokens){
            if(isOperator(tok)){
                int operand2 = st.top();
                st.pop();
                int operand1 = st.top();
                st.pop();
                st.push(calc(operand1, operand2, tok));
            }else{
                st.push(stoi(tok));
            }
        }
        return st.top();
    }
};